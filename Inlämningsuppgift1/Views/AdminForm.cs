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
    public partial class AdminForm : Form
    {
        User user = new User();
        Advert advert = new Advert();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void txtAdminForm_TextChanged(object sender, EventArgs e)
        {
            string searchCondition = txtAdminForm.Text;

            AdvertRepo repo = new AdvertRepo();
            listBoxAdminForm.DisplayMember = "AdvertTitle";
            listBoxAdminForm.DataSource = repo.SearchAdvert(searchCondition);
        }

        private void cbSortAdminForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorting();
        }

        private void Sorting()
        {
            AdvertRepo advertRepo = new AdvertRepo();

            if (cbSortAdminForm.Text == "Price: Low")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = advertRepo.GetAllAdverts().OrderBy(x => x.AdvertPrice).ToList();
            }
            else if (cbSortAdminForm.Text == "Price: High")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = advertRepo.GetAllAdverts().OrderByDescending(x => x.AdvertPrice).ToList();
            }
            else if (cbSortAdminForm.Text == "Date: New")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = advertRepo.GetAllAdverts().OrderByDescending(x => x.AdvertID).ToList();
            }
            else if (cbSortAdminForm.Text == "Date: Old")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = advertRepo.GetAllAdverts().OrderBy(x => x.AdvertID).ToList();
            }
        }

        private void MyAdsSorting()
        {
            AdvertRepo advertRepo = new AdvertRepo();

            if (cbSortAdminForm.Text == "Price: Low")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = advertRepo.GetAllAdverts().Where(x => x.UserID == user.UserID).
                    OrderBy(x => x.AdvertPrice).ToList();
            }
            else if (cbSortAdminForm.Text == "Price: High")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = advertRepo.GetAllAdverts().Where(x => x.UserID == user.UserID).
                    OrderByDescending(x => x.AdvertPrice).ToList();
            }
            else if (cbSortAdminForm.Text == "Date: New")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = advertRepo.GetAllAdverts().Where(x => x.UserID == user.UserID)
                    .OrderByDescending(x => x.AdvertID).ToList();
            }
            else if (cbSortAdminForm.Text == "Date: Old")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = advertRepo.GetAllAdverts().Where(x => x.UserID == user.UserID).
                    OrderBy(x => x.AdvertID).ToList();
            }
        }

        private void cbCategoryAdminForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdvertSort();
        }

        public void AdvertSort()
        {
            AdvertRepo repo = new AdvertRepo();

            if (cbCategoryAdminForm.Text == "")
            {
                listBoxAdminForm.DataSource = null;
                listBoxAdminForm.Items.Clear();
                return;
            }
            if (cbCategoryAdminForm.Text == "Cars")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = repo.GetAllCars();
            }
            else if (cbCategoryAdminForm.Text == "Computer")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = repo.GetAllComputers();
            }
            else if (cbCategoryAdminForm.Text == "Phone")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = repo.GetAllMobiles();
            }
            else if (cbCategoryAdminForm.Text == "Clothes")
            {
                listBoxAdminForm.DisplayMember = "AdvertTitle";
                listBoxAdminForm.ValueMember = "AdvertID";
                listBoxAdminForm.DataSource = repo.GetAllClothes();
            }
        }

        private void listBoxAdminForm_DoubleClick(object sender, EventArgs e)
        {
            int AdvertId = int.Parse(listBoxAdminForm.SelectedValue.ToString());
            AdvertRepo repo = new AdvertRepo();
            Advert advert = repo.GetAdverts(AdvertId);
            MessageBox.Show("Titel: " + advert.AdvertTitle + "\nBeskrivning: " +
                advert.AdvertDiscription + "\nPris: " +
                advert.AdvertPrice + "\nPublicerad: " +
                advert.Datetime.ToString());
        }

        private void btnAddAdminForm_Click(object sender, EventArgs e)
        {

            AdvertRepo repo = new AdvertRepo();
            CategoryRepo categoryRepo = new CategoryRepo();
            Advert advert = new Advert();
            Category category = categoryRepo.GetCategory(comboBox1.Text);


            if (txtTitleAdminForm.Text == "" || txtPriceAdminForm.Text == "" || txtDescriptionAdminForm.Text == "" || comboBox1.SelectedIndex < 1)
            {
                MessageBox.Show("All informations must be filled");
            }
            else
            {
                advert.AdvertTitle = txtTitleAdminForm.Text;
                advert.AdvertDiscription = txtDescriptionAdminForm.Text;
                advert.UserID = user.UserID;
                advert.CategoryID = category.CategoryID;
                advert.Datetime = DateTime.Now.Date;

                if (!int.TryParse(txtPriceAdminForm.Text, out int pris))
                {
                    MessageBox.Show("Insert only numbers");
                    return;
                }
                advert.AdvertPrice = pris;
                repo.InsertNewAdvert(advert);

                MessageBox.Show("New advert added: " + advert.AdvertTitle);

            }
        }   

        private void btnDeleteAdminForm_Click(object sender, EventArgs e)
        {
            AdvertRepo repo = new AdvertRepo();

            int advertID = int.Parse(listBoxAdminForm.SelectedValue.ToString());

            advert = repo.GetAdverts(advertID);
            if (user.UserID == advert.UserID)
            {
                repo.DeleteAdvert(advertID);
                MessageBox.Show("Advert Deleted" + advert.AdvertTitle);
                listBoxAdminForm.Refresh();
            }
        }

        private void btnUpdateAdminForm_Click(object sender, EventArgs e)
        {
            if(listBoxAdminForm.SelectedIndex != 0)
            {
                Update();
            }
        }

        private void btnShowAdvAdminForm_Click(object sender, EventArgs e)
        {
            AdvertRepo repo = new AdvertRepo();
            listBoxAdminForm.DisplayMember = "AdvertTitle";
            listBoxAdminForm.ValueMember = "AdvertID";
            listBoxAdminForm.DataSource = repo.GetAllAdverts();
        }

        private void LogOutAdminForm_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm(user);
            this.Hide();
            logForm.Show();
        }

        private void Update()
        {
            AdvertRepo repo = new AdvertRepo();
            CategoryRepo categoryRepo = new CategoryRepo();
            Category category = categoryRepo.GetCategory(comboBox1.Text);

            if (advert.UserID != user.UserID)
            {
                MessageBox.Show("Error");
                return;
            }

            advert.AdvertTitle = txtTitleAdminForm.Text;
            advert.AdvertDiscription = txtDescriptionAdminForm.Text;
            advert.Datetime = DateTime.Now;

            if (comboBox1.SelectedIndex < 1)
            {
                MessageBox.Show("Choose category");
                return;
            }
            advert.Category = category;
            advert.CategoryID = category.CategoryID;

            if (!int.TryParse(txtPriceAdminForm.Text, out int price))
            {
                MessageBox.Show("Insert only numbers");
                return;
            }
            advert.AdvertPrice = price;
            repo.UpdateAdverts(advert);
            listBoxAdminForm.Refresh();

            MessageBox.Show("Advert Updated: " + advert.AdvertTitle);
        }
    }
}
