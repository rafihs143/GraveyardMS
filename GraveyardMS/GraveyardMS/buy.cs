using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        private void buyenter_button_Click(object sender, EventArgs e)
        {
            if (buydivison_textBox1.Text== "")
            {
                MessageBox.Show("Enter your Divison!");
            }
            else if (buyplace_comboBox1.Text == "")
            {
                MessageBox.Show("Enter a place");
            }
            else if (buypayment_comboBox.Text == "")
            {
                MessageBox.Show("Enter a payment method");
            }
            else if (buydistrict_comboBox.Text == "")
            {
                MessageBox.Show("Enter your District");
            }
            else
            {
                Visitor visitor = new Visitor();
                visitor.Divison = buydivison_textBox1.Text;
                visitor.Place = buyplace_comboBox1.Text;
                visitor.Payment = buypayment_comboBox.Text;
                visitor.District = buydistrict_comboBox.Text;


                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2[A]"].ConnectionString);
                connection.Open();
                string sql = "INSERT INTO Visitors(Divison,Place,Payment,District) VALUES('" + visitor.Divison + "','" + visitor.Place + "','" + visitor.Payment + "','" + visitor.District + "')";
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
        
    }
}
