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
    public partial class Purchase : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-R7SN7US\\NASRATSQL; initial catalog = Stockmgt; integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter d_Adapter = new SqlDataAdapter();
        DataSet d_Set = new DataSet();
        SqlTransaction tr;
        String DetailID;
        Main_Page frm = new Main_Page();
        public Purchase()
        {
            cmd.Connection = con;
            d_Adapter.SelectCommand = cmd;
            InitializeComponent();
        }
         void ComboBoxCategory()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Category";
                d_Adapter.Fill(d_Set, "Category");
                cmbCategory.DataSource = d_Set.Tables["Category"];
                cmbCategory.DisplayMember = "Category";
                cmbCategory.ValueMember = "Category_ID";
                con.Close();
            }
            catch(Exception )
            {
              //  MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void ComboBoxVendor()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Vendor";
                d_Adapter.Fill(d_Set, "Vendor");
                cmbVendor.DataSource = d_Set.Tables["Vendor"];
                cmbVendor.DisplayMember = "Vendor";
                cmbVendor.ValueMember = "Vendor_ID";
                con.Close();
            }
            catch(Exception )
            {
             //   MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void RefreshDataGridPurchaseList()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Viw_PurchaseMain";
                if (d_Set.Tables.Contains("PurchaseMain")) d_Set.Tables["PurchaseMain"].Clear();
                d_Adapter.Fill(d_Set, "PurchaseMain");
                DataGridViewPurchaseList.DataSource = d_Set.Tables["PurchaseMain"];
                con.Close();
                DataGridViewPurchaseList.Columns[5].Width = 400;
                DataGridViewPurchaseList.Columns[2].Width = 200;
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
        void RefreshDataGridPurchaseDetails()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Viw_PurchaseDetails";
                if (d_Set.Tables.Contains("PurchaseDetails")) d_Set.Tables["PurchaseDetails"].Clear();
                d_Adapter.Fill(d_Set, "PurchaseDetails");
                DataGridViewPurchaseDetails.DataSource = d_Set.Tables["PurchaseDetails"];
                con.Close();
                DataGridViewPurchaseDetails.Columns[6].Width = 400;

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

        private void Parchase_Load(object sender, EventArgs e)
        {
            ComboBoxCategory();
            ComboBoxVendor();
            DataGridPurchase.Columns[4].Width = 240;
            RefreshDataGridPurchaseList();
            RefreshDataGridPurchaseDetails();
            btnSearch.Visible = false;
            txtSearch.Visible = false;

        }

        private void cmbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                con.Open();
                cmd.CommandText = "select Brand_ID,Brand_Name from Brand where Category_ID = "+ cmbCategory.SelectedValue;
                if (d_Set.Tables.Contains("Brand"))
                d_Set.Tables["Brand"].Clear();
                d_Adapter.Fill(d_Set, "Brand");
                cmbBrand.DataSource = d_Set.Tables["Brand"];
                cmbBrand.DisplayMember = "Brand_Name";
                cmbBrand.ValueMember = "Brand_ID";
                con.Close();

            }
            catch(Exception )
            {
                //MessageBox.Show(ex.Message);
                //con.Close();
            }
            finally
            {
                con.Close();
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Item where Brand_ID = " + cmbBrand.SelectedValue;
                if (d_Set.Tables.Contains("Item"))
                    d_Set.Tables["Item"].Clear();
                d_Adapter.Fill(d_Set, "Item");
                lstItem.DataSource = d_Set.Tables["Item"];
                lstItem.DisplayMember = "Item";
                lstItem.ValueMember = "Item_ID";
                con.Close();
            }
            catch (Exception)
            {
               // MessageBox.Show(ex.Message);
               // con.Close();
            }
            finally
            {
                con.Close();
            }
        }

        private void lstItem_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int a = DataGridPurchase.Rows.Count;

                DataGridPurchase.Rows.Add();

                DataGridPurchase.Rows[a].Cells["DataGridItemId"].Value = lstItem.SelectedValue.ToString();
                DataGridPurchase.Rows[a].Cells["DataGridItem"].Value = lstItem.Text.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void CalculateTotal()
        {
            try
            {
                int count = DataGridPurchase.Rows.Count;
                int i = 0;
                int sum = 0;
                for (i = 0; i < count; i++)
                    sum += Convert.ToInt32(DataGridPurchase.Rows[i].Cells["DataGridTotal"].Value);
                txtTotal.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridBrand_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = DataGridPurchase.CurrentRow.Index;
                double price = Convert.ToDouble(DataGridPurchase.Rows[a].Cells["DataGridPrice"].Value);
                double quantity = Convert.ToDouble(DataGridPurchase.Rows[a].Cells["DataGridQuantity"].Value);
                DataGridPurchase.Rows[a].Cells["DataGridTotal"].Value = (price * quantity).ToString();
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "select isnull(MAX(Purchase_ID),0)+1 from PurchaseMain";
                cmd.CommandText = str;
                txtPurchaseID.Text = cmd.ExecuteScalar().ToString();

                string sttr = "select isnull(MAX(ID),0)+1 from PurchaseDetails";
                cmd.CommandText = sttr;
                DetailID = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
             //   con.Close();
            //}
        }
        public void SaveDetails()
        {
            try
            {
                string details;
                string Item_ID, Price, Quantity, Total;
                int count = DataGridPurchase.Rows.Count;
                for (int i = 0; i < count-1; i++)
                {
                    Item_ID = DataGridPurchase.Rows[i].Cells["DataGridItemID"].Value.ToString();
                    Price = DataGridPurchase.Rows[i].Cells["DataGridPrice"].Value.ToString();
                    Quantity = DataGridPurchase.Rows[i].Cells["DataGridQuantity"].Value.ToString();
                    Total = DataGridPurchase.Rows[i].Cells["DataGridTotal"].Value.ToString();
                    details = "insert into PurchaseDetails values (" + DetailID + "," + txtPurchaseID.Text + ", " + Item_ID + ", " + Price + "," + Quantity + "," + Total + ",'from Details')";
                    cmd.CommandText = details;
                    cmd.ExecuteNonQuery();
                   DetailID =(Convert.ToInt16(DetailID) +1).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            //finally
            //{
            //    con.Close();
            //}
        }
        public void TotalAmountOfPurchase()
        {
            try
            {
                con.Open();
                string str = "select isnull(Sum(Grand_Total),0) from PurchaseMain";
                cmd.CommandText = str;
                frm.lblTotalPurchase.Text = cmd.ExecuteScalar().ToString() + " $";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "insert into PurchaseMain values(" + txtPurchaseID.Text + ", '" + cmbVendor.SelectedValue + "','" + dtpPurchase.Text + "'," + txtTotal.Text + ","+ 2 + ", '" + txtDescription.Text + "')";
                cmd.CommandText = str;
                con.Open();
               tr = con.BeginTransaction();
                cmd.Transaction = tr;
                cmd.ExecuteNonQuery();
                SaveDetails();
                tr.Commit();
                con.Close();
                
                MessageBox.Show("Data Saved Successfully");
                RefreshDataGridPurchaseList();
                RefreshDataGridPurchaseDetails();
                frm.AllCustomers();
                frm.TotalAmountOfPurchase();
                frm.AllPurchase();
                frm.AllSales();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                tr.Rollback();
            }
            //finally
            //{
             //   con.Close();
           // }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TabControlPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlPurchase.SelectedIndex == 0)
            {
                btnSearch.Visible = false;
                txtSearch.Visible = false;
                lblPurchaseHeader.Text = "Purchase Transaction";
            }
            if (TabControlPurchase.SelectedIndex == 1)
            {
                btnSearch.Visible = true;
                txtSearch.Visible = true;
                lblPurchaseHeader.Text = "Purchase List";
            }
            if (TabControlPurchase.SelectedIndex == 2)
            {
                btnSearch.Visible = true;
                txtSearch.Visible = true;
                lblPurchaseHeader.Text = "Purchase Details";
            }
        }

        private void cmbVendor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewPurchaseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
