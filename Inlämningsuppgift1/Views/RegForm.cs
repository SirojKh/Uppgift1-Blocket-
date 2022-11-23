using Inlämningsuppgift1.Models;
using Inlämningsuppgift1.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift1.Views
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void btnLoginRegForm_Click(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            User user = new User();
            AdminForm adminForm = new AdminForm();
            try
            {
                if (txtNameRegForm.Text != "" && txtPasswordRegForm.Text != "")
                {
                    user.UserName = txtNameRegForm.Text;
                    if (txtPasswordRegForm.Text != txtPassword2RegForm.Text)
                    {
                        MessageBox.Show("Not same password");
                    }
                    else
                    user.UserPassword = txtPasswordRegForm.Text;
                    repo.InsertNewUser(user);
                    MessageBox.Show("User added");
                    this.Close();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Username and password must be filled");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong");
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Close();
            startForm.Show();
        }
    }
}
