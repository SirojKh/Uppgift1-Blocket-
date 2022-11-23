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
    public partial class StartForm : Form
    {

        public static StartForm instance;
        User user = new User();
        Advert advert = new Advert();

        public StartForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void txtStartForm_TextChanged(object sender, EventArgs e)
        {
            string searchCondition = txtStartForm.Text;

            AdvertRepo repo = new AdvertRepo();
            listBoxStartForm.DisplayMember = "AdvertTitle";
            listBoxStartForm.DataSource = repo.SearchAdvert(searchCondition);
        }

        private void listBoxStartForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSortStartForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorting();
        }

        public void AdvertSort()
        {
            AdvertRepo repo = new AdvertRepo();

            if (cbCategoryStartForm.Text == "")
            {
                listBoxStartForm.DataSource = null;
                listBoxStartForm.Items.Clear();
                return;
            }
            if (cbCategoryStartForm.Text == "Cars")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = repo.GetAllCars();
            }
            else if (cbCategoryStartForm.Text == "Computers")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = repo.GetAllComputers();
            }
            else if (cbCategoryStartForm.Text == "Phone")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = repo.GetAllMobiles();
            }
            else if (cbCategoryStartForm.Text == "Clothes")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = repo.GetAllClothes();
            }
        }

        private void listBoxStartForm_DoubleClick(object sender, EventArgs e)
        {
            int AdvertID = int.Parse(listBoxStartForm.SelectedValue.ToString());
            AdvertRepo repo = new AdvertRepo();
            Advert advert = repo.GetAdverts(AdvertID);
            MessageBox.Show("Titel: " + advert.AdvertTitle + "\nBeskrivning: " +
                advert.AdvertDiscription + "\nPris: " +
                advert.AdvertPrice + "\nPublicerad: " +
                advert.Datetime.ToString());
        }

        private void cbCategoryStartForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdvertSort();
        }

        private void Sorting()
        {
            AdvertRepo advertRepo = new AdvertRepo();

            if (cbSortStartForm.Text == "Price: Low")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = advertRepo.GetAllAdverts().OrderBy(x => x.AdvertPrice).ToList();
            }
            else if (cbSortStartForm.Text == "Price: High")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = advertRepo.GetAllAdverts().OrderByDescending(x => x.AdvertPrice).ToList();
            }
            else if (cbSortStartForm.Text == "Date: New")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = advertRepo.GetAllAdverts().OrderByDescending(x => x.AdvertID).ToList();
            }
            else if (cbSortStartForm.Text == "Date: Old")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = advertRepo.GetAllAdverts().OrderBy(x => x.AdvertID).ToList();
            }
        }

        private void MyAdsSorting()
        {
            AdvertRepo advertRepo = new AdvertRepo();

            if (cbSortStartForm.Text == "Price: Low")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = advertRepo.GetAllAdverts().
                    Where(x => x.UserID == user.UserID).OrderBy(x => x.AdvertPrice).ToList();
            }
            else if (cbSortStartForm.Text == "Price: High")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = advertRepo.GetAllAdverts().
                    Where(x => x.UserID == user.UserID).OrderByDescending(x => x.AdvertPrice).ToList();
            }
            else if (cbSortStartForm.Text == "Date: New")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = advertRepo.GetAllAdverts().
                    Where(x => x.UserID == user.UserID).OrderByDescending(x => x.AdvertID).ToList();
            }
            else if (cbSortStartForm.Text == "Date: Old")
            {
                listBoxStartForm.DisplayMember = "AdvertTitle";
                listBoxStartForm.ValueMember = "AdvertID";
                listBoxStartForm.DataSource = advertRepo.GetAllAdverts().
                    Where(x => x.UserID == user.UserID).OrderBy(x => x.AdvertID).ToList();
            }
        }

        private void lblLoggin_DoubleClick(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm(user);
            this.Hide();
            logForm.ShowDialog();
        }

        private void btnShowStartForm_Click(object sender, EventArgs e)
        {
            AdvertRepo repo = new AdvertRepo();
            listBoxStartForm.DisplayMember = "AdvertTitle";
            listBoxStartForm.ValueMember = "AdvertID";
            listBoxStartForm.DataSource = repo.GetAllAdverts();
        }
    }
}
