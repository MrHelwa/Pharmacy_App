using Pharmacy_App;
using Pharmacy_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_App_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //--------------------------------Show All Medicine Button
        private void ShowAllMedicineButton_Click(object sender, EventArgs e)
        {
            using (var context = new PharmacyContext())
            {
                // Query all medicines from the Medicine table
                var medicines = context.Medicines.ToList();

                // view medicines with the medicines var
                ViewData.DataSource = medicines;
            }
        }
        //--------------------Show All Categories Button
        private void ShowAllCategoriesButton_Click(object sender, EventArgs e)
        {
            using (var context = new PharmacyContext())
            {

                var categories = context.Categories.ToList();


                ViewData.DataSource = categories;

            }
        }
        //-----------------------------Show Expired Medicine Button
        private void ShowExpiredMedicineButton_Click(object sender, EventArgs e)
        {
            using (var context = new PharmacyContext())
            {

                var expiredMedicines = context.Medicines
                    .Where(m => m.Expiration_Date < DateTime.Now)
                    .ToList();
                ViewData.DataSource = expiredMedicines;
            }
        }
        //---------------------------Add New Medicine Button
        private void AddNewMedicineButton_Click(object sender, EventArgs e)
        {

            AddNewMedicineForm addNewMedicineForm = new AddNewMedicineForm();


            addNewMedicineForm.ShowDialog();
        }
        //---------------------------Add New Category Button
        private void AddNewCategoryButton_Click(object sender, EventArgs e)
        {
            AddNewCategoryForm addNewCategoryForm = new AddNewCategoryForm();
            addNewCategoryForm.ShowDialog();
        }
        //---------------------------Search Medicine Button
        private void SearchMedicineButton_Click(object sender, EventArgs e)
        {
            //Trim funtion --> removes any leading and trailing whitespace characters from the text.
            string searchTerm = SearchMedicineTextBox.Text.Trim();

            using (var context = new PharmacyContext())
            {

                var seachResults = context.Medicines.Where(m => m.Name.Contains(searchTerm)).ToList();

                //Show the search results in the data grid view.
                ViewData.DataSource = seachResults;
            }
        }


        //---------------------------Search Catagory Button
        private void SearchCategoryButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchCategoryTextBox.Text.Trim();

            using(var  context = new PharmacyContext())
            {
                var searchResults = context.Categories.Where(c=>c.Name.Contains(searchTerm)).ToList();
                ViewData.DataSource = searchResults;

            }
        }
    }
}
