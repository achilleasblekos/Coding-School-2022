namespace Session_11
{
    partial class PetShopForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petFoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.petsToolStripMenuItem,
            this.petFoodsToolStripMenuItem,
            this.monthlyLedgerToolStripMenuItem,
            this.petReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(770, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // petsToolStripMenuItem
            // 
            this.petsToolStripMenuItem.Name = "petsToolStripMenuItem";
            this.petsToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.petsToolStripMenuItem.Text = "Pets";
            this.petsToolStripMenuItem.Click += new System.EventHandler(this.petsToolStripMenuItem_Click);
            // 
            // petFoodsToolStripMenuItem
            // 
            this.petFoodsToolStripMenuItem.Name = "petFoodsToolStripMenuItem";
            this.petFoodsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.petFoodsToolStripMenuItem.Text = "PetFoods";
            this.petFoodsToolStripMenuItem.Click += new System.EventHandler(this.petFoodsToolStripMenuItem_Click);
            // 
            // monthlyLedgerToolStripMenuItem
            // 
            this.monthlyLedgerToolStripMenuItem.Name = "monthlyLedgerToolStripMenuItem";
            this.monthlyLedgerToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.monthlyLedgerToolStripMenuItem.Text = "MonthlyLedger";
            this.monthlyLedgerToolStripMenuItem.Click += new System.EventHandler(this.monthlyLedgerToolStripMenuItem_Click_1);
            // 
            // petReportToolStripMenuItem
            // 
            this.petReportToolStripMenuItem.Name = "petReportToolStripMenuItem";
            this.petReportToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.petReportToolStripMenuItem.Text = "PetReport";
            this.petReportToolStripMenuItem.Click += new System.EventHandler(this.petReportToolStripMenuItem_Click_1);
            // 
            // PetShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 465);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PetShopForm";
            this.Text = "PetShop";
            this.Load += new System.EventHandler(this.PetShopForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem petsToolStripMenuItem;
        private ToolStripMenuItem petFoodsToolStripMenuItem;
        private ToolStripMenuItem monthlyLedgerToolStripMenuItem;
        private ToolStripMenuItem petReportToolStripMenuItem;
    }
}