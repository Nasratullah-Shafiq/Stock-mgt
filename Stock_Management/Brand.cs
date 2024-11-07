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
   
    public partial class Brand : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-R7SN7US\\NASRATSQL; initial catalog = Stockmgt; integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter d_Adapter = new SqlDataAdapter();
        DataSet d_Set = new DataSet();
        public Brand()
        {
            cmd.Connection = con;
            d_Adapter.SelectCommand = cmd;
            InitializeComponent();
        }

        void DataGrid()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Viw_Brand";
                if (d_Set.Tables.Contains("Brand"))
                    d_Set.Tables["Brand"].Clear();
                d_Adapter.Fill(d_Set, "Brand");
                dataGridBrand.DataSource = d_Set.Tables["Brand"];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //When Brand form loads it get all contents form the database inside a form
        private void Brand_Load(object sender, EventArgs e)
        {
            try
            {
                DataGrid();
                con.Open();
                cmd.CommandText = "select * from Category";
                d_Adapter.Fill(d_Set, "Category");
                cmbCategory.DataSource = d_Set.Tables["Category"];
                cmbCategory.DisplayMember = "Category";
                cmbCategory.ValueMember = "Category_ID";
                con.Close();
                dataGridBrand.Columns[3].Width = 618;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Brand where Brand_ID =  " + txtSearch.Text + "";
                if (d_Set.Tables.Contains("Brand"))
                    d_Set.Tables["Brand"].Clear();
                d_Adapter.Fill(d_Set, "Brand");
                dataGridBrand.DataSource = d_Set.Tables["Brand"];
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String str = "insert into Brand values (" + txtBrandID.Text + ",'" + txtBrandName.Text + "'," + cmbCategory.SelectedValue + ",'" + txtDescription.Text + "')";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved Successfully");
                DataGrid();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String str = "update Brand set Brand_Name = '" + txtBrandName.Text + "' where Brand_ID = " + txtBrandID.Text + "";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated Successfully");
                DataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ClearTextBox()
        {
            txtBrandName.Text = "";
            txtDescription.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String str = "Delete from Brand where Brand_ID = " + txtBrandID.Text + "";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted Successfully");
                DataGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "select isnull(MAX(Brand_ID),0)+1 from Brand";
            cmd.CommandText = str;
            txtBrandID.Text = cmd.ExecuteScalar().ToString();
            con.Close();
            ClearTextBox();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
