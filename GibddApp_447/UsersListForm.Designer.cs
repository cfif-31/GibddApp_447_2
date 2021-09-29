
namespace GibddApp_447
{
    partial class UsersListForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameColumn,
            this.LastName,
            this.SerNameColumn,
            this.LoginColumn,
            this.PasswordColumn});
            this.dgvUsers.Location = new System.Drawing.Point(23, 13);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(659, 337);
            this.dgvUsers.TabIndex = 6;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.HeaderText = "Фамилия";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Имя";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // SerNameColumn
            // 
            this.SerNameColumn.HeaderText = "Отчество";
            this.SerNameColumn.Name = "SerNameColumn";
            this.SerNameColumn.ReadOnly = true;
            // 
            // LoginColumn
            // 
            this.LoginColumn.HeaderText = "Логин";
            this.LoginColumn.Name = "LoginColumn";
            this.LoginColumn.ReadOnly = true;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.HeaderText = "Пароль";
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.ReadOnly = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(582, 356);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "button1";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(469, 364);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(81, 24);
            this.bt_add.TabIndex = 9;
            this.bt_add.Text = "button2";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(163, 357);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dgvUsers);
            this.Name = "Form1";
            this.Text = "лла";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

