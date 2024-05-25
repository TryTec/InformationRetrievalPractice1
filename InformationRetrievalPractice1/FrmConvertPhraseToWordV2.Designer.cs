namespace InformationRetrievalPractice1
{
    partial class FrmConvertPhraseToWordV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConvertPhraseToWordV2));
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.TlpMenuLeft = new System.Windows.Forms.TableLayoutPanel();
            this.BtnUploadFile = new System.Windows.Forms.Button();
            this.lblNoOfFiles = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPhrase = new System.Windows.Forms.TextBox();
            this.DgvWord = new System.Windows.Forms.DataGridView();
            this.colTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TlpMenuRight = new System.Windows.Forms.TableLayoutPanel();
            this.BtnConvertWord = new System.Windows.Forms.Button();
            this.BtnSaveFile = new System.Windows.Forms.Button();
            this.BtnGroupItem = new System.Windows.Forms.Button();
            this.TlpMain.SuspendLayout();
            this.TlpMenuLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWord)).BeginInit();
            this.TlpMenuRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 2;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpMain.Controls.Add(this.TlpMenuLeft, 0, 1);
            this.TlpMain.Controls.Add(this.label1, 0, 0);
            this.TlpMain.Controls.Add(this.TxtPhrase, 0, 2);
            this.TlpMain.Controls.Add(this.DgvWord, 1, 2);
            this.TlpMain.Controls.Add(this.TlpMenuRight, 1, 1);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 3;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMain.Size = new System.Drawing.Size(884, 561);
            this.TlpMain.TabIndex = 0;
            // 
            // TlpMenuLeft
            // 
            this.TlpMenuLeft.ColumnCount = 3;
            this.TlpMenuLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TlpMenuLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMenuLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TlpMenuLeft.Controls.Add(this.BtnUploadFile, 0, 0);
            this.TlpMenuLeft.Controls.Add(this.lblNoOfFiles, 1, 0);
            this.TlpMenuLeft.Controls.Add(this.BtnClear, 2, 0);
            this.TlpMenuLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMenuLeft.Location = new System.Drawing.Point(0, 45);
            this.TlpMenuLeft.Margin = new System.Windows.Forms.Padding(0);
            this.TlpMenuLeft.Name = "TlpMenuLeft";
            this.TlpMenuLeft.RowCount = 1;
            this.TlpMenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMenuLeft.Size = new System.Drawing.Size(442, 50);
            this.TlpMenuLeft.TabIndex = 0;
            // 
            // BtnUploadFile
            // 
            this.BtnUploadFile.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnUploadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUploadFile.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUploadFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnUploadFile.Image = global::InformationRetrievalPractice1.Properties.Resources.upload_file32;
            this.BtnUploadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUploadFile.Location = new System.Drawing.Point(3, 3);
            this.BtnUploadFile.Name = "BtnUploadFile";
            this.BtnUploadFile.Size = new System.Drawing.Size(144, 44);
            this.BtnUploadFile.TabIndex = 0;
            this.BtnUploadFile.Text = "បញ្ចូលឯកសារ";
            this.BtnUploadFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUploadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUploadFile.UseVisualStyleBackColor = false;
            this.BtnUploadFile.Click += new System.EventHandler(this.BtnUploadFile_Click);
            // 
            // lblNoOfFiles
            // 
            this.lblNoOfFiles.AutoSize = true;
            this.lblNoOfFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoOfFiles.Location = new System.Drawing.Point(153, 0);
            this.lblNoOfFiles.Name = "lblNoOfFiles";
            this.lblNoOfFiles.Size = new System.Drawing.Size(136, 50);
            this.lblNoOfFiles.TabIndex = 1;
            this.lblNoOfFiles.Text = "ចំនួនឯកសារ (0)";
            this.lblNoOfFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnClear.Image = global::InformationRetrievalPractice1.Properties.Resources.clear32;
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClear.Location = new System.Drawing.Point(295, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(144, 44);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "សម្អាតឯកសារ";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TlpMain.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "បម្លែងអត្ថបទទៅជាពាក្យ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPhrase
            // 
            this.TxtPhrase.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPhrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPhrase.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhrase.Location = new System.Drawing.Point(3, 98);
            this.TxtPhrase.Multiline = true;
            this.TxtPhrase.Name = "TxtPhrase";
            this.TxtPhrase.ReadOnly = true;
            this.TxtPhrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtPhrase.Size = new System.Drawing.Size(436, 460);
            this.TxtPhrase.TabIndex = 2;
            // 
            // DgvWord
            // 
            this.DgvWord.AllowUserToAddRows = false;
            this.DgvWord.AllowUserToDeleteRows = false;
            this.DgvWord.AllowUserToResizeColumns = false;
            this.DgvWord.AllowUserToResizeRows = false;
            this.DgvWord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvWord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvWord.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DgvWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvWord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvWord.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DgvWord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DgvWord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvWord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTerm,
            this.colDocFreq,
            this.colDocID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvWord.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvWord.EnableHeadersVisualStyles = false;
            this.DgvWord.Location = new System.Drawing.Point(445, 98);
            this.DgvWord.MultiSelect = false;
            this.DgvWord.Name = "DgvWord";
            this.DgvWord.ReadOnly = true;
            this.DgvWord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvWord.RowHeadersVisible = false;
            this.DgvWord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvWord.RowTemplate.ReadOnly = true;
            this.DgvWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvWord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvWord.Size = new System.Drawing.Size(436, 460);
            this.DgvWord.TabIndex = 3;
            this.DgvWord.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DgvWord_RowPrePaint);
            // 
            // colTerm
            // 
            this.colTerm.DataPropertyName = "Term";
            this.colTerm.HeaderText = "term";
            this.colTerm.Name = "colTerm";
            this.colTerm.ReadOnly = true;
            // 
            // colDocFreq
            // 
            this.colDocFreq.DataPropertyName = "WordCount";
            this.colDocFreq.HeaderText = "doc. freq.";
            this.colDocFreq.Name = "colDocFreq";
            this.colDocFreq.ReadOnly = true;
            // 
            // colDocID
            // 
            this.colDocID.DataPropertyName = "DocID";
            this.colDocID.HeaderText = "postings lists";
            this.colDocID.Name = "colDocID";
            this.colDocID.ReadOnly = true;
            // 
            // TlpMenuRight
            // 
            this.TlpMenuRight.ColumnCount = 4;
            this.TlpMenuRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TlpMenuRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TlpMenuRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TlpMenuRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMenuRight.Controls.Add(this.BtnConvertWord, 0, 0);
            this.TlpMenuRight.Controls.Add(this.BtnSaveFile, 1, 0);
            this.TlpMenuRight.Controls.Add(this.BtnGroupItem, 2, 0);
            this.TlpMenuRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMenuRight.Location = new System.Drawing.Point(442, 45);
            this.TlpMenuRight.Margin = new System.Windows.Forms.Padding(0);
            this.TlpMenuRight.Name = "TlpMenuRight";
            this.TlpMenuRight.RowCount = 1;
            this.TlpMenuRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMenuRight.Size = new System.Drawing.Size(442, 50);
            this.TlpMenuRight.TabIndex = 0;
            // 
            // BtnConvertWord
            // 
            this.BtnConvertWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnConvertWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConvertWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConvertWord.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvertWord.ForeColor = System.Drawing.Color.Green;
            this.BtnConvertWord.Image = global::InformationRetrievalPractice1.Properties.Resources.convert_word32;
            this.BtnConvertWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConvertWord.Location = new System.Drawing.Point(3, 3);
            this.BtnConvertWord.Name = "BtnConvertWord";
            this.BtnConvertWord.Size = new System.Drawing.Size(124, 44);
            this.BtnConvertWord.TabIndex = 0;
            this.BtnConvertWord.Text = "បម្លែងពាក្យ";
            this.BtnConvertWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConvertWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConvertWord.UseVisualStyleBackColor = false;
            this.BtnConvertWord.Click += new System.EventHandler(this.BtnConvertWord_Click);
            // 
            // BtnSaveFile
            // 
            this.BtnSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSaveFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveFile.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveFile.ForeColor = System.Drawing.Color.Green;
            this.BtnSaveFile.Image = global::InformationRetrievalPractice1.Properties.Resources.save_file32;
            this.BtnSaveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaveFile.Location = new System.Drawing.Point(133, 3);
            this.BtnSaveFile.Name = "BtnSaveFile";
            this.BtnSaveFile.Size = new System.Drawing.Size(124, 44);
            this.BtnSaveFile.TabIndex = 0;
            this.BtnSaveFile.Text = "រក្សារទុក";
            this.BtnSaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSaveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSaveFile.UseVisualStyleBackColor = false;
            this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // BtnGroupItem
            // 
            this.BtnGroupItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGroupItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGroupItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGroupItem.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGroupItem.ForeColor = System.Drawing.Color.Green;
            this.BtnGroupItem.Image = global::InformationRetrievalPractice1.Properties.Resources.group_word32;
            this.BtnGroupItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGroupItem.Location = new System.Drawing.Point(263, 3);
            this.BtnGroupItem.Name = "BtnGroupItem";
            this.BtnGroupItem.Size = new System.Drawing.Size(124, 44);
            this.BtnGroupItem.TabIndex = 0;
            this.BtnGroupItem.Text = "ក្រុមពាក្យ";
            this.BtnGroupItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGroupItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGroupItem.UseVisualStyleBackColor = false;
            this.BtnGroupItem.Click += new System.EventHandler(this.BtnGroupItem_Click);
            // 
            // FrmConvertPhraseToWordV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.TlpMain);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmConvertPhraseToWordV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "បម្លែងអត្ថបទទៅជាពាក្យ (ជំនាន់២.០.០)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConvertPhraseToWordV2_Load);
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            this.TlpMenuLeft.ResumeLayout(false);
            this.TlpMenuLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWord)).EndInit();
            this.TlpMenuRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.TableLayoutPanel TlpMenuLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUploadFile;
        private System.Windows.Forms.TextBox TxtPhrase;
        private System.Windows.Forms.TableLayoutPanel TlpMenuRight;
        private System.Windows.Forms.Button BtnConvertWord;
        private System.Windows.Forms.Button BtnSaveFile;
        private System.Windows.Forms.Label lblNoOfFiles;
        private System.Windows.Forms.Button BtnGroupItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocID;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.DataGridView DgvWord;
    }
}