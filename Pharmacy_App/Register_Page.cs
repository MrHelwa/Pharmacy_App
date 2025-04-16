using Azure;
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

namespace Pharmacy_App
{
    public partial class Register_Page : Form
    {
        public Register_Page()
        {
            InitializeComponent();
        }



        private void Login_Click(object sender, EventArgs e)
        {
            LoninForm login_page = new LoninForm();
            login_page.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Get user input from the form
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;

            // Check if the email already exists in the database
            //Note:-Using keyword are used for resource management, once its blocked are executed it ensure that the "var context" are disposed or clened because it is no longer needed
            using (var context = new PharmacyContext())
            {
                //We use the Any method to check if any user in the database already has the provided email address.
                bool emailExists = context.Users.Any(u => u.Email == email);

                if (emailExists)
                {
                    // Email already exists, show an error message to the user
                    MessageBox.Show("Email already exists. Please choose a different email.");
                }
                else
                {
                    // Email is unique, proceed with user registration
                    if (password == confirmPassword)
                    {
                        // Create a new User object
                        var newUser = new User
                        {
                            Name = name,
                            Email = email,
                            Password = password
                        };

                        // Add the new user to the Users DbSet
                        context.Users.Add(newUser);

                        // Save changes to the database
                        context.SaveChanges();

                        // Display a success message or navigate to a success page
                        MessageBox.Show("Registration successful!");
                    }
                    else
                    {
                        // Passwords do not match, show an error message to the user
                        MessageBox.Show("Passwords do not match. Please try again.");
                    }
                }
            }
        }
    }
}
