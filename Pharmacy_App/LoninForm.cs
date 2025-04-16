using Pharmacy_App.Models;
using Pharmacy_App_1;

namespace Pharmacy_App
{
    public partial class LoninForm : Form
    {
        public LoninForm()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register_Page register_Page = new Register_Page();
            this.Hide();
            register_Page.ShowDialog();
            this.Close();
        }
        
        private void LoginClick(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            /*  if (result == DialogResult.OK)
              {
                  Register_Page register_Page = new Register_Page();
                  this.Hide();
                  register_Page.Show();
                  this.Close();

              }*/

            using (var context = new PharmacyContext())
            {
                //FirstOrDefault--->This part of the query tells LINQ to retrieve the first user that meets the specified conditions.
                var user = context.Users
                .FirstOrDefault(u => u.Name == username && u.Password == password);
               
                if (user != null)
                {
                    // Valid credentials; open the MainForm
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Hide();
                    this.Close();
                    MessageBox.Show("Welcom back");
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }


            }



        }


    }
}
