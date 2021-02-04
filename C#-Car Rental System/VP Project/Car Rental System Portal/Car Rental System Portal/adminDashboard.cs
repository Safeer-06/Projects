using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System_Portal
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
            SlidePanel.Height = btndashboard.Height;
            brandspanel.Hide();
            dashboard1.BringToFront();

            vehiclepanel.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btndashboard.Height;
            SlidePanel.Top = btndashboard.Top;
             dashboard1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnManageBooking.Height;
            SlidePanel.Top = btnManageBooking.Top;
            //manageboking1.BringToFront();
        }

        private void manageboking1_Load(object sender, EventArgs e)
        {

        }
        

   
     
       
        private void btnbrands_MouseHover_1(object sender, EventArgs e)
        {
           
            
        }

     
        private void btnbrands_Click(object sender, EventArgs e)
        {
            
        }

        private void btncreatebrands_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnbrands.Height;
            SlidePanel.Top = btnbrands.Top;
            brands1.BringToFront();
        }

        private void btnmanagebrands_Click(object sender, EventArgs e)
        {
            
            SlidePanel.Height = btnbrands.Height;
            SlidePanel.Top = btnbrands.Top;
            manageBrands1.BringToFront();
            manageBrands1.dataLoad();
            postVehicle1.Fillcombobox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnVehicle.Height;
            SlidePanel.Top = btnVehicle.Top;
            postVehicle1.BringToFront();
            manageVehicle1.dataLoad();
        }

        private void btnVehicle_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManageVehicle_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnVehicle.Height;
            SlidePanel.Top = btnVehicle.Top;
            manageVehicle1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            vehiclepanel.Hide();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            vehiclepanel.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            brandspanel.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            brandspanel.Show();
        }

        private void btnRegUser_Click(object sender, EventArgs e)
        {

            SlidePanel.Height = btnRegUser.Height;
            SlidePanel.Top = btnRegUser.Top;
            regUser1.BringToFront();
        }
    }
}
