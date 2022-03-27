using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICTIONARY
{
    public partial class NewDictionaryWindow : Form
    {
        public NewDictionaryWindow()
        {
            InitializeComponent();

            textBoxLangFrom.Text = "Language of origin";
            textBoxLangFrom.ForeColor = Color.Gray;
            textBoxLangTo.Text = "Language of translation";
            textBoxLangTo.ForeColor = Color.Gray;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void DictionaryWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void DictionaryWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonToHomeWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeWindow homeWind = new HomeWindow();
            homeWind.Show();
        }

        private void textBoxLangFrom_Enter(object sender, EventArgs e)
        {
            if (textBoxLangFrom.Text == "Language of origin")
            {
                textBoxLangFrom.Text = "";
                textBoxLangFrom.ForeColor = Color.Black;
            }
        }

        private void textBoxLangFrom_Leave(object sender, EventArgs e)
        {
            if (textBoxLangFrom.Text == "")
            {
                textBoxLangFrom.Text = "Language of origin";
                textBoxLangFrom.ForeColor = Color.Gray;
            }
        }

        private void textBoxLangTo_Enter(object sender, EventArgs e)
        {
            if (textBoxLangTo.Text == "Language of translation")
            {
                textBoxLangTo.Text = "";
                textBoxLangTo.ForeColor = Color.Black;
            }
        }

        private void textBoxLangTo_Leave(object sender, EventArgs e)
        {
            if (textBoxLangTo.Text == "")
            {
                textBoxLangTo.Text = "Language of translation";
                textBoxLangTo.ForeColor = Color.Gray;
            }
        }

        private void buttonCreateNewDict_Click(object sender, EventArgs e)
        {
            if (textBoxLangFrom.Text == "Language of origin")
            {
                MessageBox.Show("Write an origin language");
                return;
            }
            if (textBoxLangTo.Text == "Language of translation")
            {
                MessageBox.Show("Write a languale of translation");
                return;
            }

            DB db = new DB();

            string tableName = textBoxLangFrom.Text + '_' + textBoxLangTo.Text;

            string createTableQuery =  "CREATE TABLE [dbo].[" + tableName + "]" +
                                        " (dictId           INT             IDENTITY(1,1)   NOT NULL PRIMARY KEY ," +
                                        "word               NVARCHAR(50)                    NOT NULL," +
                                        "translation_1      NVARCHAR(50)                    NOT NULL," +
                                        "translation_2      NVARCHAR(50)," +
                                        "translation_3      NVARCHAR(50)," +
                                        "translation_4      NVARCHAR(50)," +
                                        "translation_5      NVARCHAR(50)," +
                                        "translation_6      NVARCHAR(50)," +
                                        "translation_7      NVARCHAR(50)," +
                                        "translation_8      NVARCHAR(50)," +
                                        "translation_9      NVARCHAR(50)," +
                                        "translation_10     NVARCHAR(50))";


            SqlCommand command = new SqlCommand(createTableQuery, db.GetConnection());

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Dictionary created successfully!");
            else
                MessageBox.Show("Dictionary was NOT created!");

            db.CloseConnection();


        }

        private void NewDictionaryWindow_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewDict_Click(object sender, EventArgs e)
        {

        }
    }
}
