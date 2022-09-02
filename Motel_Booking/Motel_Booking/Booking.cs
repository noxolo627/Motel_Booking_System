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
    public partial class Booking : Form
    {
        List<Object[]> roomDetails = new List<Object[]>();
        public Booking()
        {
            InitializeComponent();

            groupDataset.RoomDataTable x = new groupDataset.RoomDataTable();
            roomTableAdapter1.Fill(x);
            List<String> rooms = new List<string>();
            foreach(DataRow row in x.Rows)
            {
                bool val = row.Field<bool>("room_status");
                int roomnumber = row.Field<int>("room_num");
                string room_type = row.Field<string>("room_type");
                string price = row.Field<decimal>("room_price").ToString();
                Object[] room = { roomnumber, room_type, price, val };
                if (val)
                {
                    comRoomNo.Items.Add(roomnumber.ToString());
                    roomDetails.Add(room);
                }
            }
            monthCalendar1.MinDate = DateTime.Now;
            try
            {
                monthCalendar2.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
                monthCalendar2.SelectionStart = monthCalendar2.MinDate;
            }
            catch
            {
                try
                {
                    monthCalendar2.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1);
                    monthCalendar2.SelectionStart = monthCalendar2.MinDate;
                }
                catch
                {
                    monthCalendar2.MinDate = new DateTime(DateTime.Now.Year + 1, 1, 1);
                    monthCalendar2.SelectionStart = monthCalendar2.MinDate;
                }
            }
            txtDays.Text = "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home x = new Home();
            x.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            View_Rooms x = new View_Rooms();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Bookings x = new View_Bookings();
            x.Show();
            this.Hide();
        }

        private void bookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Room' table. You can move, or remove it, as needed.
            //this.roomTableAdapter.Fill(this.groupDataset.Room);
            // TODO: This line of code loads data into the 'groupDataset.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.groupDataset.Booking);

        }

        private void comRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = int.Parse(comRoomNo.Text);
            foreach(Object[] room in roomDetails)
            {
                int rnum = int.Parse(room[0].ToString());
                if(rnum == num)
                {
                    txtRoomType.Text = room[1].ToString();
                    txtPrice.Text = room[2].ToString();
                    txtTotal.Text = room[2].ToString();
                    txtStatus.Text = room[3].ToString();
                    clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search for customer details
            string email = txtCEmail.Text;
            int c = int.Parse(customerTableAdapter1.checkEmail(email).ToString());
            if(c < 1)
            {
                DialogResult res = MessageBox.Show("This customer does not exist, would you like to register this customer ? ", "", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    Customer x = new Customer();
                    x.Show();
                    this.Hide();
                }
            }
            groupDataset.CustomerDataTable y = new groupDataset.CustomerDataTable();
            customerTableAdapter1.Fill(y);
            foreach(DataRow row in y.Rows)
            {
                string email2 = row.Field<string>("email");
                if(email.Equals(email2))
                {
                    txtCID.Text = row.Field<int>("cust_id").ToString();
                    txtFName.Text = row.Field<string>("first_name");
                    txtLName.Text = row.Field<string>("last_name");
                    txtPhone.Text = row.Field<string>("phone");
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (txtPrice.Text.Equals(""))
            {
                MessageBox.Show("Select a room to continue");
                monthCalendar1.MinDate = DateTime.Now;
                monthCalendar1.SelectionStart = monthCalendar1.MinDate;
                monthCalendar1.SelectionEnd = monthCalendar1.MinDate;
                try
                {
                    monthCalendar2.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
                    monthCalendar2.SelectionStart = monthCalendar2.MinDate;
                    monthCalendar2.SelectionEnd = monthCalendar2.MinDate;
                }
                catch
                {
                    try
                    {
                        monthCalendar2.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1);
                        monthCalendar2.SelectionStart = monthCalendar2.MinDate;
                        monthCalendar2.SelectionEnd = monthCalendar2.MinDate;
                    }
                    catch
                    {
                        monthCalendar2.MinDate = new DateTime(DateTime.Now.Year + 1, 1, 1);
                        monthCalendar2.SelectionStart = monthCalendar2.MinDate;
                        monthCalendar2.SelectionEnd = monthCalendar2.MinDate;
                    }
                }
                txtDays.Text = "1";
                return;
            }
            DateTime selectedDate = monthCalendar1.SelectionStart;
            try
            {
                monthCalendar2.MinDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day + 1);
            }
            catch
            {
                try
                {
                    monthCalendar2.MinDate = new DateTime(selectedDate.Year, selectedDate.Month + 1, 1);
                }
                catch
                {
                    monthCalendar2.MinDate = new DateTime(selectedDate.Year + 1, 1, 1);
                }
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            if(txtPrice.Text.Equals(""))
            {
                monthCalendar1_DateChanged(sender, e);
                return;
            }
            DateTime selectedDate = monthCalendar2.SelectionStart;
            int days = getDays();
            txtDays.Text = days.ToString();
            decimal total = decimal.Parse(txtPrice.Text);
            txtTotal.Text = (total * days).ToString();
        }

        private int getDays()
        {
            try
            {
                DateTime start = Convert.ToDateTime(monthCalendar1.SelectionStart.ToShortDateString());
                DateTime end = Convert.ToDateTime(monthCalendar2.SelectionStart.ToShortDateString());
                int days = int.Parse((end - start).TotalDays.ToString());
                return days;
            }catch
            {
                return 0;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clear()
        {
            monthCalendar1.MinDate = DateTime.Now;
            monthCalendar1.SelectionStart = DateTime.Now;
            monthCalendar1.SelectionEnd = DateTime.Now;
            try
            {
                monthCalendar2.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
                monthCalendar2.SelectionStart = monthCalendar2.MinDate;
                monthCalendar2.SelectionEnd = monthCalendar2.MinDate;
            }
            catch
            {
                try
                {
                    monthCalendar2.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1);
                    monthCalendar2.SelectionStart = monthCalendar2.MinDate;
                    monthCalendar2.SelectionEnd = monthCalendar2.MinDate;
                }
                catch
                {
                    monthCalendar2.MinDate = new DateTime(DateTime.Now.Year + 1, 1, 1);
                    monthCalendar2.SelectionStart = monthCalendar2.MinDate;
                    monthCalendar2.SelectionEnd = monthCalendar2.MinDate;
                }
            }
            txtDays.Text = "1";
            comboBox1.Text = "";
            txtTotal.Text = txtPrice.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtCID.Text.Equals(""))
            {
                MessageBox.Show("Select a Customer to continue");
                return;
            }
            if(txtStatus.Text.Equals(""))
            {
                MessageBox.Show("Select a room to continue");
                return;
            }
            if(txtStatus.Text.Equals("False"))
            {
                MessageBox.Show("This room is unavailable");
                return;
            }
            if(comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Select a booking type to continue");
                return;
            }
            if(!comboBox1.Items.Contains(comboBox1.Text))
            {
                MessageBox.Show("This booking type does not exist");
                return;
            }

            try
            {
                int days = int.Parse(txtDays.Text);
                if(days <= 0)
                {
                    MessageBox.Show("Change the check-in and check-out days to continue");
                    return;
                }
            }catch
            {
                MessageBox.Show("Select a check-in and check-out date to continue");
                return;
            }

            try
            {
                decimal total = decimal.Parse(txtTotal.Text);
                if(total <= 0)
                {
                    MessageBox.Show("Select a room and select a check-in and check-out date to continue");
                    return;
                }
            }catch
            {
                MessageBox.Show("Select a room and select a check-in and check-out date to continue");
                return;
            }

            //check for double bookings
            int room = int.Parse(comRoomNo.Text);
            if(isDoubleBooked(monthCalendar1.SelectionStart, monthCalendar2.SelectionStart, room))
            {
                return;
            }

            //Book the room;
            try
            {
                int cust = int.Parse(txtCID.Text);
                decimal total = decimal.Parse(txtTotal.Text);
                bookingTableAdapter.Insert(cust, Program.emp_ID, room, comboBox1.Text, total, new DateTime(DateTime.Now.Ticks), monthCalendar1.SelectionStart, monthCalendar2.SelectionStart);
                MessageBox.Show("Booking Successful");
                View_Bookings x = new View_Bookings();
                x.Show();
                this.Hide();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool isDoubleBooked(DateTime checkIn, DateTime checkOut, int room_num)
        {
            groupDataset.BookingDataTable table = new groupDataset.BookingDataTable();
            bookingTableAdapter.Fill(table);
            if (table.Rows.Count <= 0)
                return false;
            foreach(DataRow row in table.Rows)
            {
                DateTime bookedCheckIn = row.Field<DateTime>("check_in");
                DateTime bookedCheckOut = row.Field<DateTime>("check_out");
                if(isInbetween(checkIn, checkOut, bookedCheckIn, bookedCheckOut))
                {
                    int num = row.Field<int>("room_num");
                    if(room_num == num)
                    {
                        MessageBox.Show("Double Booked, plese select a different date");
                        return true;
                    }
                }
            }
            return false;
        }

        public bool isInbetween(DateTime checkIn, DateTime checkout, DateTime bookedCheckIn, DateTime bookedCheckOut)
        {
            if (checkIn.Ticks >= bookedCheckIn.Ticks && checkIn.Ticks < bookedCheckOut.Ticks)
                return true;
            if (checkout.Ticks <= bookedCheckOut.Ticks && checkout.Ticks > bookedCheckIn.Ticks)
                return true;
            if (bookedCheckIn.Ticks < checkout.Ticks && bookedCheckIn.Ticks >= checkIn.Ticks)
                return true;
            if (bookedCheckOut.Ticks > checkIn.Ticks && bookedCheckOut.Ticks <= checkout.Ticks)
                return true;
            return false;
        }
    }
}
