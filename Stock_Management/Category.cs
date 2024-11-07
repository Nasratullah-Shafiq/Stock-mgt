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
    
    public partial class Category : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-R7SN7US\\NASRATSQL; initial catalog = Stockmgt; integrated security = true;");
        SqlDataAdapter d_Adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet d_Set = new DataSet(); 
        public Category()
        {
            cmd.Connection = con;
            d_Adapter.SelectCommand = cmd;
            InitializeComponent();
        }
        void refreshCategory()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Category order by Category_ID desc";
                if (d_Set.Tables.Contains("Category")) d_Set.Tables["Category"].Clear();
                d_Adapter.Fill(d_Set, "Category");
                dataGridViewCategory.DataSource = d_Set.Tables["Category"];
                con.Close();
                dataGridViewCategory.Columns[2].Width = 250;
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
        void ClearTextBox()
        {
           // txtCatagoryID.Text = "";
            txtCategory.Text = "";
            txtDescription.Text = "";
        }

        private void Catagory_Load(object sender, EventArgs e)
        {
            refreshCategory();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "insert into Category values (" + txtCategoryID.Text + ",'" + txtCategory.Text + "','" + txtDescription + "')";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved Successfully");
                refreshCategory();
            }
            catch (Exception) { }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "delete from Catagory where Category_ID = " + txtCategoryID.Text + "";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted Successfully");
                refreshCategory();
                
            }
            catch (Exception )
            {
                MessageBox.Show("Please Enter An ID To Delete ");
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
                string str = "select isnull(MAX(Category_ID),0)+1 from Category";
                cmd.CommandText = str;
                txtCategoryID.Text = cmd.ExecuteScalar().ToString();
                con.Close();
                ClearTextBox();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Category where Category_ID = " + txtSearch.Text; 
                if (d_Set.Tables.Contains("Category")) d_Set.Tables["Category"].Clear();
                d_Adapter.Fill(d_Set, "Category");
                dataGridViewCategory.DataSource = d_Set.Tables["Category"];
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "update Category set Category = '" + txtCategory.Text + "' where Category_ID = " + txtCategoryID.Text + "";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated Successfully");
                refreshCategory();
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
    }
}
