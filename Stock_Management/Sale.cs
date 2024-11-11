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
    public partial class Sale : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-R7SN7US\\NASRATSQL; initial catalog = Stockmgt; integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter d_Adapter = new SqlDataAdapter();
        DataSet d_Set = new DataSet();
        SqlTransaction tr;
        String DetailID;
        public Sale()
        {
            cmd.Connection = con;
            d_Adapter.SelectCommand = cmd;
            InitializeComponent();
        }
        void ComboBoxCustomer()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Customer";
                d_Adapter.Fill(d_Set, "Customer");
                cmbCustomer.DataSource = d_Set.Tables["Customer"];
                cmbCustomer.DisplayMember = "Customer";
                cmbCustomer.ValueMember = "Customer_ID";
                con.Close();
            }
            catch (Exception)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void RefreshDataGridSaleList()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Viw_SaleMain";
                if (d_Set.Tables.Contains("SaleMain")) d_Set.Tables["SaleMain"].Clear();
                d_Adapter.Fill(d_Set, "SaleMain");
                DataGridViewSaleList.DataSource = d_Set.Tables["SaleMain"];
                con.Close();
            }
            catch (Exception)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void RefreshDataGridSaleDetails()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Viw_SaleDetails";
                if (d_Set.Tables.Contains("SaleDetails")) d_Set.Tables["SaleDetails"].Clear();
                d_Adapter.Fill(d_Set, "SaleDetails");
                DataGridViewSaleDetails.DataSource = d_Set.Tables["SaleDetails"];
                con.Close();
            }
            catch (Exception)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
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
            catch (Exception)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            ComboBoxCustomer();
            RefreshDataGridSaleDetails();
            RefreshDataGridSaleList();
            ComboBoxCategory();
            DataGridSale.Columns[4].Width = 140;
            btnSearch.Visible = false;
            txtSearch.Visible = false;
            //DataGridViewSaleList.Columns[0].Width = 50;
            //DataGridViewSaleList.Columns[1].Width = 150;
            //DataGridViewSaleList.Columns[4].Width = 60;
            //DataGridViewSaleList.Columns[5].Width = 320;
            //DataGridViewSaleDetails.Columns[6].Width = 221;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void cmbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "select Brand_ID,Brand_Name from Brand where Category_ID = " + cmbCategory.SelectedValue;
                if (d_Set.Tables.Contains("Brand"))
                    d_Set.Tables["Brand"].Clear();
                d_Adapter.Fill(d_Set, "Brand");
                cmbBrand.DataSource = d_Set.Tables["Brand"];
                cmbBrand.DisplayMember = "Brand_Name";
                cmbBrand.ValueMember = "Brand_ID";
                con.Close();

            }
            catch (Exception)
            {
  //              MessageBox.Show(ex.Message);
//                con.Close();
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
        private void TabControlSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlSale.SelectedIndex == 0)
            {
                btnSearch.Visible = false;
                txtSearch.Visible = false;
                lblSaleHeader.Text = "Sale Transaction";
            }
            if (TabControlSale.SelectedIndex == 1)
            {
                btnSearch.Visible = true;
                txtSearch.Visible = true;
                lblSaleHeader.Text = "Sale List";
            }
            if (TabControlSale.SelectedIndex == 2)
            {
                btnSearch.Visible = true;
                txtSearch.Visible = true;
                lblSaleHeader.Text = "Sale Details";
            }
        }

        private void lstItem_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int a = DataGridSale.Rows.Count;

                DataGridSale.Rows.Add();

                DataGridSale.Rows[a].Cells["DataGridID"].Value = lstItem.SelectedValue.ToString();
                DataGridSale.Rows[a].Cells["DataGridItem"].Value = lstItem.Text.ToString();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "select isnull(MAX(Sale_ID),0)+1 from SaleMain";
                cmd.CommandText = str;
                txtSaleID.Text = cmd.ExecuteScalar().ToString();

                string sttr = "select isnull(MAX(ID),0)+1 from SaleDetails";
                cmd.CommandText = sttr;
                DetailID = cmd.ExecuteScalar().ToString();
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
        void CalculateTotal()
        {
            try
            {
            int count = DataGridSale.Rows.Count;
            int i = 0;
            int sum = 0;
            for (i = 0; i < count ; i++)
                sum += Convert.ToInt32(DataGridSale.Rows[i].Cells["DataGridTotal"].Value);
            txtTotal.Text = sum.ToString();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
        }

        private void DataGridSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int a = DataGridSale.CurrentRow.Index;
            double price = Convert.ToDouble(DataGridSale.Rows[a].Cells["DataGridPrice"].Value);
            double quantity = Convert.ToDouble(DataGridSale.Rows[a].Cells["DataGridQuantity"].Value);
            DataGridSale.Rows[a].Cells["DataGridTotal"].Value = (price * quantity).ToString();
            CalculateTotal();*/
        }
        public void SaveDetails()
        {
            try
            {
                string details;
                string Item_ID, Price, Quantity, Total;
                int count = DataGridSale.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    Item_ID = DataGridSale.Rows[i].Cells["DataGridID"].Value.ToString();
                    Price = DataGridSale.Rows[i].Cells["DataGridPrice"].Value.ToString();
                    Quantity = DataGridSale.Rows[i].Cells["DataGridQuantity"].Value.ToString();
                    Total = DataGridSale.Rows[i].Cells["DataGridTotal"].Value.ToString();
                    details = "insert into SaleDetails values (" + DetailID + "," + txtSaleID.Text + ", " + Item_ID + ", " + Price + "," + Quantity + "," + Total + ",'from Details')";
                    cmd.CommandText = details;
                    cmd.ExecuteNonQuery();
                    DetailID = (Convert.ToInt16(DetailID) + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "insert into SaleMain values(" + txtSaleID.Text + ", '" + cmbCustomer.SelectedValue + "','" + dtpSaleDate.Text + "'," + txtTotal.Text + "," + 3 + ", '" + txtDescription.Text + "')";
                cmd.CommandText = str;
                con.Open();
                tr = con.BeginTransaction();
                cmd.Transaction = tr;
                cmd.ExecuteNonQuery();
                SaveDetails();
                tr.Commit();
                con.Close();
                RefreshDataGridSaleList();
                RefreshDataGridSaleDetails();
                MessageBox.Show("Data Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tr.Rollback();
            }
        }

        private void DataGridSale_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            int a = DataGridSale.CurrentRow.Index;
            double price = Convert.ToDouble(DataGridSale.Rows[a].Cells["DataGridPrice"].Value);
            double quantity = Convert.ToDouble(DataGridSale.Rows[a].Cells["DataGridQuantity"].Value);
            DataGridSale.Rows[a].Cells["DataGridTotal"].Value = (price * quantity).ToString();
            CalculateTotal();
        }

        private void lstItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


