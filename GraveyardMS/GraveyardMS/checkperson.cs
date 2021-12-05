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
    public partial class checkperson : Form
    {
        public checkperson()
        {
            InitializeComponent();
        }

        private void checkperson_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clback_button_Click(object sender, EventArgs e)
        {
            Info output = new Info();
            output.Show();
        }

        private void cp_button_Click(object sender, EventArgs e)
        {
            if (cpname_textBox.Text == "")
            {
                MessageBox.Show("Please Enter a Name");
            }
            else if (cpplace_comboBox.Text == "")
            {
                MessageBox.Show("Place Can't be empty");
            }
        }
    }
}
