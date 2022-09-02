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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Rooms x = new View_Rooms();
            x.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer x = new Customer();
            x.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Staff x = new Staff();
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking x = new Booking();
            x.Show();
            this.Hide();
        }
    }
}
