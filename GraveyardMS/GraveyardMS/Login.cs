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
            


           


            if (loginusername_textBox.Text == "")
            {
                MessageBox.Show("Username can't be empty");
            }
            else if (loginpass_textBox.Text == "")
            {
                MessageBox.Show("Password can't be empty");
            }
           else if (login_comboBox.Text == "1. Admin")
            {

                
                
                if (loginusername_textBox.Text == "admin" && loginpass_textBox.Text=="admin" )
                    {

                    

                    InfoAdmin admin = new InfoAdmin();

                    admin.Show();
                    this.Hide();
                }         

            }
            else
            {
                //MessageBox.Show(" Invalid Id or Password ");
                Info output = new Info();
                output.Show();
                this.Hide();
            }
            

        }

        private void login_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void login_comboBox_Click(object sender, EventArgs e)
        {
            if (loginbutton.Enabled == false)
            {
                loginbutton.Enabled=true;
            }
            else
            {
                loginbutton.Enabled = false;
            }
        }
    }
}
