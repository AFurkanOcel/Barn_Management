using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Settingsform : Form
    {
        public Settingsform()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07837");

            this.FormClosed += (s, args) => Application.Exit();
        }
        private void Settingsform_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        public void openMusicBtn_Click(object sender, EventArgs e)
        {
            MusicControl.IsCloseMusicButtonEnabled = false;
            ((LogInForm)Application.OpenForms["LogInForm"]).SetMusicVolume();
        }

        public void closeMusicBtn_Click(object sender, EventArgs e)
        {
            MusicControl.IsCloseMusicButtonEnabled = true;
            ((LogInForm)Application.OpenForms["LogInForm"]).SetMusicVolume();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm(true);
            logInForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you really want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
