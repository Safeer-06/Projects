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
    public partial class Manageboking : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=SKYTECH-PC\SQLEXPRESS;Initial Catalog=Car_Rental;Integrated Security=True");
       
        public Manageboking()
        {
            InitializeComponent();
            dashboard1.Hide();
            panel1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            dashboard1.Show();
            dashboard1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dashboard1.Hide();
            panel1.Show();

        }
        public void dataLoad()
        {
            using (SqlCommand MyCommand = new SqlCommand("SELECT * from carbook", con))
            {
                MyCommand.CommandType = CommandType.Text;
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(MyCommand.ExecuteReader());
                bookinggridview.DataSource = dt;
                con.Close();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bookinggridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = bookinggridview.Rows[index];
            txtid.Text = selectedRow.Cells[0].Value.ToString();
            custidbox.Text = selectedRow.Cells[1].Value.ToString();
            custnamebox.Text = selectedRow.Cells[2].Value.ToString();
            addbox.Text = selectedRow.Cells[3].Value.ToString();
            cnicbox.Text = selectedRow.Cells[4].Value.ToString();
            emailbx.Text = selectedRow.Cells[5].Value.ToString();
            carnamebx.Text = selectedRow.Cells[6].Value.ToString();
            carbrandbox.Text = selectedRow.Cells[7].Value.ToString();
            driverbox.Text = selectedRow.Cells[8].Value.ToString();
            ACbox.Text = selectedRow.Cells[9].Value.ToString();
            audiobx.Text = selectedRow.Cells[10].Value.ToString();
            tpbox.Text = selectedRow.Cells[11].Value.ToString();
            datetimebx.Text = selectedRow.Cells[12].Value.ToString();
            noofdaysbx.Text = selectedRow.Cells[13].Value.ToString();
            carmodelbx.Text = selectedRow.Cells[14].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookid, custid, totalprice, noofdays, carmodel;
            string custname,address, cnic, email, carname, carbrand, driver, ac, audio, datetime;
            custname = custnamebox.Text;
            address = addbox.Text;
            cnic = cnicbox.Text;
            email = emailbx.Text;
            carname = carnamebx.Text;
            carbrand = carbrandbox.Text;
            driver =driverbox.Text;
            ac = ACbox.Text;
            audio = audiobx.Text;
            datetime = datetimebx.Text;
            //string brandsname = txtbrandsName.Text;
            bookid = Convert.ToInt32(txtid.Text);
            custid = Convert.ToInt32(custidbox.Text);
            totalprice = Convert.ToInt32(tpbox.Text);
            noofdays = Convert.ToInt32(noofdaysbx.Text);
            carmodel = Convert.ToInt32(carmodelbx.Text);
            int b = 0;
            //  brands = txtbrandsname.Text;
            string query = "UPDATE carbook SET customerid = '" + custid + "',cust_name = '" + custname + "',cust_address = '" + address + "',cust_cnic = '" + cnic + "',cust_email = '" + email + "',car_name = '" + carname + "',car_brand = '" + carbrand + "',driver = '" + driver + "',ac = '" + ac + "',audio = '" + audio + "',totalprice = '" + totalprice + "',datetime = '" + datetime + "',numOfdays = '" + noofdays + "',car_model = '" + carmodel + "' WHERE booking_id = '" + bookid + "'";
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {

                b = command.ExecuteNonQuery();
                if (b > 0)
                {
                    MessageBox.Show("Data Updated!");

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            //string brandsname = txtbrandsName.Text;
            int id = Convert.ToInt32(txtid.Text);
            int b = 0;
            //  brands = txtbrandsname.Text;
            string query = "Delete from carbook WHERE booking_id = '" + id + "'";
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {

                b = command.ExecuteNonQuery();
                if (b > 0)
                {
                    if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("Data Deleted!");
                        con.Close();
                        dataLoad();
                    }


                }
                else
                {
                    MessageBox.Show("Data Not Deleted!");
                    con.Close();
                }
            }
        }

        private void Manageboking_Load(object sender, EventArgs e)
        {
            dataLoad();
        }
    }
}
