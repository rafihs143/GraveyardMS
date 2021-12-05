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
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }

       
        void UpdateGridView()
        {
            VisitorDataAccess visitorDataAccess = new VisitorDataAccess();
            listOfVisitorsGridView.DataSource = visitorDataAccess.GetVisitors();
        }
        void ClearFields()
        {
            addDivisonTextBox.Text = string.Empty;
            addPlaceTextBox.Text = string.Empty;
            addPaymentTextBox.Text = string.Empty;
            addDistrictTextBox.Text = string.Empty;

            updateVisitorsIdTextBox.Text = string.Empty;
            updateDivisonTextBox.Text = string.Empty;
            updatePlaceTextBox.Text = string.Empty;
            updatePaymentTextBox.Text = string.Empty;
            updateDistrictTextBox.Text = string.Empty;

            deleteVisitorIdTextBox.Text = string.Empty;

        }


        private void addDivisonButton_Click(object sender, EventArgs e)
        {
            VisitorDataAccess visitorDataAccess = new VisitorDataAccess();

            if (visitorDataAccess.CreateVisitor(addDivisonTextBox.Text, addPlaceTextBox.Text, addPaymentTextBox.Text, addDistrictTextBox.Text))
            {
                MessageBox.Show("New Visitor created");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in creating");
                 ClearFields();
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (updateVisitorsIdTextBox.Text == "")
            {
                MessageBox.Show("Please give a Visitor id");
            }
            else
            {
                VisitorDataAccess visitorDataAccess = new VisitorDataAccess();
                Visitor visitor = visitorDataAccess.GetVisitorById(Convert.ToInt32(updateVisitorsIdTextBox.Text));
                if (visitor == null)
                {
                    MessageBox.Show("Visitor is not available");
                     ClearFields();
                }
                else
                {
                    updateDivisonTextBox.Text = visitor.Divison;
                    updatePlaceTextBox.Text = visitor.Place;
                    updatePaymentTextBox.Text = visitor.Payment;
                    updateDistrictTextBox.Text = visitor.District;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            VisitorDataAccess visitorDataAccess = new VisitorDataAccess();
            if (visitorDataAccess.UpdateVisitor(Convert.ToInt32(updateVisitorsIdTextBox.Text), updateDivisonTextBox.Text, updatePlaceTextBox.Text,updatePaymentTextBox.Text,updateDistrictTextBox.Text))
            {
                MessageBox.Show("Visitor updated");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in updating");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteVisitorIdTextBox.Text == "")
            {
                MessageBox.Show("Please give a Visitor id");
            }
            else
            {
                VisitorDataAccess visitorDataAccess = new VisitorDataAccess();
                Visitor visitor = visitorDataAccess.GetVisitorById(Convert.ToInt32(deleteVisitorIdTextBox.Text));
                if (visitor == null)
                {
                    MessageBox.Show("Visitor is not available");
                    ClearFields();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        visitorDataAccess = new VisitorDataAccess();
                        if (visitorDataAccess.DeleteVisitor(Convert.ToInt32(deleteVisitorIdTextBox.Text)))
                        {
                            MessageBox.Show("Visitor deleted");
                            UpdateGridView();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Error in deleting");
                        }
                    }
                }
            }
        }

        private void listOfVisitorsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
