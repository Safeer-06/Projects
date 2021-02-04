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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3DDB1SS\SQLEXPRESS;Initial Catalog=Car_Rental;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }
        void Fillcombobox()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Fillcombobox();
        }
    }
}
