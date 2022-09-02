using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motel_Booking
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupDataset.Customer);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Select a customer to continue");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Select a customer to continue");
                return;
            }
            Customer_Bookings x = new Customer_Bookings();
            x.setUpdate(int.Parse(txtCustomerID.Text));
            x.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Select a customer to continue");
                return;
            }
            Update_Customer x = new Update_Customer();
            x.setUpdate(int.Parse(txtCustomerID.Text), txtFName.Text, txtLName.Text, txtGender.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text);
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                customerTableAdapter.Fill(groupDataset.Customer);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Customer x = new Add_Customer();
            x.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(customerDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("There are no customers to search through");
                txtSearch.Clear();
                return;
            }
            try
            {
                customerTableAdapter.FillBySearch(groupDataset.Customer, txtSearch.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtSearch.Clear();
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home x = new Home();
            x.Show();
            this.Hide();
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
