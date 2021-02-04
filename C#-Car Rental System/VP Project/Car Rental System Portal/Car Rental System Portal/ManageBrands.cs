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
    public partial class ManageBrands : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=SKYTECH-PC\SQLEXPRESS;Initial Catalog=Car_Rental;Integrated Security=True");

        public ManageBrands()
        {
            InitializeComponent();
            dataLoad();
        }

        private void DataBrands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dataLoad()
        {
            using (SqlCommand MyCommand = new SqlCommand("SELECT * from tbl_brands", con))
            {
                MyCommand.CommandType = CommandType.Text;
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(MyCommand.ExecuteReader());
                DataBrands.DataSource = dt;
                con.Close();
            }
        }
        private void ManageBrands_Load(object sender, EventArgs e)
        {
            dataLoad();
            
         
        }


        private void DataBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DataBrands.Rows[index];
            txtid.Text = selectedRow.Cells[0].Value.ToString();
            txtbrandsName.Text = selectedRow.Cells[1].Value.ToString();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string brandsname = txtbrandsName.Text;
            string id = txtid.Text;
            int b = 0;
            //  brands = txtbrandsname.Text;
            string query = "UPDATE tbl_brands SET BrandName = '"+brandsname+"' WHERE id = '"+ id+"'";
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {

                b = command.ExecuteNonQuery();
                if (b > 0)
                {
                    MessageBox.Show("Data Update!");

                    con.Close();
                    dataLoad();

                }
                else
                {
                    MessageBox.Show("Data Not Update!");
                    con.Close();
                }
                
            }
        }

        private void txtbrandsName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelbrand_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBrandsName_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string brandsname = txtbrandsName.Text;
            string id = txtid.Text;
            int b = 0;
            //  brands = txtbrandsname.Text;
            string query = "Delete from tbl_brands WHERE id = '" + id + "'";
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {

                b = command.ExecuteNonQuery();
                if (b > 0)
                {
                    if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("Data Delete!");
                        con.Close();
                        dataLoad();
                    }
                   

                }
                else
                {
                    MessageBox.Show("Data Not Update!");
                    con.Close();
                }

            }
        }
    }
}
