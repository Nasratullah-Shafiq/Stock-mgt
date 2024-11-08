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
    public partial class Item : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-R7SN7US\\NASRATSQL; initial catalog = Stockmgt; integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter d_Adapter = new SqlDataAdapter();
        DataSet d_Set = new DataSet();
        public Item()
        {
            cmd.Connection = con;
            d_Adapter.SelectCommand = cmd;
            InitializeComponent();
        }
        void refresh_BrandID()
        {
            con.Open();
            cmd.CommandText = "select * from Brand";
            d_Adapter.Fill(d_Set, "Brand");
            cmbBrandID.DataSource = d_Set.Tables["Brand"];
            cmbBrandID.DisplayMember = "Brand_Name";
            cmbBrandID.ValueMember = "Brand_ID";
            con.Close();
        }
        void DataGrid_Item()
        {
            con.Open();
            cmd.CommandText = "select * from Viw_Item";
            if (d_Set.Tables.Contains("Item"))
                d_Set.Tables["Item"].Clear();
            d_Adapter.Fill(d_Set, "Item");
            dataGridItem.DataSource = d_Set.Tables["Item"];
            con.Close();

        }
        private void Item_Load(object sender, EventArgs e)
        {
            refresh_BrandID();
            DataGrid_Item();
            dataGridItem.Columns[6].Width = 260;
            dataGridItem.Columns[0].Width = 60;
            dataGridItem.Columns[3].Width = 60;
        }

        private void dataGridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Clear()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtColor.Text = "";
            txtModel.Text = "";
            txtCapacity.Text = "";
            txtDescription.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            String str = "insert into Item values (" + txtItemID.Text + "," + cmbBrandID.SelectedValue + ",'" + txtItemName.Text + "','" + txtColor.Text + "','" + txtModel.Text + "','" + txtCapacity.Text + "','" + txtDescription.Text + "')";
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully");
            DataGrid_Item();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            String str = "Delete from Item where Item_ID = " + txtItemID.Text + "";
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully");
            DataGrid_Item();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            String str = "update Item set Item = " + txtItemName.Text + "' where Item_ID = " + txtItemID.Text + "";
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully");
            DataGrid_Item();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from Viw_Item where Item_ID =  " + txtSearch.Text + "";
            if (d_Set.Tables.Contains("Item"))
                d_Set.Tables["Item"].Clear();
            d_Adapter.Fill(d_Set, "Item");
            dataGridItem.DataSource = d_Set.Tables["Item"];
            con.Close();
            txtSearch.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from Viw_Item";
            if (d_Set.Tables.Contains("Item"))
                d_Set.Tables["Item"].Clear();
            d_Adapter.Fill(d_Set, "Item");
            dataGridItem.DataSource = d_Set.Tables["Item"];
            con.Close();

        }
    }
}
