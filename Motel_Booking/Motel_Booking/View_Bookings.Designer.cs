
namespace Motel_Booking
{
    partial class View_Bookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupDataset = new Motel_Booking.groupDataset();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.txtBookType = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPayDate = new System.Windows.Forms.TextBox();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.txtEEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.bookingTableAdapter = new Motel_Booking.groupDatasetTableAdapters.BookingTableAdapter();
            this.tableAdapterManager = new Motel_Booking.groupDatasetTableAdapters.TableAdapterManager();
            this.customerTableAdapter1 = new Motel_Booking.groupDatasetTableAdapters.CustomerTableAdapter();
            this.staffTableAdapter1 = new Motel_Booking.groupDatasetTableAdapters.StaffTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataset)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AllowUserToAddRows = false;
            this.bookingDataGridView.AllowUserToDeleteRows = false;
            this.bookingDataGridView.AllowUserToResizeColumns = false;
            this.bookingDataGridView.AllowUserToResizeRows = false;
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.bookingDataGridView.DataSource = this.bookingBindingSource;
            this.bookingDataGridView.Location = new System.Drawing.Point(12, 117);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.ReadOnly = true;
            this.bookingDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookingDataGridView.Size = new System.Drawing.Size(938, 462);
            this.bookingDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "booking_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "booking_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cust_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "cust_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "staff_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "staff_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "room_num";
            this.dataGridViewTextBoxColumn4.HeaderText = "room_num";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "booking_type";
            this.dataGridViewTextBoxColumn5.HeaderText = "booking_type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "total_cost";
            this.dataGridViewTextBoxColumn6.HeaderText = "total_cost";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "payment_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "payment_date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "check_in";
            this.dataGridViewTextBoxColumn8.HeaderText = "check_in";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "check_out";
            this.dataGridViewTextBoxColumn9.HeaderText = "check_out";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.groupDataset;
            // 
            // groupDataset
            // 
            this.groupDataset.DataSetName = "groupDataset";
            this.groupDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBID
            // 
            this.txtBID.BackColor = System.Drawing.Color.White;
            this.txtBID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "booking_id", true));
            this.txtBID.ForeColor = System.Drawing.Color.Black;
            this.txtBID.Location = new System.Drawing.Point(958, 87);
            this.txtBID.Name = "txtBID";
            this.txtBID.ReadOnly = true;
            this.txtBID.Size = new System.Drawing.Size(249, 29);
            this.txtBID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(958, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Booking ID";
            // 
            // txtCID
            // 
            this.txtCID.BackColor = System.Drawing.Color.White;
            this.txtCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "cust_id", true));
            this.txtCID.ForeColor = System.Drawing.Color.Black;
            this.txtCID.Location = new System.Drawing.Point(958, 150);
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(249, 29);
            this.txtCID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(958, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer ID";
            // 
            // txtSID
            // 
            this.txtSID.BackColor = System.Drawing.Color.White;
            this.txtSID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "staff_id", true));
            this.txtSID.ForeColor = System.Drawing.Color.Black;
            this.txtSID.Location = new System.Drawing.Point(958, 213);
            this.txtSID.Name = "txtSID";
            this.txtSID.ReadOnly = true;
            this.txtSID.Size = new System.Drawing.Size(249, 29);
            this.txtSID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(958, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Staff ID";
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.BackColor = System.Drawing.Color.White;
            this.txtRoomNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "room_num", true));
            this.txtRoomNum.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNum.Location = new System.Drawing.Point(958, 279);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.ReadOnly = true;
            this.txtRoomNum.Size = new System.Drawing.Size(249, 29);
            this.txtRoomNum.TabIndex = 2;
            // 
            // txtBookType
            // 
            this.txtBookType.BackColor = System.Drawing.Color.White;
            this.txtBookType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "booking_type", true));
            this.txtBookType.ForeColor = System.Drawing.Color.Black;
            this.txtBookType.Location = new System.Drawing.Point(958, 342);
            this.txtBookType.Name = "txtBookType";
            this.txtBookType.ReadOnly = true;
            this.txtBookType.Size = new System.Drawing.Size(249, 29);
            this.txtBookType.TabIndex = 2;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BackColor = System.Drawing.Color.White;
            this.txtTotalCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "total_cost", true));
            this.txtTotalCost.ForeColor = System.Drawing.Color.Black;
            this.txtTotalCost.Location = new System.Drawing.Point(958, 405);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(249, 29);
            this.txtTotalCost.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(958, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(958, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Booking Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(958, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Cost";
            // 
            // txtPayDate
            // 
            this.txtPayDate.BackColor = System.Drawing.Color.White;
            this.txtPayDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "payment_date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.txtPayDate.ForeColor = System.Drawing.Color.Black;
            this.txtPayDate.Location = new System.Drawing.Point(958, 471);
            this.txtPayDate.Name = "txtPayDate";
            this.txtPayDate.ReadOnly = true;
            this.txtPayDate.Size = new System.Drawing.Size(249, 29);
            this.txtPayDate.TabIndex = 2;
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.BackColor = System.Drawing.Color.White;
            this.txtCheckIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "check_in", true));
            this.txtCheckIn.ForeColor = System.Drawing.Color.Black;
            this.txtCheckIn.Location = new System.Drawing.Point(958, 534);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.ReadOnly = true;
            this.txtCheckIn.Size = new System.Drawing.Size(249, 29);
            this.txtCheckIn.TabIndex = 2;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.BackColor = System.Drawing.Color.White;
            this.txtCheckOut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "check_out", true));
            this.txtCheckOut.ForeColor = System.Drawing.Color.Black;
            this.txtCheckOut.Location = new System.Drawing.Point(958, 597);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.ReadOnly = true;
            this.txtCheckOut.Size = new System.Drawing.Size(249, 29);
            this.txtCheckOut.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(958, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Payment Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(958, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Check In Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(958, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Check Out Date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(59, 28);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 29);
            this.startDate.TabIndex = 4;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(330, 28);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 29);
            this.endDate.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Start";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "End";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(760, 652);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "REFRESH";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(573, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 29);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.endDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(159, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Bookings Between 2 Dates";
            // 
            // txtCName
            // 
            this.txtCName.BackColor = System.Drawing.Color.White;
            this.txtCName.ForeColor = System.Drawing.Color.Black;
            this.txtCName.Location = new System.Drawing.Point(140, 597);
            this.txtCName.Name = "txtCName";
            this.txtCName.ReadOnly = true;
            this.txtCName.Size = new System.Drawing.Size(231, 29);
            this.txtCName.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 600);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 22);
            this.label12.TabIndex = 8;
            this.label12.Text = "Customer Name";
            // 
            // txtCEmail
            // 
            this.txtCEmail.BackColor = System.Drawing.Color.White;
            this.txtCEmail.ForeColor = System.Drawing.Color.Black;
            this.txtCEmail.Location = new System.Drawing.Point(140, 637);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.ReadOnly = true;
            this.txtCEmail.Size = new System.Drawing.Size(231, 29);
            this.txtCEmail.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 640);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 22);
            this.label13.TabIndex = 8;
            this.label13.Text = "Customer Email";
            // 
            // txtEName
            // 
            this.txtEName.BackColor = System.Drawing.Color.White;
            this.txtEName.ForeColor = System.Drawing.Color.Black;
            this.txtEName.Location = new System.Drawing.Point(523, 597);
            this.txtEName.Name = "txtEName";
            this.txtEName.ReadOnly = true;
            this.txtEName.Size = new System.Drawing.Size(231, 29);
            this.txtEName.TabIndex = 7;
            // 
            // txtEEmail
            // 
            this.txtEEmail.BackColor = System.Drawing.Color.White;
            this.txtEEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEEmail.Location = new System.Drawing.Point(523, 637);
            this.txtEEmail.Name = "txtEEmail";
            this.txtEEmail.ReadOnly = true;
            this.txtEEmail.Size = new System.Drawing.Size(231, 29);
            this.txtEEmail.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(395, 600);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 22);
            this.label14.TabIndex = 8;
            this.label14.Text = "Employee Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(395, 640);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 22);
            this.label15.TabIndex = 8;
            this.label15.Text = "Employee Email";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 687);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "MORE DETAILS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.Room_ImageTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Motel_Booking.groupDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(1126, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 36);
            this.button6.TabIndex = 11;
            this.button6.Text = "BACK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // View_Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 738);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEEmail);
            this.Controls.Add(this.txtCEmail);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookType);
            this.Controls.Add(this.txtPayDate);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.txtRoomNum);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.bookingDataGridView);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View_Bookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Bookings";
            this.Load += new System.EventHandler(this.View_Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private groupDataset groupDataset;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private groupDatasetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private groupDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.TextBox txtBookType;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPayDate;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.TextBox txtEEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private groupDatasetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private groupDatasetTableAdapters.StaffTableAdapter staffTableAdapter1;
        private System.Windows.Forms.Button button6;
    }
}