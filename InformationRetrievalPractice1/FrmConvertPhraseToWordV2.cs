using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InformationRetrievalPractice1
{
    public partial class FrmConvertPhraseToWordV2 : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private string[] selectedFiles;
        private List<Word> listWords;
        public FrmConvertPhraseToWordV2()
        {
            InitializeComponent();
        }

        private void BtnUploadFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "ជ្រើសរើសឯកសារ";
                ofd.Filter = "ប្រភេទឯកសារ .txt|*.txt";
                ofd.Multiselect = true;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    TxtPhrase.Text = string.Empty;
                    selectedFiles = ofd.FileNames;
                    lblNoOfFiles.Text = string.Format("ចំនួនឯកសារ ({0})", selectedFiles.Count());
                    foreach (var file in selectedFiles)
                    {
                        using (var readFile = new StreamReader(file))
                        {
                            var readText = readFile.ReadToEnd();
                            TxtPhrase.Text += readText;
                        }
                    }
                }
            }
        }

        private void BtnConvertWord_Click(object sender, EventArgs e)
        {
            if (selectedFiles != null)
            {
                listWords = new List<Word>();
                int docId = GetLastDocID();
                foreach (var file in selectedFiles)
                {
                    docId++;
                    string line;
                    var readFile = new StreamReader(file);
                    while ((line = readFile.ReadLine()) != null)
                    {
                        string getOnlyAphabets = Regex.Replace(line, @"[^A-Za-z- ]", "");
                        string[] words = getOnlyAphabets.Split(' ');
                        string[] sortWords = words.OrderBy(w => w).ToArray();
                        string[] removeEmtyElement = sortWords.Where(w => w != string.Empty).ToArray();
                        foreach (string word in removeEmtyElement)
                        {
                            var w = new Word
                            {
                                Term = word,
                                WordCount = 1,
                                DocID = docId
                            };
                            listWords.Add(w);
                        }
                    }
                }

                DgvWord.DataSource = listWords;
            }
        }

        private void RefreshData()
        {
            DgvWord.DataSource = GetData();
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            if (listWords != null)
            {
                Save();
                RefreshData();
            }
        }

        private void Save()
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                foreach (var word in listWords)
                {
                    string sqlQuery = "INSERT INTO Word VALUES(@Term, @DocID)";
                    using (var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.Add("@Term", SqlDbType.NVarChar).Value = word.Term;
                        sqlCommand.Parameters.Add("@DocID", SqlDbType.Int).Value = word.DocID;
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                ClearControl();
                MessageBox.Show("ទិន្នន័យត្រូវបានរក្សាទុកដោយជោគជ័យ", "រក្សាទុកទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
            }
        }

        private int GetLastDocID()
        {
            using(var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string sqlQuery = "SELECT MAX(DocID) as ID FROM Word";
                using(var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    try
                    {
                        return (int)sqlCommand.ExecuteScalar();
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
        }

        private void ClearControl()
        {
            lblNoOfFiles.Text = "ចំនួនឯកសារ (0)";
            selectedFiles = null;
            listWords = null;
            TxtPhrase.Text = string.Empty;
        }

        private DataTable GetData()
        {
            using(var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string sqlQuery = "SELECT Term, 1 as WordCount, DocID FROM Word ORDER BY Term, DocID";
                using(var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    using(var sqlDataAdaptor = new SqlDataAdapter(sqlCommand))
                    {
                        using(var dataTable = new DataTable())
                        {
                            sqlDataAdaptor.Fill(dataTable);
                            sqlConnection.Close();
                            return dataTable;
                        }
                    }
                }
            }
        }

        private DataTable GetGroupData()
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string sqlQuery = @"SELECT LOWER(Term) AS 'Term', 
                                           COUNT(Term) AS 'WordCount', 
                                           'DocID' = STUFF
                                           (
                                               (
                                                   SELECT ', ' + CAST(b.DocID AS varchar(max))
                                                   FROM Word b 
                                                   WHERE b.Term = a.Term 
                                                   GROUP BY b.DocID -- Group by DocID to ensure distinct values
                                                   ORDER BY CAST(b.DocID AS int) -- Sorting DocID values
                                                   FOR XML PATH('')
                                               ), 1, 2, ''
                                           )
                                    FROM Word a
                                    GROUP BY Term";
                using (var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    using (var sqlDataAdaptor = new SqlDataAdapter(sqlCommand))
                    {
                        using (var dataTable = new DataTable())
                        {
                            sqlDataAdaptor.Fill(dataTable);
                            sqlConnection.Close();
                            return dataTable;
                        }
                    }
                }
            }
        }

        private void SetGroupData()
        {
            DgvWord.DataSource = GetGroupData();
        }

        private void BtnGroupItem_Click(object sender, EventArgs e)
        {
            SetGroupData();
        }

        private void FrmConvertPhraseToWordV2_Load(object sender, EventArgs e)
        {
            SetGroupData();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void DgvWord_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvWord.Rows.Count)
            {
                if (e.RowIndex % 2 == 0)
                {
                    DgvWord.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else
                {
                    DgvWord.Rows[e.RowIndex].DefaultCellStyle.BackColor = DgvWord.DefaultCellStyle.BackColor;
                }
            }
        }
    }
}
