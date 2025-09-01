namespace PresentationLayer
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.menuBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.balanceTxtBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.balancePicBox = new System.Windows.Forms.PictureBox();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.balancePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuBtn.Location = new System.Drawing.Point(879, 12);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(91, 30);
            this.menuBtn.TabIndex = 15;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "Balance:";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBtn.Location = new System.Drawing.Point(457, 71);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 54);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // balanceTxtBox
            // 
            this.balanceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.balanceTxtBox.ForeColor = System.Drawing.Color.Black;
            this.balanceTxtBox.Location = new System.Drawing.Point(279, 72);
            this.balanceTxtBox.Name = "balanceTxtBox";
            this.balanceTxtBox.Size = new System.Drawing.Size(156, 53);
            this.balanceTxtBox.TabIndex = 20;
            this.balanceTxtBox.Text = "00";
            this.balanceTxtBox.TextChanged += new System.EventHandler(this.balanceTxtBox_TextChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateBtn.Location = new System.Drawing.Point(757, 74);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(169, 54);
            this.updateBtn.TabIndex = 21;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.balanceLbl.Location = new System.Drawing.Point(106, 17);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(54, 25);
            this.balanceLbl.TabIndex = 23;
            this.balanceLbl.Text = "00 $";
            // 
            // balancePicBox
            // 
            this.balancePicBox.Image = ((System.Drawing.Image)(resources.GetObject("balancePicBox.Image")));
            this.balancePicBox.Location = new System.Drawing.Point(54, 12);
            this.balancePicBox.Name = "balancePicBox";
            this.balancePicBox.Size = new System.Drawing.Size(46, 30);
            this.balancePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balancePicBox.TabIndex = 22;
            this.balancePicBox.TabStop = false;
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.AllowUserToAddRows = false;
            this.dataGridViewTransactions.AllowUserToDeleteRows = false;
            this.dataGridViewTransactions.AllowUserToResizeColumns = false;
            this.dataGridViewTransactions.AllowUserToResizeRows = false;
            this.dataGridViewTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(54, 150);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.ReadOnly = true;
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.RowTemplate.Height = 24;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(872, 360);
            this.dataGridViewTransactions.TabIndex = 24;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Controls.Add(this.balanceLbl);
            this.Controls.Add(this.balancePicBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.balanceTxtBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balancePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox balanceTxtBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.PictureBox balancePicBox;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
    }
}