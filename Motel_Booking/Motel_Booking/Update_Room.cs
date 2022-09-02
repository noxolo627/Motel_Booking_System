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
    public partial class Update_Room : Form
    {
        int room_num;
        public Update_Room()
        {
            InitializeComponent();
        }
        
        public void setUpdate(int room_num, string type, string beds, string price, string description)
        {
            this.room_num = room_num;
            txtRoomNumber.Text = room_num.ToString();
            txtRoomType.Text = type;
            txtNumberOfBeds.Text = beds;
            txtPrice.Text = price.Substring(1, price.Length-1);
            txtDescription.Text = description;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        { 
            string type = txtRoomType.Text;
            if(!txtRoomType.Items.Contains(type))
            {
                MessageBox.Show("The selected room type does not exist");
                return;
            }
            int beds;
            try
            {
                beds = int.Parse(txtNumberOfBeds.Text);
            }
            catch
            {
                MessageBox.Show("Number of beds has to be an integer value");
                return;
            }
            decimal price;
            try
            {
                price = decimal.Parse(txtPrice.Text);
            }
            catch
            {
                MessageBox.Show("Price has to be a money value");
                return;
            }
            string description = txtDescription.Text;
            try
            {
                roomTableAdapter.updateRoom(type, beds, description, price, room_num, room_num);
                MessageBox.Show("Update completed successfully");
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Update_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.groupDataset.Room);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
