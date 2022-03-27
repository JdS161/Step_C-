using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICTIONARY
{
    public partial class HomeWindow : Form
    {

        DB dataBase = new DB();
         public HomeWindow()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }


        Point lastPoint;

        private void backgroundPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void backgroundPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonOpenDict_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExistingDictionaryWindow existDictWind = new ExistingDictionaryWindow();
            existDictWind.Show();
        }
        private void buttonNewDict_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            NewDictionaryWindow newDictWind = new NewDictionaryWindow();
            newDictWind.Show();
        }





    }
}
