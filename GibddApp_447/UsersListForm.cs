using GibddApp_447.Classes;
using GibddApp_447.Classes.Entityes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GibddApp_447
{
    public partial class UsersListForm : Form
    {
        public UsersListForm()
        {
            InitializeComponent();
            /* MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
             {
                 Server = "192.168.201.12",
                 Port = 3306,
                 UserID = "testuser",
                 Password = "testpass234",
                 Database = "testuser_Gibdd447",
                 CharacterSet = "utf8"
             };
             Console.WriteLine(builder.ConnectionString);*/


            UpdateData();
        }

        private void UpdateData() {
            dgvUsers.Rows.Clear();
            
            foreach (User user in EfModel.Init().Users.Where(u=>u.FirstName.Contains(tbSearch.Text) || 
                u.LastName.Contains(tbSearch.Text) || u.SerName.Contains(tbSearch.Text) || 
                u.Login.Contains(tbSearch.Text) || u.Pass.Contains(tbSearch.Text)))
            {
                int r = dgvUsers.Rows.Add(user.FirstName, user.LastName, user.SerName, user.Login, user.Pass);
                dgvUsers.Rows[r].Tag = user;
            }
        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {

            
            /*   EfModel.Init().Users.Add(new User
               {
                   FirstName = tb_firstname.Text,
                   LastName = tb_lastname.Text,
                   SerName = tb_middlename.Text,
                   Login = tb_login.Text,
                   Pass = tb_password.Text
               });
               model.SaveChanges();
               UpdateData();*/
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0) {
                EfModel.Init().Users.Remove(dgvUsers.SelectedRows[0].Tag as User);
                EfModel.Init().SaveChanges();
                UpdateData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                AddUserForm addUser = new AddUserForm(dgvUsers.SelectedRows[0].Tag as User);
                addUser.ShowDialog();
                UpdateData();
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm(new User());
            addUser.ShowDialog();
            UpdateData();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
