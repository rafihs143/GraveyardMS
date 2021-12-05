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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Info output = new Info();
            output.Show();
        }

        private void login_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
