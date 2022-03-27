namespace DICTIONARY
{
    partial class ExistingDictionaryWindow
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
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.labelNewDict = new System.Windows.Forms.Label();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.labelLangTo = new System.Windows.Forms.Label();
            this.labelLangFrom = new System.Windows.Forms.Label();
            this.buttonToHomeWindow = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Label();
            this.buttonOpenDict = new System.Windows.Forms.PictureBox();
            this.buttonAddTranslation = new System.Windows.Forms.Button();
            this.buttonDeleteTranslation = new System.Windows.Forms.Button();
            this.buttonDeleteWord = new System.Windows.Forms.Button();
            this.buttonExportWordCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonToHomeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOpenDict)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddWord.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddWord.Location = new System.Drawing.Point(113, 390);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(187, 38);
            this.buttonAddWord.TabIndex = 26;
            this.buttonAddWord.Text = "Add Word";
            this.buttonAddWord.UseVisualStyleBackColor = true;
            this.buttonAddWord.Click += new System.EventHandler(this.buttonAddWord_Click);
            // 
            // labelNewDict
            // 
            this.labelNewDict.AutoSize = true;
            this.labelNewDict.BackColor = System.Drawing.Color.Transparent;
            this.labelNewDict.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelNewDict.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewDict.Location = new System.Drawing.Point(190, 28);
            this.labelNewDict.Name = "labelNewDict";
            this.labelNewDict.Size = new System.Drawing.Size(259, 56);
            this.labelNewDict.TabIndex = 25;
            this.labelNewDict.Text = "Dictionary";
            // 
            // textBoxTranslation
            // 
            this.textBoxTranslation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTranslation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxTranslation.Location = new System.Drawing.Point(440, 172);
            this.textBoxTranslation.Multiline = true;
            this.textBoxTranslation.Name = "textBoxTranslation";
            this.textBoxTranslation.ReadOnly = true;
            this.textBoxTranslation.Size = new System.Drawing.Size(250, 180);
            this.textBoxTranslation.TabIndex = 24;
            // 
            // textBoxWord
            // 
            this.textBoxWord.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWord.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxWord.Location = new System.Drawing.Point(113, 172);
            this.textBoxWord.Multiline = true;
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(231, 41);
            this.textBoxWord.TabIndex = 23;
            // 
            // labelLangTo
            // 
            this.labelLangTo.AutoSize = true;
            this.labelLangTo.BackColor = System.Drawing.Color.Transparent;
            this.labelLangTo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLangTo.Location = new System.Drawing.Point(435, 132);
            this.labelLangTo.Name = "labelLangTo";
            this.labelLangTo.Size = new System.Drawing.Size(117, 25);
            this.labelLangTo.TabIndex = 21;
            this.labelLangTo.Text = "Translation";
            // 
            // labelLangFrom
            // 
            this.labelLangFrom.AutoSize = true;
            this.labelLangFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelLangFrom.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLangFrom.Location = new System.Drawing.Point(109, 132);
            this.labelLangFrom.Name = "labelLangFrom";
            this.labelLangFrom.Size = new System.Drawing.Size(65, 25);
            this.labelLangFrom.TabIndex = 20;
            this.labelLangFrom.Text = "Word";
            // 
            // buttonToHomeWindow
            // 
            this.buttonToHomeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonToHomeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToHomeWindow.Location = new System.Drawing.Point(869, 549);
            this.buttonToHomeWindow.Name = "buttonToHomeWindow";
            this.buttonToHomeWindow.Size = new System.Drawing.Size(55, 55);
            this.buttonToHomeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonToHomeWindow.TabIndex = 18;
            this.buttonToHomeWindow.TabStop = false;
            this.buttonToHomeWindow.Click += new System.EventHandler(this.buttonToHomeWindow_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose.Location = new System.Drawing.Point(624, -96);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(23, 22);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.Text = "X";
            // 
            // buttonOpenDict
            // 
            this.buttonOpenDict.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenDict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenDict.Image = global::DICTIONARY.Properties.Resources.openDictionary1;
            this.buttonOpenDict.Location = new System.Drawing.Point(1, -2);
            this.buttonOpenDict.Name = "buttonOpenDict";
            this.buttonOpenDict.Size = new System.Drawing.Size(132, 112);
            this.buttonOpenDict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonOpenDict.TabIndex = 27;
            this.buttonOpenDict.TabStop = false;
            // 
            // buttonAddTranslation
            // 
            this.buttonAddTranslation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTranslation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTranslation.Location = new System.Drawing.Point(113, 446);
            this.buttonAddTranslation.Name = "buttonAddTranslation";
            this.buttonAddTranslation.Size = new System.Drawing.Size(187, 38);
            this.buttonAddTranslation.TabIndex = 28;
            this.buttonAddTranslation.Text = "Add Translation";
            this.buttonAddTranslation.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTranslation
            // 
            this.buttonDeleteTranslation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteTranslation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTranslation.Location = new System.Drawing.Point(323, 446);
            this.buttonDeleteTranslation.Name = "buttonDeleteTranslation";
            this.buttonDeleteTranslation.Size = new System.Drawing.Size(212, 38);
            this.buttonDeleteTranslation.TabIndex = 30;
            this.buttonDeleteTranslation.Text = "Delete Translation";
            this.buttonDeleteTranslation.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteWord
            // 
            this.buttonDeleteWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteWord.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteWord.Location = new System.Drawing.Point(323, 390);
            this.buttonDeleteWord.Name = "buttonDeleteWord";
            this.buttonDeleteWord.Size = new System.Drawing.Size(212, 38);
            this.buttonDeleteWord.TabIndex = 29;
            this.buttonDeleteWord.Text = "Delete Word";
            this.buttonDeleteWord.UseVisualStyleBackColor = true;
            // 
            // buttonExportWordCard
            // 
            this.buttonExportWordCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExportWordCard.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportWordCard.Location = new System.Drawing.Point(562, 418);
            this.buttonExportWordCard.Name = "buttonExportWordCard";
            this.buttonExportWordCard.Size = new System.Drawing.Size(192, 38);
            this.buttonExportWordCard.TabIndex = 31;
            this.buttonExportWordCard.Text = "Export Word Card";
            this.buttonExportWordCard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(865, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(481, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ExistingDictionaryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 627);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExportWordCard);
            this.Controls.Add(this.buttonDeleteTranslation);
            this.Controls.Add(this.buttonDeleteWord);
            this.Controls.Add(this.buttonAddTranslation);
            this.Controls.Add(this.buttonOpenDict);
            this.Controls.Add(this.buttonAddWord);
            this.Controls.Add(this.labelNewDict);
            this.Controls.Add(this.textBoxTranslation);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.labelLangTo);
            this.Controls.Add(this.labelLangFrom);
            this.Controls.Add(this.buttonToHomeWindow);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExistingDictionaryWindow";
            this.Text = "ExistingDictionary";
            this.Load += new System.EventHandler(this.ExistingDictionaryWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonToHomeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOpenDict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.Label labelNewDict;
        private System.Windows.Forms.TextBox textBoxTranslation;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label labelLangTo;
        private System.Windows.Forms.Label labelLangFrom;
        private System.Windows.Forms.PictureBox buttonToHomeWindow;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.PictureBox buttonOpenDict;
        private System.Windows.Forms.Button buttonAddTranslation;
        private System.Windows.Forms.Button buttonDeleteTranslation;
        private System.Windows.Forms.Button buttonDeleteWord;
        private System.Windows.Forms.Button buttonExportWordCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}