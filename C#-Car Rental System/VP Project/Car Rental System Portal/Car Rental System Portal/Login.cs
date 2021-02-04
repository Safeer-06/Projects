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

namespace Car_Rental_System_Portal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Register register = new Register();
        private void txtUname_Click(object sender, EventArgs e)
        {
            txtemail.Clear();
            unamepanel1.BackColor = Color.FromArgb(78, 184, 206);
            txtemail.ForeColor = Color.FromArgb(78, 184, 206);
            passpanel2.BackColor = Color.WhiteSmoke;
            txtpassword.ForeColor = Color.WhiteSmoke;
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtpassword.PasswordChar = '*';
            passpanel2.BackColor = Color.FromArgb(78, 184, 206);
            txtpassword.ForeColor = Color.FromArgb(78, 184, 206);
            unamepanel1.BackColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;

        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtemail.Text=="")
            {
               

            }
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3DdB1SS\SQLEXPRESS;Initial Catalog=Car_Rental;Integrated Security=True");
            SqlDataAdapter adap =new SqlDataAdapter("select * from admin where UserName='"+txtemail.Text+ "' and Password='"+txtpassword.Text+"'",con);

            con.Open();
            string userid = txtemail.Text;
            string password = txtpassword.Text;
            SqlCommand cmd = new SqlCommand("select UserName,Password from admin where UserName='" + txtemail.Text + "'and Password='" + txtpassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess");

                 }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();

        }

       
        private void btnregister_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            register.Show();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
