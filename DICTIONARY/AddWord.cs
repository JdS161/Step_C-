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
    public partial class AddWord : Form
    {
        public AddWord()
        {
            InitializeComponent();
        }

        private void buttonAddWordCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void AddWord_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddWord_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
