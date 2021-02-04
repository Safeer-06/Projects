namespace Car_Rental_System_Portal
{
    partial class RegUser
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
            this.DataBrands = new System.Windows.Forms.DataGridView();
            this.panelfield = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblreg = new System.Windows.Forms.Label();
            this.panelcolor = new System.Windows.Forms.Panel();
            this.lblreguser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataBrands)).BeginInit();
            this.panelfield.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataBrands
            // 
            this.DataBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBrands.Location = new System.Drawing.Point(3, 62);
            this.DataBrands.Name = "DataBrands";
            this.DataBrands.Size = new System.Drawing.Size(737, 351);
            this.DataBrands.TabIndex = 1;
            // 
            // panelfield
            // 
            this.panelfield.BackColor = System.Drawing.Color.White;
            this.panelfield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelfield.Controls.Add(this.DataBrands);
            this.panelfield.Controls.Add(this.panel3);
            this.panelfield.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelfield.Location = new System.Drawing.Point(12, 73);
            this.panelfield.Name = "panelfield";
            this.panelfield.Size = new System.Drawing.Size(741, 416);
            this.panelfield.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.lblreg);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 53);
            this.panel3.TabIndex = 0;
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.ForeColor = System.Drawing.Color.Silver;
            this.lblreg.Location = new System.Drawing.Point(3, 9);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(127, 25);
            this.lblreg.TabIndex = 0;
            this.lblreg.Text = "Register User";
            // 
            // panelcolor
            // 
            this.panelcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelcolor.Location = new System.Drawing.Point(2, 51);
            this.panelcolor.Name = "panelcolor";
            this.panelcolor.Size = new System.Drawing.Size(1063, 2);
            this.panelcolor.TabIndex = 15;
            // 
            // lblreguser
            // 
            this.lblreguser.AutoSize = true;
            this.lblreguser.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreguser.Location = new System.Drawing.Point(24, 11);
            this.lblreguser.Name = "lblreguser";
            this.lblreguser.Size = new System.Drawing.Size(189, 37);
            this.lblreguser.TabIndex = 14;
            this.lblreguser.Text = "Register User";
            // 
            // RegUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelfield);
            this.Controls.Add(this.panelcolor);
            this.Controls.Add(this.lblreguser);
            this.Name = "RegUser";
            this.Size = new System.Drawing.Size(1067, 597);
            this.Load += new System.EventHandler(this.RegUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBrands)).EndInit();
            this.panelfield.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataBrands;
        private System.Windows.Forms.Panel panelfield;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.Panel panelcolor;
        private System.Windows.Forms.Label lblreguser;
    }
}
