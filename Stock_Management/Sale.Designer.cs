namespace Stock_Management
{
    partial class Sale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblSaleHeader = new System.Windows.Forms.Label();
            this.lstItem = new System.Windows.Forms.ListBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DataGridSale = new System.Windows.Forms.DataGridView();
            this.DataGridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControlSale = new System.Windows.Forms.TabControl();
            this.TabPageSaleTransaction = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TabPageSaleList = new System.Windows.Forms.TabPage();
            this.DataGridViewSaleList = new MetroFramework.Controls.MetroGrid();
            this.label11 = new System.Windows.Forms.Label();
            this.TabPageSaleDetails = new System.Windows.Forms.TabPage();
            this.DataGridViewSaleDetails = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSale)).BeginInit();
            this.TabControlSale.SuspendLayout();
            this.TabPageSaleTransaction.SuspendLayout();
            this.TabPageSaleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSaleList)).BeginInit();
            this.TabPageSaleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSaleDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(36, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(142, 115);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(339, 25);
            this.txtDiscount.TabIndex = 69;
            // 
            // lblSaleHeader
            // 
            this.lblSaleHeader.AutoSize = true;
            this.lblSaleHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleHeader.ForeColor = System.Drawing.Color.White;
            this.lblSaleHeader.Location = new System.Drawing.Point(36, 24);
            this.lblSaleHeader.Name = "lblSaleHeader";
            this.lblSaleHeader.Size = new System.Drawing.Size(218, 37);
            this.lblSaleHeader.TabIndex = 67;
            this.lblSaleHeader.Text = "Sales Transaction";
            // 
            // lstItem
            // 
            this.lstItem.FormattingEnabled = true;
            this.lstItem.ItemHeight = 17;
            this.lstItem.Location = new System.Drawing.Point(624, 88);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(246, 106);
            this.lstItem.TabIndex = 66;
            this.lstItem.SelectedIndexChanged += new System.EventHandler(this.lstItem_SelectedIndexChanged);
            this.lstItem.DoubleClick += new System.EventHandler(this.lstItem_DoubleClick);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(130, 405);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(351, 25);
            this.txtTotal.TabIndex = 65;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(624, 54);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(246, 25);
            this.cmbBrand.TabIndex = 64;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(624, 23);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(246, 25);
            this.cmbCategory.TabIndex = 63;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCatagory_SelectedIndexChanged);
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleDate.Location = new System.Drawing.Point(142, 85);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(339, 25);
            this.dtpSaleDate.TabIndex = 62;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(142, 55);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(339, 25);
            this.cmbCustomer.TabIndex = 61;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Location = new System.Drawing.Point(142, 23);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.ReadOnly = true;
            this.txtSaleID.Size = new System.Drawing.Size(339, 25);
            this.txtSaleID.TabIndex = 60;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(624, 223);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(246, 207);
            this.txtDescription.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(36, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Sale ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(553, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(553, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Catagory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(36, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(553, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Note";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(305, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(393, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(128, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(217, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 27);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Teal;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(39, 152);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 27);
            this.btnNew.TabIndex = 47;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(527, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DataGridSale
            // 
            this.DataGridSale.AllowUserToAddRows = false;
            this.DataGridSale.AllowUserToDeleteRows = false;
            this.DataGridSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridID,
            this.DataGridItem,
            this.DataGridPrice,
            this.DataGridQuantity,
            this.DataGridTotal});
            this.DataGridSale.Location = new System.Drawing.Point(39, 191);
            this.DataGridSale.Name = "DataGridSale";
            this.DataGridSale.RowHeadersVisible = false;
            this.DataGridSale.Size = new System.Drawing.Size(442, 199);
            this.DataGridSale.TabIndex = 45;
            this.DataGridSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSale_CellClick);
            this.DataGridSale.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSale_CellLeave);
            // 
            // DataGridID
            // 
            this.DataGridID.HeaderText = "ID";
            this.DataGridID.Name = "DataGridID";
            this.DataGridID.Visible = false;
            // 
            // DataGridItem
            // 
            this.DataGridItem.HeaderText = "Item";
            this.DataGridItem.Name = "DataGridItem";
            // 
            // DataGridPrice
            // 
            this.DataGridPrice.HeaderText = "Price";
            this.DataGridPrice.Name = "DataGridPrice";
            // 
            // DataGridQuantity
            // 
            this.DataGridQuantity.HeaderText = "Quantity";
            this.DataGridQuantity.Name = "DataGridQuantity";
            // 
            // DataGridTotal
            // 
            this.DataGridTotal.HeaderText = "Total";
            this.DataGridTotal.Name = "DataGridTotal";
            // 
            // TabControlSale
            // 
            this.TabControlSale.Controls.Add(this.TabPageSaleTransaction);
            this.TabControlSale.Controls.Add(this.TabPageSaleList);
            this.TabControlSale.Controls.Add(this.TabPageSaleDetails);
            this.TabControlSale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControlSale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlSale.Location = new System.Drawing.Point(0, 86);
            this.TabControlSale.Name = "TabControlSale";
            this.TabControlSale.SelectedIndex = 0;
            this.TabControlSale.Size = new System.Drawing.Size(909, 490);
            this.TabControlSale.TabIndex = 71;
            this.TabControlSale.SelectedIndexChanged += new System.EventHandler(this.TabControlSale_SelectedIndexChanged);
            // 
            // TabPageSaleTransaction
            // 
            this.TabPageSaleTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPageSaleTransaction.Controls.Add(this.label12);
            this.TabPageSaleTransaction.Controls.Add(this.label8);
            this.TabPageSaleTransaction.Controls.Add(this.txtSaleID);
            this.TabPageSaleTransaction.Controls.Add(this.label4);
            this.TabPageSaleTransaction.Controls.Add(this.DataGridSale);
            this.TabPageSaleTransaction.Controls.Add(this.txtDiscount);
            this.TabPageSaleTransaction.Controls.Add(this.btnNew);
            this.TabPageSaleTransaction.Controls.Add(this.btnUpdate);
            this.TabPageSaleTransaction.Controls.Add(this.lstItem);
            this.TabPageSaleTransaction.Controls.Add(this.btnSave);
            this.TabPageSaleTransaction.Controls.Add(this.txtTotal);
            this.TabPageSaleTransaction.Controls.Add(this.btnClose);
            this.TabPageSaleTransaction.Controls.Add(this.cmbBrand);
            this.TabPageSaleTransaction.Controls.Add(this.btnDelete);
            this.TabPageSaleTransaction.Controls.Add(this.cmbCategory);
            this.TabPageSaleTransaction.Controls.Add(this.label3);
            this.TabPageSaleTransaction.Controls.Add(this.dtpSaleDate);
            this.TabPageSaleTransaction.Controls.Add(this.label5);
            this.TabPageSaleTransaction.Controls.Add(this.cmbCustomer);
            this.TabPageSaleTransaction.Controls.Add(this.label2);
            this.TabPageSaleTransaction.Controls.Add(this.label1);
            this.TabPageSaleTransaction.Controls.Add(this.txtDescription);
            this.TabPageSaleTransaction.Controls.Add(this.label7);
            this.TabPageSaleTransaction.Controls.Add(this.label6);
            this.TabPageSaleTransaction.Location = new System.Drawing.Point(4, 26);
            this.TabPageSaleTransaction.Name = "TabPageSaleTransaction";
            this.TabPageSaleTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSaleTransaction.Size = new System.Drawing.Size(901, 460);
            this.TabPageSaleTransaction.TabIndex = 0;
            this.TabPageSaleTransaction.Text = "Sale Transaction";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(553, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 72;
            this.label12.Text = "Item";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(38, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Grand Total";
            // 
            // TabPageSaleList
            // 
            this.TabPageSaleList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPageSaleList.Controls.Add(this.DataGridViewSaleList);
            this.TabPageSaleList.Controls.Add(this.label11);
            this.TabPageSaleList.Location = new System.Drawing.Point(4, 26);
            this.TabPageSaleList.Name = "TabPageSaleList";
            this.TabPageSaleList.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSaleList.Size = new System.Drawing.Size(901, 460);
            this.TabPageSaleList.TabIndex = 1;
            this.TabPageSaleList.Text = "Sale List";
            // 
            // DataGridViewSaleList
            // 
            this.DataGridViewSaleList.AllowUserToResizeRows = false;
            this.DataGridViewSaleList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewSaleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewSaleList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewSaleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSaleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSaleList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewSaleList.EnableHeadersVisualStyles = false;
            this.DataGridViewSaleList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewSaleList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewSaleList.Location = new System.Drawing.Point(39, 72);
            this.DataGridViewSaleList.Name = "DataGridViewSaleList";
            this.DataGridViewSaleList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSaleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewSaleList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewSaleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewSaleList.Size = new System.Drawing.Size(818, 369);
            this.DataGridViewSaleList.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(32, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 37);
            this.label11.TabIndex = 69;
            this.label11.Text = "Sale List";
            // 
            // TabPageSaleDetails
            // 
            this.TabPageSaleDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPageSaleDetails.Controls.Add(this.DataGridViewSaleDetails);
            this.TabPageSaleDetails.Controls.Add(this.label10);
            this.TabPageSaleDetails.Location = new System.Drawing.Point(4, 26);
            this.TabPageSaleDetails.Name = "TabPageSaleDetails";
            this.TabPageSaleDetails.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSaleDetails.Size = new System.Drawing.Size(901, 460);
            this.TabPageSaleDetails.TabIndex = 2;
            this.TabPageSaleDetails.Text = "Sale Details";
            // 
            // DataGridViewSaleDetails
            // 
            this.DataGridViewSaleDetails.AllowUserToAddRows = false;
            this.DataGridViewSaleDetails.AllowUserToDeleteRows = false;
            this.DataGridViewSaleDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewSaleDetails.Location = new System.Drawing.Point(39, 70);
            this.DataGridViewSaleDetails.Name = "DataGridViewSaleDetails";
            this.DataGridViewSaleDetails.ReadOnly = true;
            this.DataGridViewSaleDetails.RowHeadersVisible = false;
            this.DataGridViewSaleDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewSaleDetails.Size = new System.Drawing.Size(818, 353);
            this.DataGridViewSaleDetails.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(32, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 37);
            this.label10.TabIndex = 69;
            this.label10.Text = "Sale Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblSaleHeader);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 80);
            this.panel1.TabIndex = 72;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(628, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(233, 25);
            this.txtSearch.TabIndex = 58;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.TabIndex = 0;
            this.metroButton1.UseSelectable = true;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(909, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabControlSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSale)).EndInit();
            this.TabControlSale.ResumeLayout(false);
            this.TabPageSaleTransaction.ResumeLayout(false);
            this.TabPageSaleTransaction.PerformLayout();
            this.TabPageSaleList.ResumeLayout(false);
            this.TabPageSaleList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSaleList)).EndInit();
            this.TabPageSaleDetails.ResumeLayout(false);
            this.TabPageSaleDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSaleDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblSaleHeader;
        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView DataGridSale;
        private System.Windows.Forms.TabControl TabControlSale;
        private System.Windows.Forms.TabPage TabPageSaleTransaction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage TabPageSaleList;
        private System.Windows.Forms.TabPage TabPageSaleDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGridViewSaleDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridTotal;
        private MetroFramework.Controls.MetroGrid DataGridViewSaleList;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}