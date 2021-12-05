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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void feedback_enter_Click(object sender, EventArgs e)
        {
            Feedback output = new Feedback();
            output.Show();
        }

        private void info_logout_Click(object sender, EventArgs e)
        {
            Form1 output = new Form1();
            output.Show();
        }

        private void person_enter_Click(object sender, EventArgs e)
        {
            checkperson output = new checkperson();
            output.Show();
        }

        private void place_enter_Click(object sender, EventArgs e)
        {
            checkplace output = new checkplace();
            output.Show();
        }

        private void buy_enter_Click(object sender, EventArgs e)
        {
            buy output = new buy();
            output.Show();
        }

        private void infoperson_label_Click(object sender, EventArgs e)
        {

        }

        private void contract_enter_Click(object sender, EventArgs e)
        {
            contact output = new contact();
            output.Show();
        }
    }
}
