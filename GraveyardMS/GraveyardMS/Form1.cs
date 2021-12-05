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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NewAcc_Click(object sender, EventArgs e)
        {
            Createacc output = new Createacc();
            output.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login output = new Login();
            output.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
