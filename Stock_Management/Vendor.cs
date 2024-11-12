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
    public partial class Vendor : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-R7SN7US\\NASRATSQL; initial catalog = stockmgt; integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter d_Adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public Vendor()
        {
            cmd.Connection = con;
            d_Adapter.SelectCommand = cmd;
            InitializeComponent();
        }

        void clearText()
        {
            txtVendorName.Text = "";
            txtCompany.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtDescription.Text = "";
        }
        void RefreshDataGVVendor()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Vendor ";
                if (ds.Tables.Contains("Vendor")) ds.Tables["Vendor"].Clear();
                d_Adapter.Fill(ds, "Vendor");
                dataGridViewVendor.DataSource = ds.Tables["Vendor"];
                con.Close();
                dataGridViewVendor.Columns[6].Width = 250;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            RefreshDataGVVendor();
            lblVendorHeader.Size = new Size(150, 32);
            lblVendorHeader.Location = new Point(41, 27);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "insert into Vendor values(" + txtVendorID.Text + ", '" + txtVendorName.Text + "', '" + txtCompany.Text + "', " + txtContact.Text + ", '" + txtAddress.Text + "', '" + txtEmail.Text + "', '" + txtDescription.Text + "')";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved successfully");
                RefreshDataGVVendor();
            }
            catch(Exception )
            {
                MessageBox.Show("Please Fill out all field");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "select isnull(MAX(Vendor_ID),0)+1 from Vendor";
            cmd.CommandText = str;
            txtVendorID.Text = cmd.ExecuteScalar().ToString();
            con.Close();
            clearText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "delete from Vendor where Vendor_ID=" + txtVendorID.Text + "";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                con.Close();
                RefreshDataGVVendor();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Data Deleted Successfully");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                    con.Open();
                    cmd.CommandText = "select * from Vendor where Vendor_ID = " + txtSearch.Text + "";
                    if (ds.Tables.Contains("Vendor")) ds.Tables["Vendor"].Clear();
                    d_Adapter.Fill(ds, "Vendor");
                    dataGridViewVendor.DataSource = ds.Tables["Vendor"];
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String str = "update Vendor set Name = '" + txtVendorName.Text + "',Company ='" + txtCompany.Text + "' where Vendor_ID = " + txtVendorID.Text + "";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated Successfully");
                RefreshDataGVVendor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
