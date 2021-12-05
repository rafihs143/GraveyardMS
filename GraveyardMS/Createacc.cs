using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraveyardMS
{
    public partial class Createacc : Form
    {
        public Createacc()
        {
            InitializeComponent();
        }

        private void Createacc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void regsubmit_Click(object sender, EventArgs e)
        {
            Form1 output = new Form1();
            output.Show();
        }
    }
}
