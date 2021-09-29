using GibddApp_447.Classes;
using GibddApp_447.Classes.Entityes;
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
    public partial class AddUserForm : Form
    {
        User EditedUser;
        public AddUserForm(User user)
        {
            EditedUser = user;
            InitializeComponent();
            tb_firstname.Text = user.FirstName;
            tb_lastname.Text = user.LastName;
            tb_middlename.Text = user.SerName;
            tb_login.Text = user.Login;
            tb_password.Text = user.Pass;
        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {
            EditedUser.FirstName = tb_firstname.Text;
            EditedUser.LastName = tb_lastname.Text;
            EditedUser.SerName = tb_middlename.Text;
            EditedUser.Login = tb_login.Text;
            EditedUser.Pass = tb_password.Text;
            
            if (EditedUser.Id == 0) {
                EfModel.Init().Users.Add(EditedUser);
            }
            EfModel.Init().SaveChanges();
            Close();
        }
    }
}
