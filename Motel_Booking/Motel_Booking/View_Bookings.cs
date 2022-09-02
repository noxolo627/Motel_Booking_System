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
    public partial class View_Bookings : Form
    {
        public View_Bookings()
        {
            InitializeComponent();
        }

        private void bookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void View_Bookings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.groupDataset.Customer);
            // TODO: This line of code loads data into the 'groupDataset.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.groupDataset.Booking);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBID.Text.Equals(""))
            {
                MessageBox.Show("Select a booking to continue");
                return;
            }
            else
            {
                UpdateBooking x = new UpdateBooking();
                x.setUpdate(txtBID.Text, txtRoomNum.Text, txtTotalCost.Text, txtCheckIn.Text, txtCheckOut.Text);
                x.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBID.Text.Equals(""))
            {
                MessageBox.Show("Select a booking to continue");
                return;
            }
            try
            {
                int cid = int.Parse(txtCID.Text);
                int eid = int.Parse(txtSID.Text);
                txtCEmail.Text = customerTableAdapter1.getEmail(cid).ToString();
                txtCName.Text = customerTableAdapter1.getFullName(cid).ToString();
                txtEName.Text = staffTableAdapter1.getFullName(eid).ToString();
                txtEEmail.Text = staffTableAdapter1.getEmail(eid).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Booking x = new Booking();
            x.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime start = startDate.Value;
            DateTime end = endDate.Value;
            if(end.Ticks < start.Ticks)
            {
                MessageBox.Show("The end date cannot be before the start date");
                return;
            }
            else
            {
                try
                {
                    bookingTableAdapter.FillByBooking(groupDataset.Booking, start.ToShortDateString(), end.ToShortDateString());
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bookingTableAdapter.Fill(groupDataset.Booking);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtBID.Text.Equals(""))
            {
                MessageBox.Show("Select a booking to continue");
                return;
            }
            try
            {
                bookingTableAdapter.DeleteQuery(int.Parse(txtBID.Text));
                paymentTableAdapter1.DeleteQuery(int.Parse(txtBID.Text));
                MessageBox.Show("Booking Successfully Canceled");
                button2_Click(sender, e);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
