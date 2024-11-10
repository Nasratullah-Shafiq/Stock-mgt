namespace Stock_Management
{
    partial class Purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DataGridPurchase = new System.Windows.Forms.DataGridView();
            this.DataGridItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpPurchase = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lstItem = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPurchaseHeader = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TabControlPurchase = new System.Windows.Forms.TabControl();
            this.TabPagePurchaseTransaction = new System.Windows.Forms.TabPage();
            this.TabPagePurchaseList = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.DataGridViewPurchaseList = new System.Windows.Forms.DataGridView();
            this.TabPagePurchaseDetails = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.DataGridViewPurchaseDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPurchase)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControlPurchase.SuspendLayout();
            this.TabPagePurchaseTransaction.SuspendLayout();
            this.TabPagePurchaseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPurchaseList)).BeginInit();
            this.TabPagePurchaseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPurchaseDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVendor
            // 
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(172, 55);
            this.cmbVendor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(377, 25);
            this.cmbVendor.TabIndex = 35;
            this.cmbVendor.SelectedIndexChanged += new System.EventHandler(this.cmbVendor_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(766, 304);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(286, 177);
            this.txtDescription.TabIndex = 32;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(770, 31);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 25);
            this.txtSearch.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(41, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(653, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(144, 169);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 30);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(250, 169);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Location = new System.Drawing.Point(37, 169);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 30);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(653, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // DataGridPurchase
            // 
            this.DataGridPurchase.AllowUserToAddRows = false;
            this.DataGridPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridItemId,
            this.DataGridItem,
            this.DataGridPrice,
            this.DataGridQuantity,
            this.DataGridTotal});
            this.DataGridPurchase.Location = new System.Drawing.Point(37, 221);
            this.DataGridPurchase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridPurchase.Name = "DataGridPurchase";
            this.DataGridPurchase.RowHeadersVisible = false;
            this.DataGridPurchase.Size = new System.Drawing.Size(512, 260);
            this.DataGridPurchase.TabIndex = 20;
            this.DataGridPurchase.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBrand_CellLeave);
            // 
            // DataGridItemId
            // 
            this.DataGridItemId.HeaderText = "ID";
            this.DataGridItemId.Name = "DataGridItemId";
            this.DataGridItemId.Visible = false;
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
            this.DataGridTotal.ReadOnly = true;
            // 
            // dtpPurchase
            // 
            this.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchase.Location = new System.Drawing.Point(172, 88);
            this.dtpPurchase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPurchase.Name = "dtpPurchase";
            this.dtpPurchase.Size = new System.Drawing.Size(377, 25);
            this.dtpPurchase.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Vendor";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(766, 29);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(286, 25);
            this.cmbCategory.TabIndex = 37;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCatagory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(646, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Catagory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(646, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Brand";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(766, 64);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(286, 25);
            this.cmbBrand.TabIndex = 37;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(140, 490);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(409, 25);
            this.txtTotal.TabIndex = 39;
            // 
            // lstItem
            // 
            this.lstItem.FormattingEnabled = true;
            this.lstItem.ItemHeight = 17;
            this.lstItem.Location = new System.Drawing.Point(766, 119);
            this.lstItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(286, 157);
            this.lstItem.TabIndex = 40;
            this.lstItem.DoubleClick += new System.EventHandler(this.lstItem_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(653, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Item";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(172, 121);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(377, 25);
            this.txtDiscount.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(41, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Purchase ID";
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Location = new System.Drawing.Point(172, 22);
            this.txtPurchaseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.Size = new System.Drawing.Size(377, 25);
            this.txtPurchaseID.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(41, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Discount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblPurchaseHeader);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 84);
            this.panel1.TabIndex = 45;
            // 
            // lblPurchaseHeader
            // 
            this.lblPurchaseHeader.AutoSize = true;
            this.lblPurchaseHeader.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseHeader.ForeColor = System.Drawing.Color.White;
            this.lblPurchaseHeader.Location = new System.Drawing.Point(42, 21);
            this.lblPurchaseHeader.Name = "lblPurchaseHeader";
            this.lblPurchaseHeader.Size = new System.Drawing.Size(244, 33);
            this.lblPurchaseHeader.TabIndex = 46;
            this.lblPurchaseHeader.Text = "Purchase Transaction";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(41, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Grand Total";
            // 
            // TabControlPurchase
            // 
            this.TabControlPurchase.Controls.Add(this.TabPagePurchaseTransaction);
            this.TabControlPurchase.Controls.Add(this.TabPagePurchaseList);
            this.TabControlPurchase.Controls.Add(this.TabPagePurchaseDetails);
            this.TabControlPurchase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControlPurchase.Location = new System.Drawing.Point(0, 84);
            this.TabControlPurchase.Name = "TabControlPurchase";
            this.TabControlPurchase.SelectedIndex = 0;
            this.TabControlPurchase.Size = new System.Drawing.Size(1116, 558);
            this.TabControlPurchase.TabIndex = 47;
            this.TabControlPurchase.SelectedIndexChanged += new System.EventHandler(this.TabControlPurchase_SelectedIndexChanged);
            // 
            // TabPagePurchaseTransaction
            // 
            this.TabPagePurchaseTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPagePurchaseTransaction.Controls.Add(this.label11);
            this.TabPagePurchaseTransaction.Controls.Add(this.label6);
            this.TabPagePurchaseTransaction.Controls.Add(this.DataGridPurchase);
            this.TabPagePurchaseTransaction.Controls.Add(this.label4);
            this.TabPagePurchaseTransaction.Controls.Add(this.btnNew);
            this.TabPagePurchaseTransaction.Controls.Add(this.txtDiscount);
            this.TabPagePurchaseTransaction.Controls.Add(this.btnUpdate);
            this.TabPagePurchaseTransaction.Controls.Add(this.label9);
            this.TabPagePurchaseTransaction.Controls.Add(this.btnSave);
            this.TabPagePurchaseTransaction.Controls.Add(this.lstItem);
            this.TabPagePurchaseTransaction.Controls.Add(this.txtTotal);
            this.TabPagePurchaseTransaction.Controls.Add(this.cmbBrand);
            this.TabPagePurchaseTransaction.Controls.Add(this.label3);
            this.TabPagePurchaseTransaction.Controls.Add(this.cmbCategory);
            this.TabPagePurchaseTransaction.Controls.Add(this.label5);
            this.TabPagePurchaseTransaction.Controls.Add(this.dtpPurchase);
            this.TabPagePurchaseTransaction.Controls.Add(this.label2);
            this.TabPagePurchaseTransaction.Controls.Add(this.cmbVendor);
            this.TabPagePurchaseTransaction.Controls.Add(this.label1);
            this.TabPagePurchaseTransaction.Controls.Add(this.txtPurchaseID);
            this.TabPagePurchaseTransaction.Controls.Add(this.label7);
            this.TabPagePurchaseTransaction.Controls.Add(this.txtDescription);
            this.TabPagePurchaseTransaction.Location = new System.Drawing.Point(4, 26);
            this.TabPagePurchaseTransaction.Name = "TabPagePurchaseTransaction";
            this.TabPagePurchaseTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePurchaseTransaction.Size = new System.Drawing.Size(1108, 528);
            this.TabPagePurchaseTransaction.TabIndex = 0;
            this.TabPagePurchaseTransaction.Text = "Purchase Transaction";
            // 
            // TabPagePurchaseList
            // 
            this.TabPagePurchaseList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPagePurchaseList.Controls.Add(this.label10);
            this.TabPagePurchaseList.Controls.Add(this.DataGridViewPurchaseList);
            this.TabPagePurchaseList.Location = new System.Drawing.Point(4, 26);
            this.TabPagePurchaseList.Name = "TabPagePurchaseList";
            this.TabPagePurchaseList.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePurchaseList.Size = new System.Drawing.Size(1108, 528);
            this.TabPagePurchaseList.TabIndex = 1;
            this.TabPagePurchaseList.Text = "Purchase List";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(38, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 33);
            this.label10.TabIndex = 47;
            this.label10.Text = "Purchase List";
            // 
            // DataGridViewPurchaseList
            // 
            this.DataGridViewPurchaseList.AllowUserToAddRows = false;
            this.DataGridViewPurchaseList.AllowUserToDeleteRows = false;
            this.DataGridViewPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPurchaseList.Location = new System.Drawing.Point(44, 71);
            this.DataGridViewPurchaseList.Name = "DataGridViewPurchaseList";
            this.DataGridViewPurchaseList.ReadOnly = true;
            this.DataGridViewPurchaseList.RowHeadersVisible = false;
            this.DataGridViewPurchaseList.Size = new System.Drawing.Size(1003, 427);
            this.DataGridViewPurchaseList.TabIndex = 0;
            this.DataGridViewPurchaseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPurchaseList_CellContentClick);
            // 
            // TabPagePurchaseDetails
            // 
            this.TabPagePurchaseDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPagePurchaseDetails.Controls.Add(this.label12);
            this.TabPagePurchaseDetails.Controls.Add(this.DataGridViewPurchaseDetails);
            this.TabPagePurchaseDetails.Location = new System.Drawing.Point(4, 26);
            this.TabPagePurchaseDetails.Name = "TabPagePurchaseDetails";
            this.TabPagePurchaseDetails.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePurchaseDetails.Size = new System.Drawing.Size(1108, 528);
            this.TabPagePurchaseDetails.TabIndex = 2;
            this.TabPagePurchaseDetails.Text = "Purchase Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(38, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 33);
            this.label12.TabIndex = 49;
            this.label12.Text = "Purchase Details";
            // 
            // DataGridViewPurchaseDetails
            // 
            this.DataGridViewPurchaseDetails.AllowUserToAddRows = false;
            this.DataGridViewPurchaseDetails.AllowUserToDeleteRows = false;
            this.DataGridViewPurchaseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPurchaseDetails.Location = new System.Drawing.Point(44, 75);
            this.DataGridViewPurchaseDetails.Name = "DataGridViewPurchaseDetails";
            this.DataGridViewPurchaseDetails.ReadOnly = true;
            this.DataGridViewPurchaseDetails.RowHeadersVisible = false;
            this.DataGridViewPurchaseDetails.Size = new System.Drawing.Size(1003, 427);
            this.DataGridViewPurchaseDetails.TabIndex = 48;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1116, 642);
            this.Controls.Add(this.TabControlPurchase);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parchase";
            this.Load += new System.EventHandler(this.Parchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPurchase)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabControlPurchase.ResumeLayout(false);
            this.TabPagePurchaseTransaction.ResumeLayout(false);
            this.TabPagePurchaseTransaction.PerformLayout();
            this.TabPagePurchaseList.ResumeLayout(false);
            this.TabPagePurchaseList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPurchaseList)).EndInit();
            this.TabPagePurchaseDetails.ResumeLayout(false);
            this.TabPagePurchaseDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPurchaseDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView DataGridPurchase;
        private System.Windows.Forms.DateTimePicker dtpPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPurchaseID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPurchaseHeader;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl TabControlPurchase;
        private System.Windows.Forms.TabPage TabPagePurchaseTransaction;
        private System.Windows.Forms.TabPage TabPagePurchaseList;
        private System.Windows.Forms.TabPage TabPagePurchaseDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DataGridViewPurchaseList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DataGridViewPurchaseDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridTotal;
    }
}