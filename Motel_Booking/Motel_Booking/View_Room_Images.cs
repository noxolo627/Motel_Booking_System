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
    public partial class View_Room_Images : Form
    {
        private List<Image> list;
        private int index = 0;
        private int room_num = 0;
        public View_Room_Images()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(index == 0)
            {
                index = list.Count - 1;
                pictureBox1.Image = list[index];
                return;
            }
            index--;
            pictureBox1.Image = list[index];
        }

        public void setImageList(List<Image> images, int room)
        {
            this.list = images;
            pictureBox1.Image = list[index];
            this.room_num = room;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index == (list.Count - 1))
            {
                index = 0;
                pictureBox1.Image = list[index];
                return;
            }
            index++;
            pictureBox1.Image = list[index];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Rooms x = new View_Rooms();
            x.Show();
            this.Hide();
        }

        private void room_ImageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.room_ImageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void View_Room_Images_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Room_Image' table. You can move, or remove it, as needed.
            this.room_ImageTableAdapter.Fill(this.groupDataset.Room_Image);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete all the images?", "", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                try
                {
                    room_ImageTableAdapter.deleteAllRooms(room_num);
                    MessageBox.Show("Images deleted successfully");
                    View_Rooms x = new View_Rooms();
                    x.Show();
                    this.Hide();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
