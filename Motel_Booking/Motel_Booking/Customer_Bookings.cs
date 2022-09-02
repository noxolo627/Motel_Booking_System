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
    public partial class Customer_Bookings : Form
    {
        public Customer_Bookings()
        {
            InitializeComponent();
        }

        public void setUpdate(int customer_id)
        {
            try
            {
                bookingTableAdapter.FillByCustomer(groupDataset.Booking, customer_id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Customer_Bookings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.groupDataset.Booking);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer x = new Customer();
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not yet been implemented");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not yet been implemented");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not yet been implemented");
        }
    }
}
