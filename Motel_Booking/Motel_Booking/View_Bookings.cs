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
    }
}
