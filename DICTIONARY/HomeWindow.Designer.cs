namespace DICTIONARY
{
    partial class HomeWindow
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
            this.createNewDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.createNewDictionaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDictionaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.buttonToHomeWindow = new System.Windows.Forms.PictureBox();
            this.labelOpenDict = new System.Windows.Forms.Label();
            this.buttonOpenDict = new System.Windows.Forms.PictureBox();
            this.labelNewDict = new System.Windows.Forms.Label();
            this.buttonNewDict = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonToHomeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOpenDict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNewDict)).BeginInit();
            this.SuspendLayout();
            // 
            // createNewDictionaryToolStripMenuItem
            // 
            this.createNewDictionaryToolStripMenuItem.Name = "createNewDictionaryToolStripMenuItem";
            this.createNewDictionaryToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // createNewDictionaryToolStripMenuItem1
            // 
            this.createNewDictionaryToolStripMenuItem1.Name = "createNewDictionaryToolStripMenuItem1";
            this.createNewDictionaryToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // exportDictionaryToolStripMenuItem1
            // 
            this.exportDictionaryToolStripMenuItem1.Name = "exportDictionaryToolStripMenuItem1";
            this.exportDictionaryToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // deleteDictionaryToolStripMenuItem
            // 
            this.deleteDictionaryToolStripMenuItem.Name = "deleteDictionaryToolStripMenuItem";
            this.deleteDictionaryToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.AutoScroll = true;
            this.backgroundPanel.AutoSize = true;
            this.backgroundPanel.BackColor = System.Drawing.Color.Transparent;
            this.backgroundPanel.BackgroundImage = global::DICTIONARY.Properties.Resources.background2;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.buttonToHomeWindow);
            this.backgroundPanel.Controls.Add(this.labelOpenDict);
            this.backgroundPanel.Controls.Add(this.buttonOpenDict);
            this.backgroundPanel.Controls.Add(this.labelNewDict);
            this.backgroundPanel.Controls.Add(this.buttonNewDict);
            this.backgroundPanel.Controls.Add(this.buttonClose);
            this.backgroundPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1197, 761);
            this.backgroundPanel.TabIndex = 0;
            this.backgroundPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseDown);
            this.backgroundPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseMove);
            // 
            // buttonToHomeWindow
            // 
            this.buttonToHomeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonToHomeWindow.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonToHomeWindow.Image = global::DICTIONARY.Properties.Resources.home_window;
            this.buttonToHomeWindow.Location = new System.Drawing.Point(1111, 678);
            this.buttonToHomeWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToHomeWindow.Name = "buttonToHomeWindow";
            this.buttonToHomeWindow.Size = new System.Drawing.Size(73, 68);
            this.buttonToHomeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonToHomeWindow.TabIndex = 6;
            this.buttonToHomeWindow.TabStop = false;
            // 
            // labelOpenDict
            // 
            this.labelOpenDict.AutoSize = true;
            this.labelOpenDict.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenDict.Location = new System.Drawing.Point(715, 523);
            this.labelOpenDict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpenDict.Name = "labelOpenDict";
            this.labelOpenDict.Size = new System.Drawing.Size(229, 35);
            this.labelOpenDict.TabIndex = 4;
            this.labelOpenDict.Text = "Open Dictionary";
            // 
            // buttonOpenDict
            // 
            this.buttonOpenDict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenDict.Image = global::DICTIONARY.Properties.Resources.openDictionary1;
            this.buttonOpenDict.Location = new System.Drawing.Point(624, 144);
            this.buttonOpenDict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenDict.Name = "buttonOpenDict";
            this.buttonOpenDict.Size = new System.Drawing.Size(431, 412);
            this.buttonOpenDict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonOpenDict.TabIndex = 3;
            this.buttonOpenDict.TabStop = false;
            this.buttonOpenDict.Click += new System.EventHandler(this.buttonOpenDict_Click);
            // 
            // labelNewDict
            // 
            this.labelNewDict.AutoSize = true;
            this.labelNewDict.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewDict.Location = new System.Drawing.Point(168, 523);
            this.labelNewDict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewDict.Name = "labelNewDict";
            this.labelNewDict.Size = new System.Drawing.Size(306, 35);
            this.labelNewDict.TabIndex = 2;
            this.labelNewDict.Text = "Create new Dictionary";
            // 
            // buttonNewDict
            // 
            this.buttonNewDict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewDict.Image = global::DICTIONARY.Properties.Resources.newDictionary;
            this.buttonNewDict.Location = new System.Drawing.Point(156, 178);
            this.buttonNewDict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewDict.Name = "buttonNewDict";
            this.buttonNewDict.Size = new System.Drawing.Size(341, 315);
            this.buttonNewDict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonNewDict.TabIndex = 1;
            this.buttonNewDict.TabStop = false;
            this.buttonNewDict.Click += new System.EventHandler(this.buttonNewDict_Click_1);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose.Location = new System.Drawing.Point(1163, 11);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(29, 29);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1197, 761);
            this.Controls.Add(this.backgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeWindow";
            this.Text = "Dictionary";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonToHomeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOpenDict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNewDict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.ToolStripMenuItem createNewDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDictionaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportDictionaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.PictureBox buttonNewDict;
        private System.Windows.Forms.Label labelNewDict;
        private System.Windows.Forms.Label labelOpenDict;
        private System.Windows.Forms.PictureBox buttonOpenDict;
        private System.Windows.Forms.PictureBox buttonToHomeWindow;
    }
}

