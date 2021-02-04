namespace Car_Rental_System_Portal
{
    partial class ManageBrands
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
            this.lbllistbrands = new System.Windows.Forms.Label();
            this.panelcolor = new System.Windows.Forms.Panel();
            this.lblmanageBrands = new System.Windows.Forms.Label();
            this.lblBrandsName = new System.Windows.Forms.Label();
            this.txtbrandsName = new System.Windows.Forms.TextBox();
            this.panelbrand = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panelid = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
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
            this.panelfield.Location = new System.Drawing.Point(12, 62);
            this.panelfield.Name = "panelfield";
            this.panelfield.Size = new System.Drawing.Size(578, 416);
            this.panelfield.TabIndex = 5;
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
            this.panel3.Controls.Add(this.lbllistbrands);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 53);
            this.panel3.TabIndex = 0;
            // 
            // lbllistbrands
            // 
            this.lbllistbrands.AutoSize = true;
            this.lbllistbrands.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistbrands.ForeColor = System.Drawing.Color.Silver;
            this.lbllistbrands.Location = new System.Drawing.Point(3, 9);
            this.lbllistbrands.Name = "lbllistbrands";
            this.lbllistbrands.Size = new System.Drawing.Size(131, 25);
            this.lbllistbrands.TabIndex = 0;
            this.lbllistbrands.Text = "Listed Brands";
            // 
            // panelcolor
            // 
            this.panelcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelcolor.Location = new System.Drawing.Point(2, 40);
            this.panelcolor.Name = "panelcolor";
            this.panelcolor.Size = new System.Drawing.Size(1063, 2);
            this.panelcolor.TabIndex = 4;
            // 
            // lblmanageBrands
            // 
            this.lblmanageBrands.AutoSize = true;
            this.lblmanageBrands.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanageBrands.Location = new System.Drawing.Point(24, 0);
            this.lblmanageBrands.Name = "lblmanageBrands";
            this.lblmanageBrands.Size = new System.Drawing.Size(214, 37);
            this.lblmanageBrands.TabIndex = 3;
            this.lblmanageBrands.Text = "Manage Brands";
            // 
            // lblBrandsName
            // 
            this.lblBrandsName.AutoSize = true;
            this.lblBrandsName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandsName.Location = new System.Drawing.Point(665, 185);
            this.lblBrandsName.Name = "lblBrandsName";
            this.lblBrandsName.Size = new System.Drawing.Size(131, 25);
            this.lblBrandsName.TabIndex = 6;
            this.lblBrandsName.Text = "Brands Name:";
            this.lblBrandsName.Click += new System.EventHandler(this.lblBrandsName_Click);
            // 
            // txtbrandsName
            // 
            this.txtbrandsName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbrandsName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbrandsName.Location = new System.Drawing.Point(670, 213);
            this.txtbrandsName.Name = "txtbrandsName";
            this.txtbrandsName.Size = new System.Drawing.Size(262, 22);
            this.txtbrandsName.TabIndex = 7;
            this.txtbrandsName.TextChanged += new System.EventHandler(this.txtbrandsName_TextChanged);
            // 
            // panelbrand
            // 
            this.panelbrand.BackColor = System.Drawing.Color.Black;
            this.panelbrand.Location = new System.Drawing.Point(670, 246);
            this.panelbrand.Name = "panelbrand";
            this.panelbrand.Size = new System.Drawing.Size(262, 3);
            this.panelbrand.TabIndex = 8;
            this.panelbrand.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbrand_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(670, 298);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(273, 47);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Brand";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(670, 351);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(273, 47);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete Brand";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panelid
            // 
            this.panelid.BackColor = System.Drawing.Color.Black;
            this.panelid.Location = new System.Drawing.Point(670, 177);
            this.panelid.Name = "panelid";
            this.panelid.Size = new System.Drawing.Size(262, 3);
            this.panelid.TabIndex = 13;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(670, 144);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(262, 22);
            this.txtid.TabIndex = 12;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(665, 116);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(91, 25);
            this.lblid.TabIndex = 11;
            this.lblid.Text = "Brand ID:";
            // 
            // ManageBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panelbrand);
            this.Controls.Add(this.txtbrandsName);
            this.Controls.Add(this.lblBrandsName);
            this.Controls.Add(this.panelfield);
            this.Controls.Add(this.panelcolor);
            this.Controls.Add(this.lblmanageBrands);
            this.Name = "ManageBrands";
            this.Size = new System.Drawing.Size(1067, 597);
            this.Load += new System.EventHandler(this.ManageBrands_Load);
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
        private System.Windows.Forms.Label lbllistbrands;
        private System.Windows.Forms.Panel panelcolor;
        private System.Windows.Forms.Label lblmanageBrands;
        private System.Windows.Forms.Label lblBrandsName;
        private System.Windows.Forms.TextBox txtbrandsName;
        private System.Windows.Forms.Panel panelbrand;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panelid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
    }
}
