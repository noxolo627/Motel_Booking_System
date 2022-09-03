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
    public partial class UpdateBooking : Form
    {
        private DateTime checkout;
        public UpdateBooking()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void setUpdate(string booking_id, string room, string total, string checkin, string chckout, int days)
        {
            txtID.Text = booking_id;
            txtRoom.Text = room;
            txtTotal.Text = total;
            txtIn.Text = checkin;
            txtOut.Text = chckout;
            txtDays.Text = days.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkout = dateTimePicker1.Value.AddDays(double.Parse(txtDays.Text));
            //check for double booking
            Booking x = new Booking();
            if(x.isDoubleBooked(dateTimePicker1.Value, checkout, int.Parse(txtRoom.Text)))
            {
                MessageBox.Show("Double booking occured, please select a different date range");
                return;
            }
            try
            {
                bookingTableAdapter1.UpdateQuery(dateTimePicker1.Value.ToShortDateString(), checkout.ToShortDateString(), int.Parse(txtID.Text), int.Parse(txtID.Text));
                MessageBox.Show("Booking successfully updated ");
                this.Hide();
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to cancel this booking? This action cannot be undon.", "", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                paymentTableAdapter1.DeleteQuery(int.Parse(txtID.Text));
                bookingTableAdapter1.DeleteQuery(int.Parse(txtID.Text));
                MessageBox.Show("This booking has been canceled successfuly");
                this.Hide();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
