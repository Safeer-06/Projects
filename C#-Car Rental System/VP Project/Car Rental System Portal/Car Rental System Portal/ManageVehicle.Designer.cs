namespace Car_Rental_System_Portal
{
    partial class ManageVehicle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelfield = new System.Windows.Forms.Panel();
            this.DataBrands = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbllisVehicle = new System.Windows.Forms.Label();
            this.panelid = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelbrand = new System.Windows.Forms.Panel();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panelcolor = new System.Windows.Forms.Panel();
            this.lblmanageVehicle = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.cmbbrand = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtoverview = new System.Windows.Forms.TextBox();
            this.lbloverview = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblfuel = new System.Windows.Forms.Label();
            this.cmbfuel = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtModelYear = new System.Windows.Forms.TextBox();
            this.lblmodel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.panelfield.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBrands)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelfield
            // 
            this.panelfield.BackColor = System.Drawing.Color.White;
            this.panelfield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelfield.Controls.Add(this.DataBrands);
            this.panelfield.Controls.Add(this.panel3);
            this.panelfield.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelfield.Location = new System.Drawing.Point(3, 73);
            this.panelfield.Name = "panelfield";
            this.panelfield.Size = new System.Drawing.Size(578, 416);
            this.panelfield.TabIndex = 16;
            // 
            // DataBrands
            // 
            this.DataBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBrands.Location = new System.Drawing.Point(3, 62);
            this.DataBrands.Name = "DataBrands";
            this.DataBrands.Size = new System.Drawing.Size(572, 351);
            this.DataBrands.TabIndex = 1;
            this.DataBrands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBrands_CellClick);
            this.DataBrands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBrands_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.lbllisVehicle);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 53);
            this.panel3.TabIndex = 0;
            // 
            // lbllisVehicle
            // 
            this.lbllisVehicle.AutoSize = true;
            this.lbllisVehicle.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllisVehicle.ForeColor = System.Drawing.Color.Silver;
            this.lbllisVehicle.Location = new System.Drawing.Point(3, 9);
            this.lbllisVehicle.Name = "lbllisVehicle";
            this.lbllisVehicle.Size = new System.Drawing.Size(132, 25);
            this.lbllisVehicle.TabIndex = 0;
            this.lbllisVehicle.Text = "Listed Vehicle";
            // 
            // panelid
            // 
            this.panelid.BackColor = System.Drawing.Color.Black;
            this.panelid.Location = new System.Drawing.Point(609, 122);
            this.panelid.Name = "panelid";
            this.panelid.Size = new System.Drawing.Size(262, 3);
            this.panelid.TabIndex = 24;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(609, 97);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(262, 19);
            this.txtid.TabIndex = 23;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(604, 76);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(22, 20);
            this.lblid.TabIndex = 22;
            this.lblid.Text = "ID";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(883, 122);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(184, 47);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete Brand";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(883, 69);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 47);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update Brand";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelbrand
            // 
            this.panelbrand.BackColor = System.Drawing.Color.Black;
            this.panelbrand.Location = new System.Drawing.Point(613, 179);
            this.panelbrand.Name = "panelbrand";
            this.panelbrand.Size = new System.Drawing.Size(262, 3);
            this.panelbrand.TabIndex = 19;
            // 
            // txttitle
            // 
            this.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttitle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.Location = new System.Drawing.Point(615, 155);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(262, 19);
            this.txttitle.TabIndex = 18;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(605, 132);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(86, 20);
            this.lbltitle.TabIndex = 17;
            this.lbltitle.Text = "Vehicle Title";
            // 
            // panelcolor
            // 
            this.panelcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelcolor.Location = new System.Drawing.Point(-7, 51);
            this.panelcolor.Name = "panelcolor";
            this.panelcolor.Size = new System.Drawing.Size(1063, 2);
            this.panelcolor.TabIndex = 15;
            // 
            // lblmanageVehicle
            // 
            this.lblmanageVehicle.AutoSize = true;
            this.lblmanageVehicle.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanageVehicle.Location = new System.Drawing.Point(15, 11);
            this.lblmanageVehicle.Name = "lblmanageVehicle";
            this.lblmanageVehicle.Size = new System.Drawing.Size(216, 37);
            this.lblmanageVehicle.TabIndex = 14;
            this.lblmanageVehicle.Text = "Manage Vehicle";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.Location = new System.Drawing.Point(609, 194);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(53, 20);
            this.lblbrand.TabIndex = 25;
            this.lblbrand.Text = "Brands";
            // 
            // cmbbrand
            // 
            this.cmbbrand.FormattingEnabled = true;
            this.cmbbrand.Location = new System.Drawing.Point(613, 217);
            this.cmbbrand.Name = "cmbbrand";
            this.cmbbrand.Size = new System.Drawing.Size(262, 21);
            this.cmbbrand.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(613, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 3);
            this.panel1.TabIndex = 28;
            // 
            // txtoverview
            // 
            this.txtoverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtoverview.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoverview.Location = new System.Drawing.Point(615, 272);
            this.txtoverview.Name = "txtoverview";
            this.txtoverview.Size = new System.Drawing.Size(262, 19);
            this.txtoverview.TabIndex = 27;
            // 
            // lbloverview
            // 
            this.lbloverview.AutoSize = true;
            this.lbloverview.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloverview.Location = new System.Drawing.Point(605, 249);
            this.lbloverview.Name = "lbloverview";
            this.lbloverview.Size = new System.Drawing.Size(65, 20);
            this.lbloverview.TabIndex = 26;
            this.lbloverview.Text = "Overview";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(613, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 3);
            this.panel2.TabIndex = 31;
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(615, 336);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(262, 19);
            this.txtprice.TabIndex = 30;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(605, 313);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(93, 20);
            this.lblprice.TabIndex = 29;
            this.lblprice.Text = "Price Per Day";
            // 
            // lblfuel
            // 
            this.lblfuel.AutoSize = true;
            this.lblfuel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuel.Location = new System.Drawing.Point(605, 370);
            this.lblfuel.Name = "lblfuel";
            this.lblfuel.Size = new System.Drawing.Size(78, 20);
            this.lblfuel.TabIndex = 32;
            this.lblfuel.Text = "Select Fuel";
            // 
            // cmbfuel
            // 
            this.cmbfuel.FormattingEnabled = true;
            this.cmbfuel.Items.AddRange(new object[] {
            "Petrol",
            "Dielsel",
            "CNG"});
            this.cmbfuel.Location = new System.Drawing.Point(611, 394);
            this.cmbfuel.Name = "cmbfuel";
            this.cmbfuel.Size = new System.Drawing.Size(262, 21);
            this.cmbfuel.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(613, 472);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 3);
            this.panel4.TabIndex = 38;
            // 
            // txtModelYear
            // 
            this.txtModelYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelYear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelYear.Location = new System.Drawing.Point(615, 448);
            this.txtModelYear.Name = "txtModelYear";
            this.txtModelYear.Size = new System.Drawing.Size(262, 19);
            this.txtModelYear.TabIndex = 37;
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.Location = new System.Drawing.Point(605, 425);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(78, 20);
            this.lblmodel.TabIndex = 36;
            this.lblmodel.Text = "Model Year";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(613, 533);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 3);
            this.panel5.TabIndex = 41;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(615, 509);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(262, 19);
            this.txtCapacity.TabIndex = 40;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(605, 486);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(113, 20);
            this.lblCapacity.TabIndex = 39;
            this.lblCapacity.Text = "Seating Capacity";
            // 
            // ManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtModelYear);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.cmbfuel);
            this.Controls.Add(this.lblfuel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtoverview);
            this.Controls.Add(this.lbloverview);
            this.Controls.Add(this.cmbbrand);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.panelfield);
            this.Controls.Add(this.panelid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panelbrand);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.panelcolor);
            this.Controls.Add(this.lblmanageVehicle);
            this.Name = "ManageVehicle";
            this.Size = new System.Drawing.Size(1067, 597);
            this.Load += new System.EventHandler(this.ManageVehicle_Load);
            this.panelfield.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBrands)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelfield;
        private System.Windows.Forms.DataGridView DataBrands;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbllisVehicle;
        private System.Windows.Forms.Panel panelid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelbrand;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panelcolor;
        private System.Windows.Forms.Label lblmanageVehicle;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.ComboBox cmbbrand;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtoverview;
        private System.Windows.Forms.Label lbloverview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblfuel;
        private System.Windows.Forms.ComboBox cmbfuel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtModelYear;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
    }
}
