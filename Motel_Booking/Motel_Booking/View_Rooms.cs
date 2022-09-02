using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motel_Booking
{
    public partial class View_Rooms : Form
    {
        public View_Rooms()
        {
            InitializeComponent();
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void View_Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Room_Image' table. You can move, or remove it, as needed.
            this.room_ImageTableAdapter.Fill(this.groupDataset.Room_Image);
            // TODO: This line of code loads data into the 'groupDataset.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.groupDataset.Room);

        }

        public List<Image> getImages(int room_num)
        {
            try
            {
                groupDataset.Room_ImageDataTable dt = new groupDataset.Room_ImageDataTable();
                room_ImageTableAdapter.selectByRoomNum(dt, room_num);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("This room does not have any images");
                    return null;
                }
                List<Image> list = new List<Image>();
                foreach (DataRow row in dt.Rows)
                {
                    byte[] image = (byte[])row["room_img"];
                    Image img;
                    using (var ms = new MemoryStream(image))
                    {
                        img = Image.FromStream(ms);
                    }
                    list.Add(img);
                }
                return list;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtRoomNumber.Text.Equals(""))
            {
                MessageBox.Show("There are currently no rooms selected");
                return;
            }
            List<Image> images = getImages(int.Parse(txtRoomNumber.Text));
            if (images == null)
            {
                MessageBox.Show("There are no images registered for this room");
                return;
            }
            View_Room_Images x = new View_Room_Images();
            x.setImageList(images, int.Parse(txtRoomNumber.Text));
            x.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Room x = new Add_Room();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                roomTableAdapter.Fill(groupDataset.Room);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomNumber.Text.Equals(""))
                {
                    MessageBox.Show("Select a room to continue");
                    return;
                }
                int room_num = int.Parse(txtRoomNumber.Text);
                bool value = bool.Parse(txtStatus.Text);
                roomTableAdapter.activation(!value, room_num, room_num);
                button4_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home x = new Home();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update_Room x = new Update_Room();
            x.setUpdate(int.Parse(txtRoomNumber.Text), txtRoomType.Text, txtBeds.Text, txtPrice.Text, txtDescription.Text);
            x.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(txtRoomNumber.Text.Length == 0)
            {
                MessageBox.Show("Select a room i order to continue");
                return;
            }
            Add_Room_Image x = new Add_Room_Image();
            x.setRoomID(int.Parse(txtRoomNumber.Text));
            x.Show();
        }
    }
}
