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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            Dispose(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, Гусельников Данил, группа 717-2", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var formMain = new Form3();
            formMain.Closed += (s, args) => Close();
            formMain.Show();
            Dispose(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            var formMain = new Form4();
            formMain.Closed += (s, args) => Close();
            formMain.Show();
            Dispose(true);
        }
    }
}
