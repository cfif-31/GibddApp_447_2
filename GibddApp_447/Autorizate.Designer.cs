
namespace GibddApp_447
{
    partial class Autorizate
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
            this.bt_Login = new System.Windows.Forms.Button();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(83, 115);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(100, 23);
            this.bt_Login.TabIndex = 0;
            this.bt_Login.Text = "button1";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(83, 50);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(100, 20);
            this.tb_Login.TabIndex = 1;
            // 
            // tb_Pass
            // 
            this.tb_Pass.Location = new System.Drawing.Point(83, 76);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(100, 20);
            this.tb_Pass.TabIndex = 2;
            // 
            // Autorizate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 183);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.bt_Login);
            this.Name = "Autorizate";
            this.Text = "Autorizate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Pass;
    }
}