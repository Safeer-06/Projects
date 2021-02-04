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
    public partial class brands : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=SKYTECH-PC\SQLEXPRESS;Initial Catalog=Car_Rental;Integrated Security=True");

        public brands()
        {
            InitializeComponent();
            
                
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string brands;
            brands = txtbrandsname.Text;
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3DDB1SS\SQLEXPRESS;Initial Catalog=Car_Rental;Integrated Security=True");
            SqlCommand cmd;

            //if (con.State == System.Data.ConnectionState.Open)
            //{

            //    string ins = "insert into tbl_brands(BrandName) values('" + brands + "')";
            //    cmd = new SqlCommand(ins, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Data Saved");
            //}
            //else
            //    MessageBox.Show("Data not Saved");

            //string brands;
            //string date = DateTime.Now.ToString("dd / MM / yyyy");
            ManageBrands manage = new ManageBrands();
              int b = 0;
            //  brands = txtbrandsname.Text;
            string query = "Insert into tbl_brands(BrandName) Values('" + brands + "')";
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {

                b = command.ExecuteNonQuery();
                if (b > 0)
                {
                    MessageBox.Show("Data Saved!");
                    manage.dataLoad();
                }
                else
                {
                    MessageBox.Show("Data Not Saved!");
                }
                con.Close();
            }
        }

        private void brands_Load(object sender, EventArgs e)
        {

        }
    }
}

