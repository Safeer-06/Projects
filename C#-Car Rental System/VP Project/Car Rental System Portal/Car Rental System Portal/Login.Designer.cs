namespace Car_Rental_System_Portal
{
    partial class Login
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
            this.btnregister = new System.Windows.Forms.Button();
            this.btnSignin = new System.Windows.Forms.Button();
            this.passpanel2 = new System.Windows.Forms.Panel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.unamepanel1 = new System.Windows.Forms.Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.picpass = new System.Windows.Forms.PictureBox();
            this.picuser = new System.Windows.Forms.PictureBox();
            this.picCarLogo = new System.Windows.Forms.PictureBox();
            this.lblclose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Location = new System.Drawing.Point(43, 396);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(271, 55);
            this.btnregister.TabIndex = 26;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSignin.Location = new System.Drawing.Point(43, 325);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(271, 55);
            this.btnSignin.TabIndex = 25;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // passpanel2
            // 
            this.passpanel2.BackColor = System.Drawing.Color.White;
            this.passpanel2.Location = new System.Drawing.Point(43, 261);
            this.passpanel2.Name = "passpanel2";
            this.passpanel2.Size = new System.Drawing.Size(271, 1);
            this.passpanel2.TabIndex = 24;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.Location = new System.Drawing.Point(69, 233);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(229, 18);
            this.txtpassword.TabIndex = 23;
            this.txtpassword.Text = "Password";
            // 
            // unamepanel1
            // 
            this.unamepanel1.BackColor = System.Drawing.Color.White;
            this.unamepanel1.Location = new System.Drawing.Point(43, 212);
            this.unamepanel1.Name = "unamepanel1";
            this.unamepanel1.Size = new System.Drawing.Size(271, 1);
            this.unamepanel1.TabIndex = 21;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtemail.Location = new System.Drawing.Point(69, 184);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(229, 18);
            this.txtemail.TabIndex = 20;
            this.txtemail.Text = "Email";
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // picpass
            // 
            this.picpass.Image = global::Car_Rental_System_Portal.Properties.Resources._lock;
            this.picpass.Location = new System.Drawing.Point(43, 233);
            this.picpass.Name = "picpass";
            this.picpass.Size = new System.Drawing.Size(20, 22);
            this.picpass.TabIndex = 22;
            this.picpass.TabStop = false;
            // 
            // picuser
            // 
            this.picuser.Image = global::Car_Rental_System_Portal.Properties.Resources.close_envelope__1_;
            this.picuser.Location = new System.Drawing.Point(43, 184);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(20, 22);
            this.picuser.TabIndex = 19;
            this.picuser.TabStop = false;
            // 
            // picCarLogo
            // 
            this.picCarLogo.Image = global::Car_Rental_System_Portal.Properties.Resources.car__3_;
            this.picCarLogo.Location = new System.Drawing.Point(109, 12);
            this.picCarLogo.Name = "picCarLogo";
            this.picCarLogo.Size = new System.Drawing.Size(136, 134);
            this.picCarLogo.TabIndex = 18;
            this.picCarLogo.TabStop = false;
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Location = new System.Drawing.Point(346, 9);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(23, 22);
            this.lblclose.TabIndex = 27;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(371, 518);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.passpanel2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.picpass);
            this.Controls.Add(this.unamepanel1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.picuser);
            this.Controls.Add(this.picCarLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Panel passpanel2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.PictureBox picpass;
        private System.Windows.Forms.Panel unamepanel1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.PictureBox picCarLogo;
        private System.Windows.Forms.Label lblclose;
    }
}