using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AnimalForm : Form
    {
        public AnimalForm()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07837");

            string panelsColor = "#37B81F";
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel4.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel5.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {

        }
        private void AnimalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
