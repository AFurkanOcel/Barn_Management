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
using EntityLayer.Entities;

namespace PresentationLayer
{
    public partial class AnimalForm : Form
    {
        decimal cowPrice = 70;
        decimal sheepPrice = 35;
        decimal chickenPrice = 10;
        decimal dogPrice = 40;

        public AnimalForm()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07837");

            string panelsColor = "#37B81F";
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel4.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
            panel5.BackColor = System.Drawing.ColorTranslator.FromHtml(panelsColor);
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {
            TransactionManager tm = new TransactionManager();
            var transactions = tm.GetAll();
            decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;
            balanceLbl.Text = lastBalance.ToString() + " $";


            AnimalManager am = new AnimalManager();
            var animals = am.GetAll();
            dataGridViewAnimals.DataSource = animals;

            dataGridViewAnimals.RowHeadersVisible = false;
            dataGridViewAnimals.Columns["Progress"].Visible = false;
            dataGridViewAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewAnimals.ReadOnly = true;
            dataGridViewAnimals.AllowUserToAddRows = false;
            dataGridViewAnimals.AllowUserToDeleteRows = false;
            dataGridViewAnimals.AllowUserToOrderColumns = false;
            dataGridViewAnimals.AllowUserToResizeColumns = false;
            dataGridViewAnimals.AllowUserToResizeRows = false;
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

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (animalComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an animal type!");
            }

            else if (nameTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Name cannot be empty!");
            }

            else if (ageTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Age cannot be empty!");
            }

            else
            {
                TransactionManager tm = new TransactionManager();
                var transactions = tm.GetAll();
                decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;

                int age = int.Parse(ageTextBox.Text);

                if((animalComboBox.Text == "Cow") && (age < 0 || age > 20))
                {
                    MessageBox.Show("Cow age must be between 0 and 20!");
                    return;
                }

                if ((animalComboBox.Text == "Sheep") && (age < 0 || age > 10))
                {
                    MessageBox.Show("Sheep age must be between 0 and 10!");
                    return;
                }

                if ((animalComboBox.Text == "Chicken") && (age < 0 || age > 5))
                {
                    MessageBox.Show("Chicken age must be between 0 and 5!");
                    return;
                }

                if ((animalComboBox.Text == "Dog") && (age < 0 || age > 10))
                {
                    MessageBox.Show("Dog age must be between 0 and 10!");
                    return;
                }

                if (!UserControl.Session.CurrentUserType)
                {
                    MessageBox.Show("Only admins can add animals!");
                    animalComboBox.SelectedItem = null;
                    nameTextBox.Text = "";
                    ageTextBox.Text = "";
                    return;
                }

                if(animalComboBox.Text == "Cow" && lastBalance < cowPrice  ||  animalComboBox.Text == "Sheep" && lastBalance < sheepPrice  ||  animalComboBox.Text == "Chicken" && lastBalance < chickenPrice  ||  animalComboBox.Text == "Dog" && lastBalance < dogPrice)
                {
                    MessageBox.Show("Insufficient balance to buy this animal!");
                    return;
                }

                Animal newAnimal = new Animal
                {
                    Type = animalComboBox.Text,
                    Name = nameTextBox.Text,
                    Age = age,
                    IsAlive = true
                };

                AnimalManager am = new AnimalManager();
                int result = am.Insert(newAnimal);


                if (animalComboBox.Text == "Cow")
                {
                    lastBalance -= cowPrice;
                    balanceLbl.Text = lastBalance.ToString() + " $";

                    Transaction transaction = new Transaction
                    {
                        Balance = lastBalance,
                        Operation = "Purchase",
                        Amount = cowPrice,
                        Description = "Cow purchase",
                        Date = DateTime.Now,
                        UserID = UserControl.Session.CurrentUserId
                    };

                    tm.Insert(transaction);
                }
                else if (animalComboBox.Text == "Sheep")
                {
                    lastBalance -= sheepPrice;
                    balanceLbl.Text = lastBalance.ToString() + " $";

                    Transaction transaction = new Transaction
                    {
                        Balance = lastBalance,
                        Operation = "Purchase",
                        Amount = sheepPrice,
                        Description = "Sheep purchase",
                        Date = DateTime.Now,
                        UserID = UserControl.Session.CurrentUserId
                    };

                    tm.Insert(transaction);
                }
                else if (animalComboBox.Text == "Chicken")
                {
                    lastBalance -= chickenPrice;
                    balanceLbl.Text = lastBalance.ToString() + " $";

                    Transaction transaction = new Transaction
                    {
                        Balance = lastBalance,
                        Operation = "Purchase",
                        Amount = chickenPrice,
                        Description = "Chicken purchase",
                        Date = DateTime.Now,
                        UserID = UserControl.Session.CurrentUserId
                    };

                    tm.Insert(transaction);
                }
                else if (animalComboBox.Text == "Dog")
                {
                    lastBalance -= dogPrice;
                    balanceLbl.Text = lastBalance.ToString() + " $";

                    Transaction transaction = new Transaction
                    {
                        Balance = lastBalance,
                        Operation = "Purchase",
                        Amount = dogPrice,
                        Description = "Dog purchase",
                        Date = DateTime.Now,
                        UserID = UserControl.Session.CurrentUserId
                    };

                    tm.Insert(transaction);
                }

                animalComboBox.SelectedItem = null;
                nameTextBox.Text = "";
                ageTextBox.Text = "";
                MessageBox.Show("Animal added successfully!");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            AnimalManager am = new AnimalManager();
            var animals = am.GetAll();
            dataGridViewAnimals.DataSource = animals;

            dataGridViewAnimals.RowHeadersVisible = false;
            dataGridViewAnimals.Columns["Progress"].Visible = false;
            dataGridViewAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewAnimals.ReadOnly = true;
            dataGridViewAnimals.AllowUserToAddRows = false;
            dataGridViewAnimals.AllowUserToDeleteRows = false;
            dataGridViewAnimals.AllowUserToOrderColumns = false;
            dataGridViewAnimals.AllowUserToResizeColumns = false;
            dataGridViewAnimals.AllowUserToResizeRows = false;
        }
    }
}
