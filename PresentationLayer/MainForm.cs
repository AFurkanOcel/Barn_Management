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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07837");

            string panelsColor = "#37B81F";
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel4.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
