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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.groupDataset.Staff);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home x = new Home();
            x.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(staffDataGridView.Rows.Count < 1)
            {
                MessageBox.Show("There is no data to search through");
                txtSearch.Text = "";
                button4_Click(sender, e);
            }
            try
            {
                staffTableAdapter.FillBySearch(groupDataset.Staff, txtSearch.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtSearch.Text = "";
                button4_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                staffTableAdapter.Fill(groupDataset.Staff);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Staff x = new Add_Staff();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtStaffID.Text.Equals(""))
            {
                MessageBox.Show("Select a staff member to continue");
                return;
            }
            Update_Staff x = new Update_Staff();
            x.setUpdate(int.Parse(txtStaffID.Text), txtFName.Text, txtLName.Text, txtGender.Text, txtPhone.Text, txtEmail.Text, txtJobTitle.Text, txtAddress.Text);
            x.Show();
        }
    }
}
