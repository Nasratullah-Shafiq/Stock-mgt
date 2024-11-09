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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data source =.; initial catalog = Stockmgt; integrated security = true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter d_Adapter = new SqlDataAdapter();
        DataSet d_Set = new DataSet();
        DataTable d_Table = new DataTable();
        SqlDataReader Reader;
        public Login()
        {
            cmd.Connection = con;
            d_Adapter.SelectCommand = cmd;
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp frm = new SignUp();
            frm.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from Login where Username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";

                Reader = cmd.ExecuteReader();
                int count = 0;
                while (Reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Wellcome To The Stock Management Database");
                    Brand frm = new Brand();
                    frm.Show();
                }
                
                else if (count > 1)
                {
                    MessageBox.Show("Duplicated Username and Password .... Access Denied");
                }
                else
                    MessageBox.Show("Username and Password is Not Correct");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
