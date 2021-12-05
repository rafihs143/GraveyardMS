using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

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

            if (regname_textBox.Text == "")
            {
                MessageBox.Show("Name Can't be empty");
            }
            else if (regusername_textBox.Text == "")
            {
                MessageBox.Show("Username can't be empty");
            }
            else if (regpass_textBox.Text == "")
            {
                MessageBox.Show("Password can't be empty");
            }
            else if (regconfpass_textBox.Text == "")
            {
                MessageBox.Show("Confirm Password can't be empty");
            }


           
            else if (regemail_textBox.Text == "")
            {
                MessageBox.Show("Email can't be empty");
            }
            else if (regcontnumb_textBox.Text == "")
            {
                MessageBox.Show("Contact Number can't be empty");
            }
            else
            {
                 if (regpass_textBox.Text != regconfpass_textBox.Text)
                    {
                        MessageBox.Show("Password Not Matched");
                    }
                else
                {
                    User user = new User();
                    user.Name = regname_textBox.Text;
                    user.Username = regusername_textBox.Text;
                    user.Password = regpass_textBox.Text;
                    user.Email = regemail_textBox.Text;
                    user.ContactNo = regcontnumb_textBox.Text;

                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2[A]"].ConnectionString);
                    connection.Open();
                    string sql = "INSERT INTO VisitorsInfo(Name,UserName,Password,Email,ContactNo) VALUES('" +user.Name + "','" + user.Username + "','" + user.Password + "','" + user.Email + "'," + user.ContactNo + ")";
                    SqlCommand command = new SqlCommand(sql, connection);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("User Added");
                        Form1 output = new Form1();
                        //output.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error in Adding");
                    }

                }
            }
            //else
            //{
            //    Form1 output = new Form1();
            //    output.Show();
            //}
            //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2[A]"].ConnectionString);
           // connection.Open();

            

        }
    }
}
