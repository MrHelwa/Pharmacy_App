using Pharmacy_App.Models;

namespace Pharmacy_App
{
    public partial class AddNewCategoryForm : Form
    {
        public AddNewCategoryForm()
        {
            InitializeComponent();
        }


        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            string name = CategoryNameTxtBox.Text;
            //Create new Category Object
            // 
            using (var context = new PharmacyContext())
            {
                //Check if the category already exists in the database
                //FirstOrDefault--> returns the first Category name that exists in the table or if there is no such name provided it returns the defualt value for the element's type which is null in case of the object.

                var existingCategory = context.Categories.FirstOrDefault(c => c.Name == name);
                if (existingCategory != null)
                {
                    MessageBox.Show("Category already exists. Please Choose a diffirent name");
                }
                else
                {
                    //Create new Category object
                    var newCategory = new Category { Name = name };

                    //Add the new Category to the Categories DbSet
                    context.Categories.Add(newCategory);

                    //Save changes to the database
                    context.SaveChanges();

                    // Refresh the DataGridView to display the updated list of categories
                    ShowCategoriesButton_Click(sender, e);

                    //Clear the text box for the next input
                    CategoryNameTxtBox.Clear();

                    //Display message 
                    MessageBox.Show("Category Added Successfully");

                }
            }

        }

        private void ShowCategoriesButton_Click(object sender, EventArgs e)
        {
            using (var context = new PharmacyContext())
            {

                var categories = context.Categories.ToList();
                //view medicines with the medicines var
                ViewData.DataSource = categories;
            }
        }
    }
}
