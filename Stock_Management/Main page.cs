using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock_Management
{
    public partial class Main_Page : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-R7SN7US\\NASRATSQL; initial catalog = stockmgt; integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter d_Adapter = new SqlDataAdapter();
        DataSet d_Set = new DataSet();
        SqlDataReader D_Reader;
        public Main_Page()
        {
            InitializeComponent();
            cmd.Connection = con;
            d_Adapter.SelectCommand = cmd;
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            this.btnPurchase.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnLogin.BackColor = Color.Teal;
            btnAbout.BackColor = Color.Teal;
            btnSidePanel.Height = btnPurchase.Height;
            btnSidePanel.Top = btnPurchase.Top;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.btnCategory.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            btnPurchase.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnLogin.BackColor = Color.Teal;
            btnAbout.BackColor = Color.Teal;
            btnSidePanel.Height = btnCategory.Height;
            btnSidePanel.Top = btnCategory.Top;
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            this.btnBrand.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            btnCategory.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnLogin.BackColor = Color.Teal;
            btnAbout.BackColor = Color.Teal;
            btnSidePanel.Height = btnBrand.Height;
            btnSidePanel.Top = btnBrand.Top;
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            this.btnItem.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnLogin.BackColor = Color.Teal;
            btnAbout.BackColor = Color.Teal;
            btnSidePanel.Height = btnItem.Height;
            btnSidePanel.Top = btnItem.Top;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.btnCustomer.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnLogin.BackColor = Color.Teal;
            btnAbout.BackColor = Color.Teal;
            btnSidePanel.Height = btnCustomer.Height;
            btnSidePanel.Top = btnCustomer.Top;
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            this.btnVendor.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnLogin.BackColor = Color.Teal;
            btnAbout.BackColor = Color.Teal;
            btnSidePanel.Height = btnVendor.Height;
            btnSidePanel.Top = btnVendor.Top;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            this.btnSale.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnLogin.BackColor = Color.Teal;
            btnAbout.BackColor = Color.Teal;
            btnSidePanel.Height = btnSale.Height;
            btnSidePanel.Top = btnSale.Top;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnAbout.BackColor = Color.Teal;
            btnSidePanel.Height = btnLogin.Height;
            btnSidePanel.Top = btnLogin.Top;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.btnAbout.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnLogin.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnSidePanel.Height = btnAbout.Height;
            btnSidePanel.Top = btnAbout.Top;
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase frm = new Purchase();
            //frm.MdiParent = this;
            frm.Show();
            AllPurchase();
            AllSales();
            AllCustomers();
            TotalAmountOfPurchase();
        }

        private void catagoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Category frm = new Category();
            frm.Show();
            AllPurchase();
            AllSales();
            AllCustomers();
            TotalAmountOfPurchase();
        }

        private void brandToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Brand frm = new Brand();
            frm.Show();
            AllPurchase();
            AllSales();
            AllCustomers();
            TotalAmountOfPurchase();
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Item frm = new Item();
            frm.Show();
            AllPurchase();
            AllSales();
            AllCustomers();
            TotalAmountOfPurchase();
        }

        private void vendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vendor frm = new Vendor();
            frm.Show();
            AllPurchase();
            AllSales();
            AllCustomers();
            TotalAmountOfPurchase();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customer frm = new Customer();
            frm.Show();
            AllPurchase();
            AllSales();
            AllCustomers();
            TotalAmountOfPurchase();
        }

        private void saleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sale frm = new Sale();
            frm.Show();
            AllPurchase();
            AllSales();
            AllCustomers();
            TotalAmountOfPurchase();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
        }

        private void btnShowPanel_Click(object sender, EventArgs e)
        {
            SidePanelMainPage.Location = new Point(0, 24);
            SidePanelMainPage.Size = new Size(209,576);
            btnShowPanel.Visible = false;
            btnHidePanel.Visible = true;
        }

        private void btnHidePanel_Click(object sender, EventArgs e)
        {
            SidePanelMainPage.Location = new Point(0, 24);
            SidePanelMainPage.Size = new Size(54, 576);
            btnShowPanel.Visible = true;
            btnHidePanel.Visible = false;
        }
        public void AllPurchase()
        {
            try
            {
                con.Open();
                string str = "select isnull(MAX(Purchase_ID),0) from PurchaseMain";
                cmd.CommandText = str;
                lblAllPurchase.Text = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void AllSales()
        {
            try
            {
                con.Open();
                string str = "select isnull(MAX(Sale_ID),0) from SaleMain";
                cmd.CommandText = str;
                lblAllSales.Text = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void AllCustomers()
        {
            try
            {
                con.Open();
                string str = "select isnull(SUM(Grand_Total),0) from SaleMain";
                cmd.CommandText = str;
                lblAllCustomer.Text = cmd.ExecuteScalar().ToString()+" $";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void TotalAmountOfPurchase()
        {
            try
            {
                con.Open();
                string str = "select isnull(SUM(Grand_Total),0) from PurchaseMain";
                cmd.CommandText = str;
                lblTotalPurchase.Text = cmd.ExecuteScalar().ToString()+" $";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockmgtDataSet.ParchaseMain' table. You can move, or remove it, as needed.
            //this.parchaseMainTableAdapter.Fill(this.stockmgtDataSet.ParchaseMain);
            AllPurchase();
            AllSales();
            AllCustomers();
            TotalAmountOfPurchase();
            try
            {
                con.Open();
                cmd.CommandText = "select Purchase_ID, Grand_Total from PurchaseMain where Purchase_ID <3";
                DataTable dt = new DataTable();
                d_Adapter.Fill(dt);
                ChartPurchase.DataSource = dt;
                ChartPurchase.Series["Series1"].XValueMember = "Purchase_ID";
                ChartPurchase.Series["Series1"].YValueMembers = "Grand_Total";

                ChartPurchase.Series["Series2"].XValueMember = "Purchase_ID";
                ChartPurchase.Series["Series2"].YValueMembers = "Grand_Total";

                ChartPurchase.Series["Series3"].XValueMember = "Purchase_ID";
                ChartPurchase.Series["Series3"].YValueMembers = "Grand_Total";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            /*
            this.ChartPurchase.Series["Purchase_ID"].Points.AddXY(5,"Nasratullah Shafiq");
            this.ChartPurchase.Series["Purchase_ID"].Points.AddXY(5,"Abdullah Shafiq");
            this.ChartPurchase.Series["Purchase_ID"].Points.AddXY(6,"Aminullah Naeem");
            this.ChartPurchase.Series["Purchase_ID"].Points.AddXY(9,"Samiullah Faqeerzada");*/
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
