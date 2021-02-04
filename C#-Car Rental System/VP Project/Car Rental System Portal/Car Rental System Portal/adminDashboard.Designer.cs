namespace Car_Rental_System_Portal
{
    partial class adminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vehiclepanel = new System.Windows.Forms.Panel();
            this.btnManageVehicle = new System.Windows.Forms.Button();
            this.btnPostVehicle = new System.Windows.Forms.Button();
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.btnbrands = new System.Windows.Forms.Button();
            this.btnUpdateContactInfo = new System.Windows.Forms.Button();
            this.brandspanel = new System.Windows.Forms.Panel();
            this.btnmanagebrands = new System.Windows.Forms.Button();
            this.btncreatebrands = new System.Windows.Forms.Button();
            this.btnRegUser = new System.Windows.Forms.Button();
            this.btnManageBooking = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.lblmain = new System.Windows.Forms.Label();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.manageVehicle1 = new Car_Rental_System_Portal.ManageVehicle();
            this.postVehicle1 = new Car_Rental_System_Portal.PostVehicle();
            this.manageBrands1 = new Car_Rental_System_Portal.ManageBrands();
            this.brands1 = new Car_Rental_System_Portal.brands();
            this.dashboard1 = new Car_Rental_System_Portal.dashboard();
            this.regUser1 = new Car_Rental_System_Portal.RegUser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.vehiclepanel.SuspendLayout();
            this.brandspanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.vehiclepanel);
            this.panel1.Controls.Add(this.SlidePanel);
            this.panel1.Controls.Add(this.btnbrands);
            this.panel1.Controls.Add(this.btnUpdateContactInfo);
            this.panel1.Controls.Add(this.brandspanel);
            this.panel1.Controls.Add(this.btnRegUser);
            this.panel1.Controls.Add(this.btnManageBooking);
            this.panel1.Controls.Add(this.btnVehicle);
            this.panel1.Controls.Add(this.lblmain);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 679);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(203, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 28);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 28);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // vehiclepanel
            // 
            this.vehiclepanel.BackColor = System.Drawing.Color.Black;
            this.vehiclepanel.Controls.Add(this.btnManageVehicle);
            this.vehiclepanel.Controls.Add(this.btnPostVehicle);
            this.vehiclepanel.Location = new System.Drawing.Point(3, 284);
            this.vehiclepanel.Name = "vehiclepanel";
            this.vehiclepanel.Size = new System.Drawing.Size(261, 128);
            this.vehiclepanel.TabIndex = 6;
            // 
            // btnManageVehicle
            // 
            this.btnManageVehicle.FlatAppearance.BorderSize = 0;
            this.btnManageVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageVehicle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageVehicle.ForeColor = System.Drawing.Color.White;
            this.btnManageVehicle.Location = new System.Drawing.Point(0, 66);
            this.btnManageVehicle.Name = "btnManageVehicle";
            this.btnManageVehicle.Size = new System.Drawing.Size(264, 54);
            this.btnManageVehicle.TabIndex = 5;
            this.btnManageVehicle.Text = "Manage Vehicle";
            this.btnManageVehicle.UseVisualStyleBackColor = true;
            this.btnManageVehicle.Click += new System.EventHandler(this.btnManageVehicle_Click);
            // 
            // btnPostVehicle
            // 
            this.btnPostVehicle.FlatAppearance.BorderSize = 0;
            this.btnPostVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostVehicle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostVehicle.ForeColor = System.Drawing.Color.White;
            this.btnPostVehicle.Location = new System.Drawing.Point(0, 3);
            this.btnPostVehicle.Name = "btnPostVehicle";
            this.btnPostVehicle.Size = new System.Drawing.Size(261, 54);
            this.btnPostVehicle.TabIndex = 4;
            this.btnPostVehicle.Text = "Post A Vehicle";
            this.btnPostVehicle.UseVisualStyleBackColor = true;
            this.btnPostVehicle.Click += new System.EventHandler(this.button2_Click);
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SlidePanel.Location = new System.Drawing.Point(0, 103);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(10, 57);
            this.SlidePanel.TabIndex = 2;
            // 
            // btnbrands
            // 
            this.btnbrands.FlatAppearance.BorderSize = 0;
            this.btnbrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrands.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrands.ForeColor = System.Drawing.Color.White;
            this.btnbrands.Location = new System.Drawing.Point(0, 166);
            this.btnbrands.Name = "btnbrands";
            this.btnbrands.Size = new System.Drawing.Size(264, 57);
            this.btnbrands.TabIndex = 3;
            this.btnbrands.Text = "Brands";
            this.btnbrands.UseVisualStyleBackColor = true;
            this.btnbrands.Click += new System.EventHandler(this.btnbrands_Click);
            this.btnbrands.MouseHover += new System.EventHandler(this.btnbrands_MouseHover_1);
            // 
            // btnUpdateContactInfo
            // 
            this.btnUpdateContactInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateContactInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateContactInfo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateContactInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateContactInfo.Location = new System.Drawing.Point(0, 418);
            this.btnUpdateContactInfo.Name = "btnUpdateContactInfo";
            this.btnUpdateContactInfo.Size = new System.Drawing.Size(264, 57);
            this.btnUpdateContactInfo.TabIndex = 7;
            this.btnUpdateContactInfo.Text = "Update Contact Info";
            this.btnUpdateContactInfo.UseVisualStyleBackColor = true;
            // 
            // brandspanel
            // 
            this.brandspanel.BackColor = System.Drawing.Color.Black;
            this.brandspanel.Controls.Add(this.btnmanagebrands);
            this.brandspanel.Controls.Add(this.btncreatebrands);
            this.brandspanel.Location = new System.Drawing.Point(1, 225);
            this.brandspanel.Name = "brandspanel";
            this.brandspanel.Size = new System.Drawing.Size(266, 127);
            this.brandspanel.TabIndex = 2;
            // 
            // btnmanagebrands
            // 
            this.btnmanagebrands.FlatAppearance.BorderSize = 0;
            this.btnmanagebrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmanagebrands.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagebrands.ForeColor = System.Drawing.Color.White;
            this.btnmanagebrands.Location = new System.Drawing.Point(0, 66);
            this.btnmanagebrands.Name = "btnmanagebrands";
            this.btnmanagebrands.Size = new System.Drawing.Size(264, 45);
            this.btnmanagebrands.TabIndex = 5;
            this.btnmanagebrands.Text = "Manage";
            this.btnmanagebrands.UseVisualStyleBackColor = true;
            this.btnmanagebrands.Click += new System.EventHandler(this.btnmanagebrands_Click);
            // 
            // btncreatebrands
            // 
            this.btncreatebrands.FlatAppearance.BorderSize = 0;
            this.btncreatebrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreatebrands.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatebrands.ForeColor = System.Drawing.Color.White;
            this.btncreatebrands.Location = new System.Drawing.Point(0, 21);
            this.btncreatebrands.Name = "btncreatebrands";
            this.btncreatebrands.Size = new System.Drawing.Size(261, 39);
            this.btncreatebrands.TabIndex = 4;
            this.btncreatebrands.Text = "Create";
            this.btncreatebrands.UseVisualStyleBackColor = true;
            this.btncreatebrands.Click += new System.EventHandler(this.btncreatebrands_Click);
            // 
            // btnRegUser
            // 
            this.btnRegUser.FlatAppearance.BorderSize = 0;
            this.btnRegUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegUser.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegUser.ForeColor = System.Drawing.Color.White;
            this.btnRegUser.Location = new System.Drawing.Point(0, 355);
            this.btnRegUser.Name = "btnRegUser";
            this.btnRegUser.Size = new System.Drawing.Size(264, 57);
            this.btnRegUser.TabIndex = 6;
            this.btnRegUser.Text = "Reg User";
            this.btnRegUser.UseVisualStyleBackColor = true;
            this.btnRegUser.Click += new System.EventHandler(this.btnRegUser_Click);
            // 
            // btnManageBooking
            // 
            this.btnManageBooking.FlatAppearance.BorderSize = 0;
            this.btnManageBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBooking.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBooking.ForeColor = System.Drawing.Color.White;
            this.btnManageBooking.Location = new System.Drawing.Point(0, 292);
            this.btnManageBooking.Name = "btnManageBooking";
            this.btnManageBooking.Size = new System.Drawing.Size(264, 57);
            this.btnManageBooking.TabIndex = 5;
            this.btnManageBooking.Text = "Manage Booking";
            this.btnManageBooking.UseVisualStyleBackColor = true;
            this.btnManageBooking.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.FlatAppearance.BorderSize = 0;
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.ForeColor = System.Drawing.Color.White;
            this.btnVehicle.Location = new System.Drawing.Point(0, 229);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(264, 57);
            this.btnVehicle.TabIndex = 4;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            this.btnVehicle.MouseHover += new System.EventHandler(this.btnVehicle_MouseHover);
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.Color.Gray;
            this.lblmain.Location = new System.Drawing.Point(3, 80);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(47, 20);
            this.lblmain.TabIndex = 3;
            this.lblmain.Text = "Main";
            // 
            // btndashboard
            // 
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(0, 103);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(264, 57);
            this.btndashboard.TabIndex = 2;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 77);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental Portal|Admin ";
            // 
            // manageVehicle1
            // 
            this.manageVehicle1.BackColor = System.Drawing.Color.White;
            this.manageVehicle1.Location = new System.Drawing.Point(264, 78);
            this.manageVehicle1.Name = "manageVehicle1";
            this.manageVehicle1.Size = new System.Drawing.Size(1067, 597);
            this.manageVehicle1.TabIndex = 7;
            // 
            // postVehicle1
            // 
            this.postVehicle1.BackColor = System.Drawing.Color.White;
            this.postVehicle1.Location = new System.Drawing.Point(261, 78);
            this.postVehicle1.Name = "postVehicle1";
            this.postVehicle1.Size = new System.Drawing.Size(1067, 597);
            this.postVehicle1.TabIndex = 6;
            // 
            // manageBrands1
            // 
            this.manageBrands1.BackColor = System.Drawing.Color.White;
            this.manageBrands1.Location = new System.Drawing.Point(261, 78);
            this.manageBrands1.Name = "manageBrands1";
            this.manageBrands1.Size = new System.Drawing.Size(1067, 597);
            this.manageBrands1.TabIndex = 5;
            // 
            // brands1
            // 
            this.brands1.BackColor = System.Drawing.Color.White;
            this.brands1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brands1.Location = new System.Drawing.Point(261, 78);
            this.brands1.Name = "brands1";
            this.brands1.Size = new System.Drawing.Size(1070, 597);
            this.brands1.TabIndex = 4;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.White;
            this.dashboard1.Location = new System.Drawing.Point(262, 78);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1069, 599);
            this.dashboard1.TabIndex = 3;
            // 
            // regUser1
            // 
            this.regUser1.BackColor = System.Drawing.Color.White;
            this.regUser1.Location = new System.Drawing.Point(261, 78);
            this.regUser1.Name = "regUser1";
            this.regUser1.Size = new System.Drawing.Size(1067, 597);
            this.regUser1.TabIndex = 8;
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.regUser1);
            this.Controls.Add(this.manageVehicle1);
            this.Controls.Add(this.postVehicle1);
            this.Controls.Add(this.manageBrands1);
            this.Controls.Add(this.brands1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.vehiclepanel.ResumeLayout(false);
            this.brandspanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateContactInfo;
        private System.Windows.Forms.Button btnRegUser;
        private System.Windows.Forms.Button btnManageBooking;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Label lblmain;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.Button btnbrands;
        private System.Windows.Forms.Panel brandspanel;
        private System.Windows.Forms.Button btnmanagebrands;
        private System.Windows.Forms.Button btncreatebrands;
        private dashboard dashboard1;
        private brands brands1;
        private ManageBrands manageBrands1;
        private System.Windows.Forms.Panel vehiclepanel;
        private System.Windows.Forms.Button btnManageVehicle;
        private System.Windows.Forms.Button btnPostVehicle;
        private PostVehicle postVehicle1;
        private ManageVehicle manageVehicle1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RegUser regUser1;
    }
}