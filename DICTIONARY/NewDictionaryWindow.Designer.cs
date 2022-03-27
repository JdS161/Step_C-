namespace DICTIONARY
{
    partial class NewDictionaryWindow
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
            this.buttonClose = new System.Windows.Forms.Label();
            this.buttonToHomeWindow = new System.Windows.Forms.PictureBox();
            this.labelLangFrom = new System.Windows.Forms.Label();
            this.labelLangTo = new System.Windows.Forms.Label();
            this.buttonNewDict = new System.Windows.Forms.PictureBox();
            this.textBoxLangFrom = new System.Windows.Forms.TextBox();
            this.textBoxLangTo = new System.Windows.Forms.TextBox();
            this.labelNewDict = new System.Windows.Forms.Label();
            this.buttonCreateNewDict = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buttonToHomeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNewDict)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose.Location = new System.Drawing.Point(856, 9);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(23, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonToHomeWindow
            // 
            this.buttonToHomeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonToHomeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToHomeWindow.Image = global::DICTIONARY.Properties.Resources.home_window;
            this.buttonToHomeWindow.Location = new System.Drawing.Point(812, 512);
            this.buttonToHomeWindow.Name = "buttonToHomeWindow";
            this.buttonToHomeWindow.Size = new System.Drawing.Size(55, 55);
            this.buttonToHomeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonToHomeWindow.TabIndex = 8;
            this.buttonToHomeWindow.TabStop = false;
            this.buttonToHomeWindow.Click += new System.EventHandler(this.buttonToHomeWindow_Click);
            // 
            // labelLangFrom
            // 
            this.labelLangFrom.AutoSize = true;
            this.labelLangFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelLangFrom.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLangFrom.Location = new System.Drawing.Point(208, 349);
            this.labelLangFrom.Name = "labelLangFrom";
            this.labelLangFrom.Size = new System.Drawing.Size(191, 25);
            this.labelLangFrom.TabIndex = 10;
            this.labelLangFrom.Text = "Language of origin";
            // 
            // labelLangTo
            // 
            this.labelLangTo.AutoSize = true;
            this.labelLangTo.BackColor = System.Drawing.Color.Transparent;
            this.labelLangTo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLangTo.Location = new System.Drawing.Point(483, 349);
            this.labelLangTo.Name = "labelLangTo";
            this.labelLangTo.Size = new System.Drawing.Size(236, 25);
            this.labelLangTo.TabIndex = 11;
            this.labelLangTo.Text = "Language of translation";
            // 
            // buttonNewDict
            // 
            this.buttonNewDict.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewDict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewDict.Image = global::DICTIONARY.Properties.Resources.newDictionary;
            this.buttonNewDict.Location = new System.Drawing.Point(324, 21);
            this.buttonNewDict.Name = "buttonNewDict";
            this.buttonNewDict.Size = new System.Drawing.Size(256, 256);
            this.buttonNewDict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonNewDict.TabIndex = 12;
            this.buttonNewDict.TabStop = false;
            this.buttonNewDict.Click += new System.EventHandler(this.buttonNewDict_Click);
            // 
            // textBoxLangFrom
            // 
            this.textBoxLangFrom.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLangFrom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxLangFrom.Location = new System.Drawing.Point(187, 391);
            this.textBoxLangFrom.Multiline = true;
            this.textBoxLangFrom.Name = "textBoxLangFrom";
            this.textBoxLangFrom.Size = new System.Drawing.Size(231, 41);
            this.textBoxLangFrom.TabIndex = 13;
            this.textBoxLangFrom.Enter += new System.EventHandler(this.textBoxLangFrom_Enter);
            this.textBoxLangFrom.Leave += new System.EventHandler(this.textBoxLangFrom_Leave);
            // 
            // textBoxLangTo
            // 
            this.textBoxLangTo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLangTo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxLangTo.Location = new System.Drawing.Point(469, 391);
            this.textBoxLangTo.Multiline = true;
            this.textBoxLangTo.Name = "textBoxLangTo";
            this.textBoxLangTo.Size = new System.Drawing.Size(250, 41);
            this.textBoxLangTo.TabIndex = 14;
            this.textBoxLangTo.Enter += new System.EventHandler(this.textBoxLangTo_Enter);
            this.textBoxLangTo.Leave += new System.EventHandler(this.textBoxLangTo_Leave);
            // 
            // labelNewDict
            // 
            this.labelNewDict.AutoSize = true;
            this.labelNewDict.BackColor = System.Drawing.Color.Transparent;
            this.labelNewDict.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewDict.Location = new System.Drawing.Point(259, 291);
            this.labelNewDict.Name = "labelNewDict";
            this.labelNewDict.Size = new System.Drawing.Size(373, 56);
            this.labelNewDict.TabIndex = 15;
            this.labelNewDict.Text = "New Dictionary";
            // 
            // buttonCreateNewDict
            // 
            this.buttonCreateNewDict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateNewDict.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNewDict.Location = new System.Drawing.Point(401, 474);
            this.buttonCreateNewDict.Name = "buttonCreateNewDict";
            this.buttonCreateNewDict.Size = new System.Drawing.Size(87, 38);
            this.buttonCreateNewDict.TabIndex = 16;
            this.buttonCreateNewDict.Text = "Create ";
            this.buttonCreateNewDict.UseVisualStyleBackColor = true;
            this.buttonCreateNewDict.Click += new System.EventHandler(this.buttonCreateNewDict_Click);
            // 
            // NewDictionaryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::DICTIONARY.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 579);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCreateNewDict);
            this.Controls.Add(this.labelNewDict);
            this.Controls.Add(this.textBoxLangTo);
            this.Controls.Add(this.textBoxLangFrom);
            this.Controls.Add(this.buttonNewDict);
            this.Controls.Add(this.labelLangTo);
            this.Controls.Add(this.labelLangFrom);
            this.Controls.Add(this.buttonToHomeWindow);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewDictionaryWindow";
            this.Text = "DictionaryWindow";
            this.Load += new System.EventHandler(this.NewDictionaryWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DictionaryWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DictionaryWindow_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.buttonToHomeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNewDict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.PictureBox buttonToHomeWindow;
        private System.Windows.Forms.Label labelLangFrom;
        private System.Windows.Forms.Label labelLangTo;
        private System.Windows.Forms.PictureBox buttonNewDict;
        private System.Windows.Forms.TextBox textBoxLangFrom;
        private System.Windows.Forms.TextBox textBoxLangTo;
        private System.Windows.Forms.Label labelNewDict;
        private System.Windows.Forms.Button buttonCreateNewDict;
    }
}