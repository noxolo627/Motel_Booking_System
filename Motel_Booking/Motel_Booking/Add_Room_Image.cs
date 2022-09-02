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
    public partial class Add_Room_Image : Form
    {

        private List<Image> images = new List<Image>();
        private Image[] imgs;
        private int count = 0;
        private int index = 0;
        private int room_id = 0;

        public Add_Room_Image()
        {
            InitializeComponent();
            lblRooms.Text = "Number of rooms selected : " + count;
        }

        private void createArray()
        {
            imgs = new Image[images.Count];
            for(int i = 0; i < images.Count; i++)
            {
                imgs[i] = images[i];
            }
        }
        
        public void setRoomID(int id)
        {
            this.room_id = id;
        }

        private void getImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (images.Count == 0)
                {
                    //you're registering your first image for this room
                    OpenFileDialog open = new OpenFileDialog();
                    open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = new Bitmap(open.FileName);
                        images.Add(pictureBox1.Image);
                        count++;
                        lblRooms.Text = "Number of rooms selected : " + count;
                        createArray();
                        index = 0;
                    }
                }
                else
                {
                    DialogResult res = MessageBox.Show("You already have " + count + " images. Do would you like to add another one?", "", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        OpenFileDialog open = new OpenFileDialog();
                        open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                        if (open.ShowDialog() == DialogResult.OK)
                        {
                            pictureBox1.Image = new Bitmap(open.FileName);
                            images.Add(pictureBox1.Image);
                            count++;
                            lblRooms.Text = "Number of rooms selected : " + count;
                            createArray();
                            index = images.Count - 1;
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(imgs == null || pictureBox1.Image == null)
            {
                MessageBox.Show("You have not added any images");
                return;
            }
            if(index == 0)
            {
                index = imgs.Length - 1;
                pictureBox1.Image = imgs[index];
            }
            else
            {
                index = index - 1;
                pictureBox1.Image = imgs[index];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (imgs == null || pictureBox1.Image == null)
            {
                MessageBox.Show("You have not added any images");
                return;
            }
            if (index == (imgs.Length - 1))
            {
                index = 0;
                pictureBox1.Image = imgs[index];
            }
            else
            {
                index = index + 1;
                pictureBox1.Image = imgs[index];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("You have not selected any image");
                return;
            }

            if(images.Contains(pictureBox1.Image))
            {
                images.Remove(pictureBox1.Image);
                createArray();
                if(images.Count == 0)
                {
                    pictureBox1.Image = null;
                    count = 0;
                    index = 0;
                    lblRooms.Text = "Number of rooms selected : " + count;
                    return;
                }
                index = 0;
                count = images.Count;
                pictureBox1.Image = images[index];
                lblRooms.Text = "Number of rooms selected : " + count;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(images.Count == 0)
            {
                MessageBox.Show("Add images first before you upload them");
            }
            try
            {
                foreach (Image img in images)
                {
                    var ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    byte[] image_array = ms.ToArray();
                    room_ImageTableAdapter.Insert(room_id, image_array);
                }
                MessageBox.Show("Images successfully registeresd");
                button2_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void room_ImageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.room_ImageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Add_Room_Image_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Room_Image' table. You can move, or remove it, as needed.
            this.room_ImageTableAdapter.Fill(this.groupDataset.Room_Image);

        }
    }
}
