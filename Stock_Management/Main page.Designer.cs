namespace Stock_Management
{
    partial class Main_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catagoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parchaseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catagoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanelMainPage = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnHidePanel = new System.Windows.Forms.Button();
            this.btnShowPanel = new System.Windows.Forms.Button();
            this.btnSidePanel = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAllPurchase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAllCustomer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAllSales = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTotalPurchase = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.stockmgtDataSet = new Stock_Management.StockmgtDataSet();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.ChartPurchase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            this.SidePanelMainPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockmgtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.catagoryToolStripMenuItem1,
            this.brandToolStripMenuItem1,
            this.itemToolStripMenuItem1,
            this.vendorToolStripMenuItem1,
            this.customerToolStripMenuItem1,
            this.saleToolStripMenuItem1,
            this.loginToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1314, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // catagoryToolStripMenuItem1
            // 
            this.catagoryToolStripMenuItem1.Name = "catagoryToolStripMenuItem1";
            this.catagoryToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.catagoryToolStripMenuItem1.Text = "Catagory";
            this.catagoryToolStripMenuItem1.Click += new System.EventHandler(this.catagoryToolStripMenuItem1_Click);
            // 
            // brandToolStripMenuItem1
            // 
            this.brandToolStripMenuItem1.Name = "brandToolStripMenuItem1";
            this.brandToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.brandToolStripMenuItem1.Text = "Brand";
            this.brandToolStripMenuItem1.Click += new System.EventHandler(this.brandToolStripMenuItem1_Click);
            // 
            // itemToolStripMenuItem1
            // 
            this.itemToolStripMenuItem1.Name = "itemToolStripMenuItem1";
            this.itemToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.itemToolStripMenuItem1.Text = "Item";
            this.itemToolStripMenuItem1.Click += new System.EventHandler(this.itemToolStripMenuItem1_Click);
            // 
            // vendorToolStripMenuItem1
            // 
            this.vendorToolStripMenuItem1.Name = "vendorToolStripMenuItem1";
            this.vendorToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.vendorToolStripMenuItem1.Text = "Vendor";
            this.vendorToolStripMenuItem1.Click += new System.EventHandler(this.vendorToolStripMenuItem1_Click);
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem1.Text = "Customer";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.customerToolStripMenuItem1_Click);
            // 
            // saleToolStripMenuItem1
            // 
            this.saleToolStripMenuItem1.Name = "saleToolStripMenuItem1";
            this.saleToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.saleToolStripMenuItem1.Text = "Sale";
            this.saleToolStripMenuItem1.Click += new System.EventHandler(this.saleToolStripMenuItem1_Click);
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem1.Text = "Login";
            this.loginToolStripMenuItem1.Click += new System.EventHandler(this.loginToolStripMenuItem1_Click);
            // 
            // parchaseDetailsToolStripMenuItem
            // 
            this.parchaseDetailsToolStripMenuItem.Name = "parchaseDetailsToolStripMenuItem";
            this.parchaseDetailsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.parchaseDetailsToolStripMenuItem.Text = "Purchase";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.brandToolStripMenuItem.Text = "Catagory";
            // 
            // catagoryToolStripMenuItem
            // 
            this.catagoryToolStripMenuItem.Name = "catagoryToolStripMenuItem";
            this.catagoryToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.catagoryToolStripMenuItem.Text = "Brand";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendorToolStripMenuItem.Text = "Vendor";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.saleToolStripMenuItem.Text = "Sale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To The Stock Management Database";
            // 
            // SidePanelMainPage
            // 
            this.SidePanelMainPage.BackColor = System.Drawing.Color.Teal;
            this.SidePanelMainPage.Controls.Add(this.button6);
            this.SidePanelMainPage.Controls.Add(this.btnHidePanel);
            this.SidePanelMainPage.Controls.Add(this.btnShowPanel);
            this.SidePanelMainPage.Controls.Add(this.btnSidePanel);
            this.SidePanelMainPage.Controls.Add(this.btnAbout);
            this.SidePanelMainPage.Controls.Add(this.btnLogin);
            this.SidePanelMainPage.Controls.Add(this.btnSale);
            this.SidePanelMainPage.Controls.Add(this.btnPurchase);
            this.SidePanelMainPage.Controls.Add(this.btnVendor);
            this.SidePanelMainPage.Controls.Add(this.btnCategory);
            this.SidePanelMainPage.Controls.Add(this.btnItem);
            this.SidePanelMainPage.Controls.Add(this.btnCustomer);
            this.SidePanelMainPage.Controls.Add(this.btnBrand);
            this.SidePanelMainPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelMainPage.Location = new System.Drawing.Point(20, 84);
            this.SidePanelMainPage.Name = "SidePanelMainPage";
            this.SidePanelMainPage.Size = new System.Drawing.Size(209, 629);
            this.SidePanelMainPage.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(6, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 40);
            this.button6.TabIndex = 12;
            this.button6.Text = "      Dashbord";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnHidePanel
            // 
            this.btnHidePanel.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnHidePanel.FlatAppearance.BorderSize = 0;
            this.btnHidePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePanel.Location = new System.Drawing.Point(0, 0);
            this.btnHidePanel.Name = "btnHidePanel";
            this.btnHidePanel.Size = new System.Drawing.Size(55, 55);
            this.btnHidePanel.TabIndex = 11;
            this.btnHidePanel.UseVisualStyleBackColor = true;
            this.btnHidePanel.Click += new System.EventHandler(this.btnHidePanel_Click);
            // 
            // btnShowPanel
            // 
            this.btnShowPanel.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnShowPanel.FlatAppearance.BorderSize = 0;
            this.btnShowPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPanel.Location = new System.Drawing.Point(0, 0);
            this.btnShowPanel.Name = "btnShowPanel";
            this.btnShowPanel.Size = new System.Drawing.Size(55, 55);
            this.btnShowPanel.TabIndex = 10;
            this.btnShowPanel.UseVisualStyleBackColor = true;
            this.btnShowPanel.Click += new System.EventHandler(this.btnShowPanel_Click);
            // 
            // btnSidePanel
            // 
            this.btnSidePanel.BackColor = System.Drawing.Color.White;
            this.btnSidePanel.Location = new System.Drawing.Point(0, 145);
            this.btnSidePanel.Name = "btnSidePanel";
            this.btnSidePanel.Size = new System.Drawing.Size(8, 40);
            this.btnSidePanel.TabIndex = 10;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(9, 456);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(185, 40);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "      About";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(9, 417);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(185, 40);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "      Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSale
            // 
            this.btnSale.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(9, 378);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(185, 40);
            this.btnSale.TabIndex = 7;
            this.btnSale.Text = "     Sale";
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Teal;
            this.btnPurchase.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(9, 144);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(185, 40);
            this.btnPurchase.TabIndex = 1;
            this.btnPurchase.Text = "      Purchase";
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVendor.FlatAppearance.BorderSize = 0;
            this.btnVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendor.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnVendor.ForeColor = System.Drawing.Color.White;
            this.btnVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendor.Location = new System.Drawing.Point(9, 339);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(185, 40);
            this.btnVendor.TabIndex = 6;
            this.btnVendor.Text = "     Vendor";
            this.btnVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendor.UseVisualStyleBackColor = true;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(9, 183);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(185, 40);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "      Category";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnItem
            // 
            this.btnItem.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnItem.FlatAppearance.BorderSize = 0;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnItem.ForeColor = System.Drawing.Color.White;
            this.btnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItem.Location = new System.Drawing.Point(9, 261);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(185, 40);
            this.btnItem.TabIndex = 5;
            this.btnItem.Text = "      Item";
            this.btnItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(9, 300);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(185, 40);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "     Customer";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.BackColor = System.Drawing.Color.Teal;
            this.btnBrand.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnBrand.ForeColor = System.Drawing.Color.White;
            this.btnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrand.Location = new System.Drawing.Point(9, 222);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(185, 40);
            this.btnBrand.TabIndex = 3;
            this.btnBrand.Text = "      Brand";
            this.btnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrand.UseVisualStyleBackColor = false;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(229, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 62);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblAllPurchase);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(235, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 160);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(168, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 110);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblAllPurchase
            // 
            this.lblAllPurchase.AutoSize = true;
            this.lblAllPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPurchase.ForeColor = System.Drawing.Color.White;
            this.lblAllPurchase.Location = new System.Drawing.Point(16, 100);
            this.lblAllPurchase.Name = "lblAllPurchase";
            this.lblAllPurchase.Size = new System.Drawing.Size(0, 37);
            this.lblAllPurchase.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "All Purchases";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.panel3.Controls.Add(this.lblAllCustomer);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(1064, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 160);
            this.panel3.TabIndex = 10;
            // 
            // lblAllCustomer
            // 
            this.lblAllCustomer.AutoSize = true;
            this.lblAllCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCustomer.ForeColor = System.Drawing.Color.White;
            this.lblAllCustomer.Location = new System.Drawing.Point(13, 101);
            this.lblAllCustomer.Name = "lblAllCustomer";
            this.lblAllCustomer.Size = new System.Drawing.Size(0, 37);
            this.lblAllCustomer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Sales";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(166, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 99);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel4.Controls.Add(this.lblAllSales);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(788, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 160);
            this.panel4.TabIndex = 10;
            // 
            // lblAllSales
            // 
            this.lblAllSales.AutoSize = true;
            this.lblAllSales.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllSales.ForeColor = System.Drawing.Color.White;
            this.lblAllSales.Location = new System.Drawing.Point(20, 97);
            this.lblAllSales.Name = "lblAllSales";
            this.lblAllSales.Size = new System.Drawing.Size(0, 37);
            this.lblAllSales.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "All Sales";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(157, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 110);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.lblTotalPurchase);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(512, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 160);
            this.panel5.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(168, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 110);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblTotalPurchase
            // 
            this.lblTotalPurchase.AutoSize = true;
            this.lblTotalPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPurchase.ForeColor = System.Drawing.Color.White;
            this.lblTotalPurchase.Location = new System.Drawing.Point(16, 100);
            this.lblTotalPurchase.Name = "lblTotalPurchase";
            this.lblTotalPurchase.Size = new System.Drawing.Size(0, 37);
            this.lblTotalPurchase.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Purchases";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(827, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 110);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // stockmgtDataSet
            // 
            this.stockmgtDataSet.DataSetName = "StockmgtDataSet";
            this.stockmgtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.TabIndex = 0;
            this.metroButton1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(0, 0);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.TabIndex = 0;
            this.metroTile2.UseSelectable = true;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(246, 335);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(536, 378);
            this.cartesianChart1.TabIndex = 15;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // ChartPurchase
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartPurchase.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartPurchase.Legends.Add(legend1);
            this.ChartPurchase.Location = new System.Drawing.Point(797, 335);
            this.ChartPurchase.Name = "ChartPurchase";
            this.ChartPurchase.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.ChartPurchase.Series.Add(series1);
            this.ChartPurchase.Series.Add(series2);
            this.ChartPurchase.Series.Add(series3);
            this.ChartPurchase.Size = new System.Drawing.Size(477, 347);
            this.ChartPurchase.TabIndex = 16;
            this.ChartPurchase.Text = "chart1";
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.ChartPurchase);
//            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SidePanelMainPage);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main_Page";
            this.Text = "Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SidePanelMainPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockmgtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parchaseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catagoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.Panel SidePanelMainPage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catagoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem1;
        private System.Windows.Forms.Panel btnSidePanel;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.Button btnHidePanel;
        private System.Windows.Forms.Button btnShowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAllPurchase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAllSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAllCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblTotalPurchase;
        private System.Windows.Forms.Button button5;
        private StockmgtDataSet stockmgtDataSet;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.Button button6;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPurchase;
    }
}