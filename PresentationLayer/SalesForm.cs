using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataAccessLayer;
using EntityLayer.Entities;

namespace PresentationLayer
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07837");
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            TransactionManager tm = new TransactionManager();
            var transactions = tm.GetAll();
            decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;
            balanceLbl.Text = lastBalance.ToString() + " $";


            dataGridViewTransactions.DataSource = transactions;

            dataGridViewTransactions.Columns["User"].Visible = false;
            dataGridViewTransactions.RowHeadersVisible = false;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewTransactions.ReadOnly = true;
            dataGridViewTransactions.AllowUserToAddRows = false;
            dataGridViewTransactions.AllowUserToDeleteRows = false;
            dataGridViewTransactions.AllowUserToOrderColumns = false;
            dataGridViewTransactions.AllowUserToResizeColumns = false;
            dataGridViewTransactions.AllowUserToResizeRows = false;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void balanceTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToInt32(balanceTxtBox.Text);

            if (amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount!");
                return;
            }

            else
            {
                if (!UserControl.Session.CurrentUserType)
                {
                    MessageBox.Show("Only admins can add balance!");
                    balanceTxtBox.Text = "00";
                    return;
                }

                balanceTxtBox.Text = "00";

                TransactionManager tm = new TransactionManager();

                var transactions = tm.GetAll();
                decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;
                decimal newBalance = lastBalance + amount;

                balanceLbl.Text = newBalance.ToString() + " $";

                Transaction transaction = new Transaction
                {
                    Balance = newBalance,
                    Operation = "Deposit",
                    Amount = amount,
                    Description = "Added balance",
                    Date = DateTime.Now,
                    UserID = UserControl.Session.CurrentUserId
                };

                tm.Insert(transaction);

                MessageBox.Show("Balance added successfully!");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            TransactionManager tm = new TransactionManager();
            var transactions = tm.GetAll();
            dataGridViewTransactions.DataSource = transactions;

            dataGridViewTransactions.Columns["User"].Visible = false;
            dataGridViewTransactions.RowHeadersVisible = false;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewTransactions.ReadOnly = true;
            dataGridViewTransactions.AllowUserToAddRows = false;
            dataGridViewTransactions.AllowUserToDeleteRows = false;
            dataGridViewTransactions.AllowUserToOrderColumns = false;
            dataGridViewTransactions.AllowUserToResizeColumns = false;
            dataGridViewTransactions.AllowUserToResizeRows = false;
        }
    }
}
