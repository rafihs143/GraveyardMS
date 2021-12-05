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
    public partial class buy : Form
    {
        public buy()
        {
            InitializeComponent();
        }

        private void buy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buyback_button_Click(object sender, EventArgs e)
        {
            Info output = new Info();
            output.Show();
        }
    }
}
