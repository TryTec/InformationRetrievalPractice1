using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InformationRetrievalPractice1
{
    public partial class ConvertPhraseToWord : Form
    {
        private readonly List<string> listFileName = new List<string>(); //For store uploaded files
        private int docID = 0; //For store file id
        private bool isFirstLine = true; //For check condition create column name in first line
        public ConvertPhraseToWord()
        {
            InitializeComponent();
            File.WriteAllText("result.txt", string.Empty); //For clear all text in result.txt
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //For Open File Dialog to select source text file
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Check condition if user click on button OK or Open will get selected file
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName); //Read file from selected file
                string line; //For store text line
                if (!listFileName.Contains(openFileDialog1.SafeFileName)) //Check file name exist or not
                {
                    docID++; //Assign id
                    listFileName.Add(openFileDialog1.SafeFileName); //Add file name with extension
                    while ((line = reader.ReadLine()) != null) //Read text in file line by line
                    {
                        TxtSource.Text = line; //Assign text from line to TextBox for display source text
                        string getOnlyAphabets = Regex.Replace(line, @"[^A-Za-z- ]", "");
                        string[] words = getOnlyAphabets.Split(' '); //line.Split(' '); //Split phrase to word by space
                        string[] sortWords = words.OrderBy(w => w).ToArray();
                        string[] removeEmtyElement = sortWords.Where(w => w != string.Empty).ToArray();
                        foreach (string word in removeEmtyElement) //Get earch word in words array
                        {
                            using (StreamWriter writer = new StreamWriter("result.txt", true)) //Handle text file to write text into and append text
                            {
                                if (isFirstLine) //If first line will add these columns name
                                {
                                    writer.WriteLine("term\tdocID"); //Write these columns name
                                    isFirstLine = false; //Set to false to skip Add columns name next line
                                }
                                writer.WriteLine(word + "\t" + docID); //Add word and docID to result.txt file
                            }
                        }
                    }
                    reader.Close(); //Clear memory

                    reader = new StreamReader("result.txt"); //Read text from this file to display on TextBox result
                    TxtResult.Text = reader.ReadToEnd(); //Display text from result.txt file to TextBox result
                    reader.Close(); //Clear memory
                }
                else
                {
                    MessageBox.Show("Document already uploaded"); //Show when upload exist file name
                }
            }
        }
    }
}
