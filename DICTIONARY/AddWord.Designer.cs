namespace DICTIONARY
{
    partial class AddWord
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.buttonAddWordCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "WORD";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(56, 93);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(200, 20);
            this.textBoxWord.TabIndex = 1;
            // 
            // textBoxTranslation
            // 
            this.textBoxTranslation.Location = new System.Drawing.Point(309, 93);
            this.textBoxTranslation.Name = "textBoxTranslation";
            this.textBoxTranslation.Size = new System.Drawing.Size(200, 20);
            this.textBoxTranslation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "TRANSLATION";
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.Location = new System.Drawing.Point(373, 159);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWord.TabIndex = 4;
            this.buttonAddWord.Text = "Add Word";
            this.buttonAddWord.UseVisualStyleBackColor = true;
            // 
            // buttonAddWordCancel
            // 
            this.buttonAddWordCancel.Location = new System.Drawing.Point(463, 159);
            this.buttonAddWordCancel.Name = "buttonAddWordCancel";
            this.buttonAddWordCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWordCancel.TabIndex = 5;
            this.buttonAddWordCancel.Text = "Cancel";
            this.buttonAddWordCancel.UseVisualStyleBackColor = true;
            this.buttonAddWordCancel.Click += new System.EventHandler(this.buttonAddWordCancel_Click);
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(550, 194);
            this.Controls.Add(this.buttonAddWordCancel);
            this.Controls.Add(this.buttonAddWord);
            this.Controls.Add(this.textBoxTranslation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWord";
            this.Text = "AddWord";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddWord_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddWord_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWord;
        protected System.Windows.Forms.TextBox textBoxTranslation;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.Button buttonAddWordCancel;
    }
}