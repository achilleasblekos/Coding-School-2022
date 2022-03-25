namespace Session_15
{
    partial class AddNewPetF
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.AnimalType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.Status = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtBreed = new DevExpress.XtraEditors.TextEdit();
            this.Breed = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.Price = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCost = new DevExpress.XtraEditors.TextEdit();
            this.Cost = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Breed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtCost);
            this.layoutControl1.Controls.Add(this.txtPrice);
            this.layoutControl1.Controls.Add(this.txtBreed);
            this.layoutControl1.Controls.Add(this.cmbStatus);
            this.layoutControl1.Controls.Add(this.cmbAnimalType);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(564, 409);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.AnimalType,
            this.Status,
            this.Breed,
            this.Price,
            this.Cost,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(564, 409);
            this.Root.TextVisible = false;
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(89, 12);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(443, 23);
            this.cmbAnimalType.TabIndex = 0;
            // 
            // AnimalType
            // 
            this.AnimalType.Control = this.cmbAnimalType;
            this.AnimalType.Location = new System.Drawing.Point(10, 0);
            this.AnimalType.Name = "AnimalType";
            this.AnimalType.Size = new System.Drawing.Size(514, 25);
            this.AnimalType.TextSize = new System.Drawing.Size(55, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 389);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(89, 37);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(443, 23);
            this.cmbStatus.TabIndex = 2;
            // 
            // Status
            // 
            this.Status.Control = this.cmbStatus;
            this.Status.Location = new System.Drawing.Point(10, 25);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(514, 25);
            this.Status.TextSize = new System.Drawing.Size(55, 13);
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(89, 62);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(134, 20);
            this.txtBreed.StyleController = this.layoutControl1;
            this.txtBreed.TabIndex = 3;
            // 
            // Breed
            // 
            this.Breed.Control = this.txtBreed;
            this.Breed.Location = new System.Drawing.Point(10, 50);
            this.Breed.Name = "Breed";
            this.Breed.Size = new System.Drawing.Size(205, 24);
            this.Breed.TextSize = new System.Drawing.Size(55, 13);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(89, 86);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(134, 20);
            this.txtPrice.StyleController = this.layoutControl1;
            this.txtPrice.TabIndex = 4;
            // 
            // Price
            // 
            this.Price.Control = this.txtPrice;
            this.Price.Location = new System.Drawing.Point(10, 74);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(205, 24);
            this.Price.TextSize = new System.Drawing.Size(55, 13);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(89, 110);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(134, 20);
            this.txtCost.StyleController = this.layoutControl1;
            this.txtCost.TabIndex = 5;
            // 
            // Cost
            // 
            this.Cost.Control = this.txtCost;
            this.Cost.Location = new System.Drawing.Point(10, 98);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(205, 24);
            this.Cost.TextSize = new System.Drawing.Size(55, 13);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(22, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(510, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancel;
            this.layoutControlItem6.Location = new System.Drawing.Point(10, 363);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(514, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(10, 122);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(205, 215);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(510, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSave;
            this.layoutControlItem7.Location = new System.Drawing.Point(10, 337);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(514, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(534, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(10, 389);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(215, 50);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(309, 287);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(524, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 389);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // AddNewPetF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 409);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddNewPetF";
            this.Text = "AddNewPetF";
            this.Load += new System.EventHandler(this.AddNewPetF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Breed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtCost;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtBreed;
        private ComboBox cmbStatus;
        private ComboBox cmbAnimalType;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem AnimalType;
        private DevExpress.XtraLayout.LayoutControlItem Status;
        private DevExpress.XtraLayout.LayoutControlItem Breed;
        private DevExpress.XtraLayout.LayoutControlItem Price;
        private DevExpress.XtraLayout.LayoutControlItem Cost;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}