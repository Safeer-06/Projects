using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_System_Portal
{
    public partial class RegUser : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=SKYTECH-PC\SQLEXPRESS;Initial Catalog=Car_Rental;Integrated Security=True");

        public RegUser()
        {
            InitializeComponent();
        }
        public void dataLoad()
        {
            using (SqlCommand MyCommand = new SqlCommand("SELECT * from tbl_user", con))
            {
                MyCommand.CommandType = CommandType.Text;
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(MyCommand.ExecuteReader());
                DataBrands.DataSource = dt;
                con.Close();
            }
        }
        private void RegUser_Load(object sender, EventArgs e)
        {
            dataLoad();
        }
    }
}
