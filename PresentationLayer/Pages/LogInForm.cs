using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LogInForm : Form
    {
        public LogInForm(bool music)
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07837");


            string musicPath = Path.Combine(Application.StartupPath, "Audios", "Music.mp3");

            if (!music)
            {
                axWindowsMediaPlayer1.URL = musicPath;
                axWindowsMediaPlayer1.settings.setMode("loop", true);
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

            this.FormClosed += (s, args) => Application.Exit();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text.Length <= 0)
            {
                MessageBox.Show("Username cannot be empty!");
            }
            else if (passwordTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Password cannot be empty!");
            }
            else
            {
                BusinessLayer.UserManager userManager = new BusinessLayer.UserManager();
                var user = userManager.GetAll().FirstOrDefault(x => x.UserName == usernameTxtBox.Text);

                if (user != null)
                {
                    // Burada hash doğrulama yapıyoruz
                    bool isPasswordValid = Kript.VerifyPassword(passwordTextBox.Text, user.Password);

                    if (isPasswordValid)
                    {
                        GlobalAuth.CurrentUserId = user.UserID;
                        GlobalAuth.CurrentUserType = user.IsAdmin;

                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }


        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        public void SetMusicVolume()
        {
            if (MusicControl.IsCloseMusicButtonEnabled)
            {
                axWindowsMediaPlayer1.settings.volume = 0;
            }
            else
            {
                axWindowsMediaPlayer1.settings.volume = 100;
            }
        }
    }
}
