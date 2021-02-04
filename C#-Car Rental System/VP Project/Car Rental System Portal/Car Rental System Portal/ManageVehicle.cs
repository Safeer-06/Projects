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
using System.IO;

namespace Car_Rental_System_Portal
{
    public partial class ManageVehicle : UserControl
    {
        public void Fillcombobox()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select BrandName From tbl_brands", con);
            SqlDataReader Sdr = cmd.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cmbbrand.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();

        }
        public ManageVehicle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SKYTECH-PC\SQLEXPRESS;Initial Catalog=Car_Rental;Integrated Security=True");

        public void dataLoad()
        {
            using (SqlCommand MyCommand = new SqlCommand("SELECT * from vehicle_info", con))
            {
                MyCommand.CommandType = CommandType.Text;
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(MyCommand.ExecuteReader());
                DataBrands.DataSource = dt;
                con.Close();
            }
        }
        private void ManageVehicle_Load(object sender, EventArgs e)
        {
            dataLoad();
            Fillcombobox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string brandsname = cmbbrand.Text;

            string id = txtid.Text;
            int b = 0;
            //  brands = txtbrandsname.Text;
            string query = "UPDATE vehicle_info SET vehicle_title = '" + txttitle + "', vehicle_brand = '"+brandsname+"',vehicle_overview = '"+txtoverview+"', priceperday = '"+txtprice+"',modelyear = '"+txtModelYear+"',seatingcapacity = '"+txtCapacity+"' WHERE vehicle_id = '" + txtid + "'";
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
        
        private void DataBrands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DataBrands.Rows[index];
            txtid.Text = selectedRow.Cells[0].Value.ToString();
            txttitle.Text = selectedRow.Cells[1].Value.ToString();
            cmbbrand.SelectedItem = selectedRow.Cells[2].ToString();
            txtoverview.Text = selectedRow.Cells[3].Value.ToString();
            txtprice.Text = selectedRow.Cells[4].Value.ToString();
            txtModelYear.Text = selectedRow.Cells[5].Value.ToString();
            txtCapacity.Text = selectedRow.Cells[6].Value.ToString();


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            int b = 0;
            //  brands = txtbrandsname.Text;
            string query = "Delete from vehicle_info WHERE vehicle_id = '" + id + "'";
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
