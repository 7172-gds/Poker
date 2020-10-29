using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.Prav;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var formMain = new Form2();
            formMain.Closed += (s, args) => Close();
            formMain.Show();
            Dispose(true);
        }
    }
}
