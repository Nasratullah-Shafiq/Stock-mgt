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
using System.IO;

namespace Stock_Management
{

    public partial class Customer : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-R7SN7US\\NASRATSQL; initial catalog = stockmgt; integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter d_Adapter = new SqlDataAdapter();
        DataSet d_Set = new DataSet();
        public Customer()
        {
            cmd.Connection = con;
            d_Adapter.SelectCommand = cmd;
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        void ClearTextBox()
        {
            txtAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            pictureBoxCustomer.Image = null;
        }
        void DataGrid_Customer_Load()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Customer";
                if (d_Set.Tables.Contains("Customer")) d_Set.Tables["Customer"].Clear();
                d_Adapter.Fill(d_Set, "Customer");
                dataGridViewCustomer.DataSource = d_Set.Tables["Customer"];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            DataGrid_Customer_Load();
            dataGridViewCustomer.Columns[4].Width = 250;
            dataGridViewCustomer.Columns[2].Width = 100;
            dataGridViewCustomer.Columns[1].Width = 150;
        }

    

    private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "select isnull(MAX(Customer_ID),0)+1 from Customer";
                cmd.CommandText = str;
                txtCustomerID.Text = cmd.ExecuteScalar().ToString();
                con.Close();
                ClearTextBox();
            }
            catch (Exception) { }
            
        }

        private void pictureBoxCustomer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxCustomer_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpg files|*.jpg|jpeg files|*.jpeg|Gif files|*.gif|Png files|*.png";
            ofd.ShowDialog();
                pictureBoxCustomer.ImageLocation = ofd.FileName;
        }
        private byte[]ImageToBytes(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = @"INSERT INTO[dbo].[Customer]
           ([Customer_ID]
           ,[Customer]
           ,[Contact]
           ,[Address]
           ,[E-mail]
           ,[Image])
     VALUES
           (" + txtCustomerID.Text + ",'" + txtName.Text + "'," + txtContact.Text + ",'" + txtAddress.Text + "','" + txtEmail.Text + "',@img)";
                SqlParameter para = new SqlParameter();
                byte[] img = ImageToBytes(pictureBoxCustomer.Image);
                para.Value = img;
                para.ParameterName = "@img";
                para.SqlDbType = SqlDbType.Image;
                cmd.Parameters.Add(para);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information", "Record Saved Succesfully",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            catch(Exception )
            {
             
            }
            finally
            {
                DataGrid_Customer_Load();
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "delete from Customer where Customer_ID = " + txtCustomerID.Text + "";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception) { }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                cmd.CommandText = "select * from Customer where Customer_ID = " + txtSearch.Text + "";
                if (d_Set.Tables.Contains("Customer")) d_Set.Tables["Customer"].Clear();
                d_Adapter.Fill(d_Set, "Customer");
                dataGridViewCustomer.DataSource = d_Set.Tables["Customer"];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
