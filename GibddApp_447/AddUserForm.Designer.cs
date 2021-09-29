
namespace GibddApp_447
{
    partial class AddUserForm
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
            this.tb_middlename = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.bt_adduser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_middlename
            // 
            this.tb_middlename.Location = new System.Drawing.Point(166, 78);
            this.tb_middlename.Name = "tb_middlename";
            this.tb_middlename.Size = new System.Drawing.Size(100, 20);
            this.tb_middlename.TabIndex = 10;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(166, 132);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 9;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(166, 106);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 8;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(166, 52);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(100, 20);
            this.tb_lastname.TabIndex = 7;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(166, 26);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(100, 20);
            this.tb_firstname.TabIndex = 6;
            // 
            // bt_adduser
            // 
            this.bt_adduser.Location = new System.Drawing.Point(12, 177);
            this.bt_adduser.Name = "bt_adduser";
            this.bt_adduser.Size = new System.Drawing.Size(254, 23);
            this.bt_adduser.TabIndex = 11;
            this.bt_adduser.Text = "button1";
            this.bt_adduser.UseVisualStyleBackColor = true;
            this.bt_adduser.Click += new System.EventHandler(this.bt_adduser_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 240);
            this.Controls.Add(this.bt_adduser);
            this.Controls.Add(this.tb_middlename);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_firstname);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_middlename;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.Button bt_adduser;
    }
}