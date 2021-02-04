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
    public partial class PostVehicle : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=SKYTECH-PC\SQLEXPRESS;Initial Catalog=Car_Rental;Integrated Security=True");

        public void Fillcombobox()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select BrandName From tbl_brands", con);
            SqlDataReader Sdr = cmd.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cmbrand.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();

        }
        public PostVehicle()
        {
            InitializeComponent();
            Fillcombobox();
           
        }

        private void PostVehicle_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string vehicleTitle;
            vehicleTitle = txtvehicle.Text;
            string vehiclebrand = cmbrand.Text;
            string vehicleOverview = txtoverview.Text;
            string price = txtprice.Text;
            string model = txtmodel.Text;
            string seatingcapaty = txtcapacity.Text;
            
             SqlCommand cmd;

          
            ManageBrands manage = new ManageBrands();
            int b = 0;
            //  brands = txtbrandsname.Text;
            string query = "Insert into vehicle_info(vehicle_title,vehicle_brand,vehicle_overview,priceperday,modelyear,seatingcapacity) Values('" + vehicleTitle + "', '" + vehiclebrand+"' , '"+vehicleOverview+"','"+price+"','"+model+"','"+seatingcapaty+ "')";
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtbrowse.Text = Path.GetFileName(openFileDialog1.FileName);
                pic.ImageLocation = String.Format(Path.GetFullPath(openFileDialog1.FileName));
            }
        }

        private void panelfield_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
