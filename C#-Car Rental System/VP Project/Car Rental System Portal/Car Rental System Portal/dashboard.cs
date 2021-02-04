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
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
        }
        string strCon = "Server=localhost;Initial Catalog=SampleDB;Integrated Security=true";

        public void fill()
        {

            int i = 0;
            SqlConnection con = new SqlConnection(strCon);
            
            SqlCommand cmd = new SqlCommand("Select * from tbl_user", con);
            
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            
            rdr.Read();
            
            while (rdr.Read())
            {
                i = i + 1;
            }
            nouser.Text = i.ToString();
        }
        public int A()
        {
            string stmt = "SELECT COUNT(*) FROM tbl_user";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(@"Server=localhost;Initial Catalog=SampleDB;Integrated Security=true"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
