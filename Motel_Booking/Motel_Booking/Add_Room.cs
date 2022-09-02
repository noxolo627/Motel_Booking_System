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
    public partial class Add_Room : Form
    {
        int room_id = 0;
        string imageFileLocation;
        public Add_Room()
        {
            InitializeComponent();
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Add_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Room_Image' table. You can move, or remove it, as needed.
            this.room_ImageTableAdapter.Fill(this.groupDataset.Room_Image);
            // TODO: This line of code loads data into the 'groupDataset.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.groupDataset.Room);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int room_num;
                try
                {
                    room_num = int.Parse(txtRoomNumber.Text);
                }
                catch { MessageBox.Show("A room number should only be integer values"); return; }
                 

                //validate the room number
                int count = int.Parse(roomTableAdapter.validateRoomNumber(room_num).ToString());
                if(count > 0)
                {
                    MessageBox.Show("This room already exists");
                    return;
                }

                if(!txtRoomType.Items.Contains(txtRoomType.Text))
                {
                    MessageBox.Show("These selected room type does not exist");
                    return;
                }

                room_id = room_num;
                int beds;

                try
                {
                    beds = int.Parse(txtNumberOfBeds.Text);
                }
                catch { MessageBox.Show("Number of beds should be an integer value"); return; }

                decimal price;

                try
                {
                    price = decimal.Parse(txtPrice.Text);
                }
                catch { MessageBox.Show("The price should be a decimal value"); return; }

                if (roomTableAdapter.Insert(room_num, txtRoomType.Text, beds, txtDescription.Text, price, true) > 0)
                {
                    MessageBox.Show("Room successfully added");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(room_id == 0)
            {
                MessageBox.Show("Register a room first before you register the room images");
                return;
            }
            Add_Room_Image x = new Add_Room_Image();
            x.setRoomID(room_id);
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
