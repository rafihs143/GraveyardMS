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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void Feedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void feddback_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank your for your feedback");
            
            
            Info output = new Info();
            output.Show();
        }
    }
}
