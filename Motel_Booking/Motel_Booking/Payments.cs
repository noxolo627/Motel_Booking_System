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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.groupDataset.Payment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home x = new Home();
            x.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime start = startDate.Value;
            DateTime end = endDate.Value;
            if(end.Ticks < start.Ticks)
            {
                MessageBox.Show("Start date cannot be before end date");
                return;
            }
            try
            {
                groupDataset.BookingDataTable x = new groupDataset.BookingDataTable();
                bookingTableAdapter1.FillByPayment(x, start, end);
                if(x.Rows.Count <= 0)
                {
                    txtSubtotal.Text = "R0";
                    txtVat.Text = "R0";
                    txtTotal.Text = "R0";
                }
                else
                {
                    decimal total = 0;
                    foreach(DataRow row in x.Rows)
                    {
                        total += row.Field<decimal>("total_cost");
                    }
                    txtTotal.Text = total.ToString();
                    txtVat.Text = (total * (decimal)0.15).ToString();
                    txtSubtotal.Text = (total - (total * (decimal)0.15)).ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
