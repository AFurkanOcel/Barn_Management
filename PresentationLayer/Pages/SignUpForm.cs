using System;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07837");

            this.FormClosed += (s, args) => Application.Exit();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm(true);
            logInForm.Show();
            this.Hide();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            BusinessLayer.UserManager userManager = new BusinessLayer.UserManager();

            if (usernameTxtBox.Text.Length <= 0)
            {
                MessageBox.Show("Username cannot be empty!");
            }
            else if (userManager.GetAll().Any(x => x.UserName == usernameTxtBox.Text))
            {
                MessageBox.Show("This username is already taken!");
            }
            else if (passwordTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Password cannot be empty!");
            }
            else if (passwordTextBox2.Text.Length <= 0)
            {
                MessageBox.Show("Please confirm your password!");
            }
            else if (passwordTextBox.Text != passwordTextBox2.Text)
            {
                MessageBox.Show("Passwords do not match!");
            }
            else
            {
                string hashedPassword = Hashing.HashPassword(passwordTextBox.Text);

                EntityLayer.Entities.User user = new EntityLayer.Entities.User();
                user.UserName = usernameTxtBox.Text;
                user.Password = hashedPassword;

                if (userRadioBtn.Checked)
                {
                    user.IsAdmin = false;
                }
                else
                {
                    user.IsAdmin = true;
                }

                userManager.Insert(user);
                MessageBox.Show("User registered successfully!");
                LogInForm logInForm = new LogInForm(true);
                logInForm.Show();
                this.Hide();
            }
        }
    }
}
