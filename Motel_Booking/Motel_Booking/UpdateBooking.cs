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
        public UpdateBooking()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void setUpdate(string booking_id, string room, string total, string checkin, string chckout)
        {
            txtID.Text = booking_id;
            txtRoom.Text = room;
            txtTotal.Text = total;
            txtIn.Text = checkin;
            txtOut.Text = chckout;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
