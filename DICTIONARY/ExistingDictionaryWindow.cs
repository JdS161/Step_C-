using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DICTIONARY
{
    public partial class ExistingDictionaryWindow : Form
    {
        public ExistingDictionaryWindow()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void ExistingDictionaryWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ExistingDictionaryWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonToHomeWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeWindow homeWind = new HomeWindow();
            homeWind.Show();
        }

        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            AddWord addWord = new AddWord();
            addWord.Show(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExistingDictionaryWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dictionaryDataSet.RUS_DEU' table. You can move, or remove it, as needed.
            this.rUS_DEUTableAdapter.Fill(this.dictionaryDataSet.RUS_DEU);

        }
    }
}
