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
    public partial class Autorizate : Form
    {
        public Autorizate()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            User user = EfModel.Init().Users.Where(u => u.Login == tb_Login.Text && u.Pass == tb_Pass.Text).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("eRROR!");
            }
            else {
                MessageBox.Show("Успех! "+ user.FirstName );
                Hide();
                new UsersListForm().ShowDialog();
                Show();
            }
        }
    }
}
