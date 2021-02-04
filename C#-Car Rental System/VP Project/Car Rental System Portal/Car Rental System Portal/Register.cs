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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void txtfulname_TextChanged(object sender, EventArgs e)
        {

        }
        public string constring = @"Data Source=SKYTECH-PC\SQLEXPRESS;Initial Catalog=Car_Rental;Integrated Security=True";

        private void txtfulname_Click(object sender, EventArgs e)
        {
            txtfulname.Clear();
            fullnamepanel1.BackColor = Color.FromArgb(78, 184, 206);
            txtfulname.ForeColor = Color.FromArgb(78, 184, 206);
            mobilepanel.BackColor = Color.WhiteSmoke;
            emailpanel.BackColor = Color.WhiteSmoke;
            passpanel.BackColor = Color.WhiteSmoke;
            confirmpanel.BackColor = Color.WhiteSmoke;
            txtConfirmpass.ForeColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;
            txtpass.ForeColor = Color.WhiteSmoke;
            txtmobileno.ForeColor = Color.WhiteSmoke;
           }

        private void txtmobileno_Click(object sender, EventArgs e)
        {
            txtmobileno.Clear();
            mobilepanel.BackColor = Color.FromArgb(78, 184, 206);
            txtmobileno.ForeColor = Color.FromArgb(78, 184, 206);
            fullnamepanel1.BackColor = Color.WhiteSmoke;
            emailpanel.BackColor = Color.WhiteSmoke;
            passpanel.BackColor = Color.WhiteSmoke;
            confirmpanel.BackColor = Color.WhiteSmoke;
            txtConfirmpass.ForeColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;
            txtpass.ForeColor = Color.WhiteSmoke;
            txtfulname.ForeColor = Color.WhiteSmoke;
        }

        private void txtemail_Click(object sender, EventArgs e)
        {
            txtemail.Clear();
            emailpanel.BackColor = Color.FromArgb(78, 184, 206);
            txtemail.ForeColor = Color.FromArgb(78, 184, 206);
            mobilepanel.BackColor = Color.WhiteSmoke;
            fullnamepanel1.BackColor = Color.WhiteSmoke;
            passpanel.BackColor = Color.WhiteSmoke;
            confirmpanel.BackColor = Color.WhiteSmoke;
            txtConfirmpass.ForeColor = Color.WhiteSmoke;
            txtfulname.ForeColor = Color.WhiteSmoke;
            txtpass.ForeColor = Color.WhiteSmoke;
            txtmobileno.ForeColor = Color.WhiteSmoke;
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtpass.PasswordChar = '*';
            passpanel.BackColor = Color.FromArgb(78, 184, 206);
            txtpass.ForeColor = Color.FromArgb(78, 184, 206);
            mobilepanel.BackColor = Color.WhiteSmoke;
            emailpanel.BackColor = Color.WhiteSmoke;
            fullnamepanel1.BackColor = Color.WhiteSmoke;
            confirmpanel.BackColor = Color.WhiteSmoke;
            txtConfirmpass.ForeColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;
            txtfulname.ForeColor = Color.WhiteSmoke;
            txtmobileno.ForeColor = Color.WhiteSmoke;
        }

        private void txtConfirmpass_Click(object sender, EventArgs e)
        {
            txtConfirmpass.Clear();
            txtpass.PasswordChar = '*';
            confirmpanel.BackColor = Color.FromArgb(78, 184, 206);
            txtConfirmpass.ForeColor = Color.FromArgb(78, 184, 206);
            mobilepanel.BackColor = Color.WhiteSmoke;
            emailpanel.BackColor = Color.WhiteSmoke;
            passpanel.BackColor = Color.WhiteSmoke;
            fullnamepanel1.BackColor = Color.WhiteSmoke;
            txtfulname.ForeColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;
            txtpass.ForeColor = Color.WhiteSmoke;
            txtmobileno.ForeColor = Color.WhiteSmoke;
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.Show();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(constring);
            //SqlCommand cmd;
            //con.Open();
            //if (con.State == System.Data.ConnectionState.Open)
            //{

            //    string ins = "insert into Table_2(phone,name,lastname,password) values('" + phone.Text + "','" + name.Text + "','" + lastname.Text + "','" + password.Text + "')";
            //    cmd = new SqlCommand(ins, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Registered Successfully");
            //}
            //else
            //    MessageBox.Show("Not Registered");
        }
    }
}
