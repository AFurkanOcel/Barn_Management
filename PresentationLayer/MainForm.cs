using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07837");
            string panelsColor = "#37B81F";
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel4.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);

            this.FormClosed += (s, args) => Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TransactionManager tm = new TransactionManager();
            var transactions = tm.GetAll();
            decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;
            balanceLbl.Text = lastBalance.ToString() + " $";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalForm animalForm = new AnimalForm();
            animalForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settingsform settingsForm = new Settingsform();
            settingsForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.Show();
            this.Hide();
        }
    }
}
