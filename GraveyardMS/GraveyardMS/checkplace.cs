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
    public partial class checkplace : Form
    {
        public checkplace()
        {
            InitializeComponent();
        }

        private void checkplace_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkplace_Load(object sender, EventArgs e)
        {

        }

        private void cplback_button_Click(object sender, EventArgs e)
        {
            Info output = new Info();
            output.Show();
        }

        private void cpl_button_Click(object sender, EventArgs e)
        {
            if (cpldistrict_comboBox.Text == "")
            {
                MessageBox.Show("District Can't be empty");
            }
            else if (cpldivision_comboBox.Text == "")
            {
                MessageBox.Show("Division Can't be empty");
            }
        }
    }
}
