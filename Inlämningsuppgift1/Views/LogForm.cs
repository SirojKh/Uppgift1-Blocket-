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
    public partial class LogForm : Form
    {
        User existUser = new User();

        public LogForm(User logged)
        {
            InitializeComponent();
            existUser = logged;
        }

        public LogForm()
        {
        }

        private void btnLoginLogForm_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            UserRepo userRepo = new UserRepo();
            
            User myUser = userRepo.GetAllUsers().FirstOrDefault(x => x.UserName == txtNameLogForm.Text && x.UserPassword == txtPasswordLogForm.Text);

            if (myUser != null)
            {
                MessageBox.Show("Welcome:  " + myUser.UserName);

                existUser.UserPassword = myUser.UserPassword;
                existUser.UserPassword = myUser.UserPassword;
                this.Hide();
                adminForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("User not found, try again!");
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Hide();
            startForm.ShowDialog(this);
        }

        private void lblRegLogForm_DoubleClick(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            this.Hide();
            regForm.ShowDialog(this);
        }
    }
}
