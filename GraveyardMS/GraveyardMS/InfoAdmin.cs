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
    public partial class InfoAdmin : Form
    {
        public InfoAdmin()
        {
            InitializeComponent();
        }

        private void InfoAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void infoadmin_logout_Click(object sender, EventArgs e)
        {
            Form1 output = new Form1();
            output.Show();
        }

        private void admminperson_enter_Click(object sender, EventArgs e)
        {
            Person output = new Person();
            output.Show();
        }

        private void adminbuyer_enter_Click(object sender, EventArgs e)
        {
            VisitorsInfo output = new VisitorsInfo();
            output.Show();

        }
    }
}
