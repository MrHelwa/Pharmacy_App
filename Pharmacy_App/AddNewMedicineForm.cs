using Pharmacy_App.Models;

namespace Pharmacy_App_1
{
    public partial class AddNewMedicineForm : Form
    {
        public AddNewMedicineForm()
        {
            InitializeComponent();
            PopulateCategoriesListBox();
        }
        private void PopulateCategoriesListBox()
        {
            using (var context = new PharmacyContext())
            {
                // Query all categories from the Categories table
                var categories = context.Categories.ToList();

                // Bind the list of categories to the ListBox
                categoriesListBox.DataSource = categories;
                categoriesListBox.DisplayMember = "Name"; // Display category names
            }
        }


        //----------------------Add Medicine Button-----------------
        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            // Get data from the controls
            string name = MedicineNameTxtBox.Text;
            float price = float.Parse(MedicinePriceTxtBox.Text);
            DateTime productionDate = ProductionDatePicker.Value;
            DateTime expirationDate = ExpirationDatePicker.Value;

            //This part of the code gets the currently selected item from the categoriesListBox.
            //you need to cast it to the Category type.because the items in the ListBox are typically of type object
            //you access the Id property of the selected Category object.
            int categoryId = ((Category)categoriesListBox.SelectedItem).Id;

            // Create a new Medicine object
            var newMedicine = new Medicine
            {
                Name = name,
                Price = price,
                Production_Date = productionDate,
                Expiration_Date = expirationDate,
                CatId = categoryId
            };

            using (var context = new PharmacyContext())
            {
                // Add the new medicine to the Medicines DbSet
                context.Medicines.Add(newMedicine);

                // Save changes to the database
                context.SaveChanges();
            }

            // Close the Add New Medicine Form
            // this.Close();
        }

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
    }
}

