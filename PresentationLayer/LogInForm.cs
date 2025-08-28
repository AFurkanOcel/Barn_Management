using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

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
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
