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
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-R7SN7US\\NASRATSQL; initial catalog = Stockmgt; integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter d_Adapter = new SqlDataAdapter();
        DataSet d_Set = new DataSet();
        public SignUp()
        {
            cmd.Connection = con;
            d_Adapter.SelectCommand = cmd;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            con.Open();
            String str = "insert into Login values ("+ txtID.Text+",'"+ txtUsername.Text +"','"+ txtPassword.Text +"','"+ txtName.Text +"','"+ txtEmail.Text +"','"+txtContact.Text +"', '"+ txtAddress.Text +"','"+ txtDescription.Text +"')";
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sign Up Successfully");
            this.Dispose();
            Login frm = new Login();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Dispose();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
