using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            {
                if (isValid())
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1 .mdf; Integrated Security=true"))
     
                    //ViewDataWindow_MSSQL__/_LocalDB__MSSQLLocalDB/C__USERS_BIE_DESKTOP_DATABASE_LOGINFORM_LOGINFORM_DATABASE1.MDF; Integrated Security=true"))
                    //using(SqlConnection conn = new SqlConnection(@"Data Source = ( C:\Users\Bie\Desktop\Database\LoginForm\LoginForm\Database1.mdfIntegrated Security=true")); 
                    {
                        string query = "SELECT * FROM Login WHERE Username = '" + txtUserName.Text.Trim() +
                            "' AND Password = '" + txtPassword.Text.Trim() + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                        DataTable dta = new DataTable();
                        sda.Fill(dta);
                        if(dta.Rows.Count == 1)
                        {
                            LoginForm form = new LoginForm();
                            this.Hide();
                            form.Show();
                        }
                    }
                }
            }
            private bool isValid()
            {
                if(txtUserName.Text.TrimStart() == string.Empty)
                {
                    MessageBox.Show("Enter valid user name please", "Error");
                    return false;
                } else if (txtPassword.Text.TrimStart() == string.Empty)
                {
                    MessageBox.Show("Enter valid password please", "Error");
                    return false;
                }
                return true;
            }
        }
    }
}
