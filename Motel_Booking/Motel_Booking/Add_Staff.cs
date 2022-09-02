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
    public partial class Add_Staff : Form
    {
        public Add_Staff()
        {
            InitializeComponent();
        }

        private bool validatePhone(string phone)
        {
            if (phone.Length != 10)
            {
                MessageBox.Show("Phone number is of incorrect length");
                return false;
            }
            if (!phone[0].Equals('0'))
            {
                MessageBox.Show("A phone number must start with a 0");
                return false;
            }
            try
            {
                Int64 x = Int64.Parse(phone);
                return true;
            }
            catch
            {
                MessageBox.Show("A phone number must only contain digits");
                return false;
            }
        }

        private bool validateEmail(string email)
        {
            if (email.Length < 7)
            {
                MessageBox.Show("Invalid email");
                return false;
            }
            int count1 = 0;
            int count2 = 0;
            foreach (char x in email)
            {
                if (x.Equals('@'))
                    count1++;
                if (x.Equals('.'))
                    count2++;
            }
            if (count1 < 1 || count2 < 1)
            {
                MessageBox.Show("Invalid email");
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Equals("") || txtEmail.Text.Equals("") || txtFName.Text.Equals("") || txtGender.Text.Equals("") || txtLName.Text.Equals("") || txtPhone.Text.Equals("") || txtJobTitle.Text.Equals(""))
            {
                MessageBox.Show("Fill in all the required details");
                return;
            }
            if (!txtGender.Items.Contains(txtGender.Text))
            {
                MessageBox.Show("The selected gender is not in the provided list");
                return;
            }
            if (!validatePhone(txtPhone.Text))
                return;
            if (!validateEmail(txtEmail.Text))
                return;
            if(!txtJobTitle.Items.Contains(txtJobTitle.Text))
            {
                MessageBox.Show("Select the correct job title");
                return;
            }
            try
            {
                string password = txtPhone.Text.Substring(0, 5) + txtFName.Text.Substring(0, 3);
                staffTableAdapter.Insert(txtFName.Text, txtLName.Text, txtGender.Text, txtPhone.Text, txtEmail.Text, txtJobTitle.Text, txtAddress.Text, password);
                MessageBox.Show("Staff inserted successfully");
                this.Hide();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Add_Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.groupDataset.Staff);

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
