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
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace PresentationLayer
{
    public partial class ProductsForm : Form
    {
        private Timer timer;
        private Timer age;

        public ProductsForm()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F07837");

            timer = new Timer();
            timer.Interval = 200;
            timer.Tick += (s, e) => ProgressTimer();
            timer.Start();

            age = new Timer();
            age.Interval = 40000;
            age.Tick += (s, e) => AgeTimer();
            age.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            TransactionManager tm = new TransactionManager();
            var transactions = tm.GetAll();
            decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;
            balanceLbl.Text = lastBalance.ToString() + " $";

            // Products
            ProductManager pm = new ProductManager();
            var products = pm.GetAll();
            dataGridViewProducts.DataSource = products;

            if (dataGridViewProducts.Rows.Count == 0)
            {
                Product milk = new Product
                {
                    ProductName = "Milk",
                    Quantity = 0,
                    UnitPrice = 0.3m,
                    TotalPrice = 0
                };

                Product wool = new Product
                {
                    ProductName = "Wool",
                    Quantity = 0,
                    UnitPrice = 0.9m,
                    TotalPrice = 0
                };

                Product egg = new Product
                {
                    ProductName = "Egg",
                    Quantity = 0,
                    UnitPrice = 0.2m,
                    TotalPrice = 0
                };

                pm.Insert(milk);
                pm.Insert(wool);
                pm.Insert(egg);
            }

            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToOrderColumns = false;
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AllowUserToResizeRows = false;


            // Animals
            AnimalManager am = new AnimalManager();
            var animals = am.GetAll();
            dataGridViewAnimals.DataSource = animals;

            dataGridViewAnimals.Columns["Progress"].HeaderText = "Progress(%)";

            dataGridViewAnimals.RowHeadersVisible = false;
            dataGridViewAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewAnimals.ReadOnly = true;
            dataGridViewAnimals.AllowUserToAddRows = false;
            dataGridViewAnimals.AllowUserToDeleteRows = false;
            dataGridViewAnimals.AllowUserToOrderColumns = false;
            dataGridViewAnimals.AllowUserToResizeColumns = false;
            dataGridViewAnimals.AllowUserToResizeRows = false;
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            TransactionManager tm = new TransactionManager();
            var transactions = tm.GetAll();
            decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;

            decimal cowAmount = 70;
            decimal sheepAmount = 35;
            decimal chickenAmount = 10;
            decimal dogAmount = 40;

            if (ıdTextBox.Text == "")
            {
                MessageBox.Show("Please enter an ID.");
                return;
            }

            if (!UserControl.Session.CurrentUserType)
            {
                MessageBox.Show("Only admins can sell animals!");
            }

            int id;
            bool isId = int.TryParse(ıdTextBox.Text, out id);
            if (!isId)
            {
                MessageBox.Show("ID must be a number.");
                return;
            }

            id = int.Parse(ıdTextBox.Text);
            AnimalManager am = new AnimalManager();
            var animal = am.GetById(id);
            if (animal == null)
            {
                MessageBox.Show("No animal found with the given ID.");
                return;
            }

            if (animal.IsAlive == false)
            {
                MessageBox.Show($"{animal.Name}'s carcass was removed for $0");
            }
            else
            {
                if (animal.Type == "Cow")
                {
                    lastBalance += cowAmount;
                    balanceLbl.Text = lastBalance.ToString() + " $";

                    MessageBox.Show($"{animal.Name} was sold for 70$");

                    Transaction transaction = new Transaction
                    {
                        Balance = lastBalance,
                        Operation = "Sale",
                        Amount = cowAmount,
                        Description = "Cow sale",
                        Date = DateTime.Now,
                        UserID = UserControl.Session.CurrentUserId
                    };
                    tm.Insert(transaction);
                }

                else if (animal.Type == "Sheep")
                {
                    lastBalance += sheepAmount;
                    balanceLbl.Text = lastBalance.ToString() + " $";

                    MessageBox.Show($"{animal.Name} was sold for 35$");

                    Transaction transaction = new Transaction
                    {
                        Balance = lastBalance,
                        Operation = "Sale",
                        Amount = sheepAmount,
                        Description = "Sheep sale",
                        Date = DateTime.Now,
                        UserID = UserControl.Session.CurrentUserId
                    };
                    tm.Insert(transaction);
                }

                else if (animal.Type == "Chicken")
                {
                    lastBalance += chickenAmount;
                    balanceLbl.Text = lastBalance.ToString() + " $";

                    MessageBox.Show($"{animal.Name} was sold for 10$");

                    Transaction transaction = new Transaction
                    {
                        Balance = lastBalance,
                        Operation = "Sale",
                        Amount = chickenAmount,
                        Description = "Chicken sale",
                        Date = DateTime.Now,
                        UserID = UserControl.Session.CurrentUserId
                    };
                    tm.Insert(transaction);
                }

                else if (animal.Type == "Dog")
                {
                    lastBalance += dogAmount;
                    balanceLbl.Text = lastBalance.ToString() + " $";

                    MessageBox.Show($"{animal.Name} was sold for 40$");

                    Transaction transaction = new Transaction
                    {
                        Balance = lastBalance,
                        Operation = "Sale",
                        Amount = dogAmount,
                        Description = "Dog sale",
                        Date = DateTime.Now,
                        UserID = UserControl.Session.CurrentUserId
                    };
                    tm.Insert(transaction);
                }
            }

            am.Delete(animal);
            ıdTextBox.Text = "";
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            if (ıdTextBox.Text == "")
            {
                MessageBox.Show("Please enter an ID.");
                return;
            }

            int id;
            bool isId = int.TryParse(ıdTextBox.Text, out id);
            if (!isId)
            {
                MessageBox.Show("ID must be a number.");
                return;
            }

            id = int.Parse(ıdTextBox.Text);
            AnimalManager am = new AnimalManager();
            var animal = am.GetById(id);
            if (animal == null)
            {
                MessageBox.Show("No animal found with the given ID.");
                return;
            }

            dataGridViewAnimals.DataSource = new List<Animal> { animal };
            ıdTextBox.Text = "";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            AnimalManager am = new AnimalManager();
            var animals = am.GetAll();
            dataGridViewAnimals.DataSource = animals;

            dataGridViewAnimals.Columns["Progress"].HeaderText = "Progress(%)";

            dataGridViewAnimals.RowHeadersVisible = false;
            dataGridViewAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewAnimals.ReadOnly = true;
            dataGridViewAnimals.AllowUserToAddRows = false;
            dataGridViewAnimals.AllowUserToDeleteRows = false;
            dataGridViewAnimals.AllowUserToOrderColumns = false;
            dataGridViewAnimals.AllowUserToResizeColumns = false;
            dataGridViewAnimals.AllowUserToResizeRows = false;
        }

        private void sellBtn2_Click(object sender, EventArgs e)
        {
            ProductManager pm = new ProductManager();
            var products = pm.GetAll();

            Product milk = null;
            Product wool = null;
            Product egg = null;

            foreach (var p in products)
            {
                if (p.ProductName == "Milk")
                    milk = p;
                else if (p.ProductName == "Wool")
                    wool = p;
                else if (p.ProductName == "Egg")
                    egg = p;
            }

            if (productsComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            if (!UserControl.Session.CurrentUserType)
            {
                MessageBox.Show("Only admins can sell products!");
            }
            if (productsComboBox.Text == "All")
            {
                if (milk.Quantity == 0 && wool.Quantity == 0 && egg.Quantity == 0)
                {
                    MessageBox.Show("No products available to sell.");
                    return;
                }

                TransactionManager tm = new TransactionManager();
                var transactions = tm.GetAll();
                decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;

                lastBalance += milk.TotalPrice;
                lastBalance += wool.TotalPrice;
                lastBalance += egg.TotalPrice;
                balanceLbl.Text = lastBalance.ToString() + " $";

                MessageBox.Show($"All products sold for {milk.TotalPrice + wool.TotalPrice + egg.TotalPrice}$");

                Transaction transaction = new Transaction
                {
                    Balance = lastBalance,
                    Operation = "Sale",
                    Amount = milk.TotalPrice + wool.TotalPrice + egg.TotalPrice,
                    Description = "All sale",
                    Date = DateTime.Now,
                    UserID = UserControl.Session.CurrentUserId
                };
                tm.Insert(transaction);
                productsComboBox.Text = "";

                Product lastMilk = pm.GetAll().FirstOrDefault(p => p.ProductName == "Milk");
                lastMilk.Quantity = 0;
                lastMilk.TotalPrice = 0;
                pm.Update(lastMilk);

                Product lastWool = pm.GetAll().FirstOrDefault(p => p.ProductName == "Wool");
                lastWool.Quantity = 0;
                lastWool.TotalPrice = 0;
                pm.Update(lastWool);

                Product lastEgg = pm.GetAll().FirstOrDefault(p => p.ProductName == "Egg");
                lastEgg.Quantity = 0;
                lastEgg.TotalPrice = 0;
                pm.Update(lastEgg);
            }
            if (productsComboBox.Text == "Milk")
            {
                if (milk.Quantity == 0)
                {
                    MessageBox.Show("No milk available to sell.");
                    return;
                }

                TransactionManager tm = new TransactionManager();
                var transactions = tm.GetAll();
                decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;

                lastBalance += milk.TotalPrice;
                balanceLbl.Text = lastBalance.ToString() + " $";

                MessageBox.Show($"{milk.Quantity} milks sold for {milk.TotalPrice}$");

                Transaction transaction = new Transaction
                {
                    Balance = lastBalance,
                    Operation = "Sale",
                    Amount = milk.TotalPrice,
                    Description = "Milk sale",
                    Date = DateTime.Now,
                    UserID = UserControl.Session.CurrentUserId
                };
                tm.Insert(transaction);
                productsComboBox.Text = "";

                Product lastMilk = pm.GetAll().FirstOrDefault(p => p.ProductName == "Milk");
                lastMilk.Quantity = 0;
                lastMilk.TotalPrice = 0;
                pm.Update(lastMilk);
            }
            if (productsComboBox.Text == "Wool")
            {
                if (wool.Quantity == 0)
                {
                    MessageBox.Show("No wool available to sell.");
                    return;
                }

                TransactionManager tm = new TransactionManager();
                var transactions = tm.GetAll();
                decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;

                lastBalance += wool.TotalPrice;
                balanceLbl.Text = lastBalance.ToString() + " $";

                MessageBox.Show($"{wool.Quantity} wools sold for {wool.TotalPrice}$");

                Transaction transaction = new Transaction
                {
                    Balance = lastBalance,
                    Operation = "Sale",
                    Amount = wool.TotalPrice,
                    Description = "Wool sale",
                    Date = DateTime.Now,
                    UserID = UserControl.Session.CurrentUserId
                };
                tm.Insert(transaction);
                productsComboBox.Text = "";

                Product lastWool = pm.GetAll().FirstOrDefault(p => p.ProductName == "Wool");
                lastWool.Quantity = 0;
                lastWool.TotalPrice = 0;
                pm.Update(lastWool);
            }
            if (productsComboBox.Text == "Egg")
            {
                if (egg.Quantity == 0)
                {
                    MessageBox.Show("No eggs available to sell.");
                    return;
                }

                TransactionManager tm = new TransactionManager();
                var transactions = tm.GetAll();
                decimal lastBalance = transactions.Any() ? transactions.OrderByDescending(t => t.Date).First().Balance : 0;

                lastBalance += egg.TotalPrice;
                balanceLbl.Text = lastBalance.ToString() + " $";

                MessageBox.Show($"{egg.Quantity} eggs sold for {egg.TotalPrice}$");

                Transaction transaction = new Transaction
                {
                    Balance = lastBalance,
                    Operation = "Sale",
                    Amount = egg.TotalPrice,
                    Description = "Egg sale",
                    Date = DateTime.Now,
                    UserID = UserControl.Session.CurrentUserId
                };
                tm.Insert(transaction);
                productsComboBox.Text = "";

                Product lastEgg = pm.GetAll().FirstOrDefault(p => p.ProductName == "Egg");
                lastEgg.Quantity = 0;
                lastEgg.TotalPrice = 0;
                pm.Update(lastEgg);
            }
        }

        private void updateBtn2_Click(object sender, EventArgs e)
        {
            ProductManager pm = new ProductManager();
            var products = pm.GetAll();
            dataGridViewProducts.DataSource = products;

            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToOrderColumns = false;
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
        }

        public void AgeTimer()
        {
            AnimalManager am = new AnimalManager();
            var animals = am.GetAll();

            foreach (var animal in animals)
            {
                int dogCount = animals.Count(a => a.Type == "Dog" && a.IsAlive);
                if (dogCount == 0)
                {
                    if (animal.Type == "Cow")
                    {
                        if (animal.Age >= 20)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Sheep")
                    {
                        if (animal.Age >= 10)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Chicken")
                    {
                        if (animal.Age >= 5)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Dog")
                    {
                        if (animal.Age >= 10)
                            animal.IsAlive = false;
                    }
                }

                if (dogCount == 1)
                {
                    if (animal.Type == "Cow")
                    {
                        if (animal.Age >= 22)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Sheep")
                    {
                        if (animal.Age >= 12)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Chicken")
                    {
                        if (animal.Age >= 7)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Dog")
                    {
                        if (animal.Age >= 10)
                            animal.IsAlive = false;
                    }
                }

                if (dogCount == 2)
                {
                    if (animal.Type == "Cow")
                    {
                        if (animal.Age >= 24)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Sheep")
                    {
                        if (animal.Age >= 14)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Chicken")
                    {
                        if (animal.Age >= 9)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Dog")
                    {
                        if (animal.Age >= 10)
                            animal.IsAlive = false;
                    }
                }

                if (dogCount >= 3)
                {
                    if (animal.Type == "Cow")
                    {
                        if (animal.Age >= 25)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Sheep")
                    {
                        if (animal.Age >= 15)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Chicken")
                    {
                        if (animal.Age >= 10)
                            animal.IsAlive = false;
                    }
                    if (animal.Type == "Dog")
                    {
                        if (animal.Age >= 10)
                            animal.IsAlive = false;
                    }
                }

                if (animal.IsAlive)
                {
                    animal.Age += 1;
                }
                am.Update(animal);
            }
        }

        public void ProgressTimer()
        {
            AnimalManager am = new AnimalManager();
            ProductManager pm = new ProductManager();

            var animals = am.GetAll();
            var products = pm.GetAll();

            Product milk = null;
            Product wool = null;
            Product egg = null;

            foreach (var p in products)
            {
                if (p.ProductName == "Milk")
                    milk = p;
                else if (p.ProductName == "Wool")
                    wool = p;
                else if (p.ProductName == "Egg")
                    egg = p;

                if (milk != null && wool != null && egg != null)
                    break;
            }

            for (int i = 0; i < animals.Count; i++)
            {
                var animal = animals[i];

                if (!animal.IsAlive)
                    continue;

                switch (animal.Type)
                {
                    case "Cow": animal.Progress += 2; break;
                    case "Sheep": animal.Progress += 1; break;
                    case "Chicken": animal.Progress += 3; break;
                }

                if (animal.Progress >= 100)
                {
                    animal.Progress = 0;

                    switch (animal.Type)
                    {
                        case "Cow":
                            if (milk != null)
                            {
                                milk.Quantity += 1;
                                milk.TotalPrice = milk.Quantity * milk.UnitPrice;
                                pm.Update(milk);
                            }
                            break;

                        case "Sheep":
                            if (wool != null)
                            {
                                wool.Quantity += 1;
                                wool.TotalPrice = wool.Quantity * wool.UnitPrice;
                                pm.Update(wool);
                            }
                            break;

                        case "Chicken":
                            if (egg != null)
                            {
                                egg.Quantity += 1;
                                egg.TotalPrice = egg.Quantity * egg.UnitPrice;
                                pm.Update(egg);
                            }
                            break;
                    }
                }

                am.Update(animal);

                if (i < dataGridViewAnimals.Rows.Count)
                {
                    dataGridViewAnimals.Rows[i].Cells["Progress"].Value = animal.Progress;
                    dataGridViewAnimals.Rows[i].Cells["Age"].Value = animal.Age;
                    dataGridViewAnimals.Rows[i].Cells["IsAlive"].Value = animal.IsAlive;
                }
            }

            for (int i = 0; i < products.Count; i++)
            {
                if (i < dataGridViewProducts.Rows.Count)
                {
                    dataGridViewProducts.Rows[i].Cells["Quantity"].Value = products[i].Quantity;
                    dataGridViewProducts.Rows[i].Cells["TotalPrice"].Value = products[i].TotalPrice;
                }
            }
        }

    }
}