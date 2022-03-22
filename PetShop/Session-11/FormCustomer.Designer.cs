namespace Session_11
{
    partial class FormCustomer
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
            this.components = new System.ComponentModel.Container();
            this.gridCustomerList = new DevExpress.XtraGrid.GridControl();
            this.gridViewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlFullname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlTIN = new DevExpress.XtraEditors.TextEdit();
            this.ctrlPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.FullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.Surname = new DevExpress.XtraLayout.LayoutControlItem();
            this.TelephoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.TIN = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Surname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCustomerList
            // 
            this.gridCustomerList.Location = new System.Drawing.Point(12, 142);
            this.gridCustomerList.MainView = this.gridViewCustomers;
            this.gridCustomerList.Name = "gridCustomerList";
            this.gridCustomerList.Size = new System.Drawing.Size(781, 234);
            this.gridCustomerList.TabIndex = 6;
            this.gridCustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});
            // 
            // gridViewCustomers
            // 
            this.gridViewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridName,
            this.gridSurname,
            this.gridPhone,
            this.gridTIN});
            this.gridViewCustomers.GridControl = this.gridCustomerList;
            this.gridViewCustomers.Name = "gridViewCustomers";
            this.gridViewCustomers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCustomers_FocusedRowChanged);
            // 
            // gridName
            // 
            this.gridName.Caption = "Name";
            this.gridName.FieldName = "Name";
            this.gridName.MinWidth = 25;
            this.gridName.Name = "gridName";
            this.gridName.Visible = true;
            this.gridName.VisibleIndex = 0;
            this.gridName.Width = 94;
            // 
            // gridSurname
            // 
            this.gridSurname.Caption = "Surname";
            this.gridSurname.FieldName = "Surname";
            this.gridSurname.MinWidth = 25;
            this.gridSurname.Name = "gridSurname";
            this.gridSurname.Visible = true;
            this.gridSurname.VisibleIndex = 1;
            this.gridSurname.Width = 94;
            // 
            // gridPhone
            // 
            this.gridPhone.Caption = "Phone";
            this.gridPhone.FieldName = "PhoneNumber";
            this.gridPhone.MinWidth = 25;
            this.gridPhone.Name = "gridPhone";
            this.gridPhone.Visible = true;
            this.gridPhone.VisibleIndex = 2;
            this.gridPhone.Width = 94;
            // 
            // gridTIN
            // 
            this.gridTIN.Caption = "TIN";
            this.gridTIN.FieldName = "Tin";
            this.gridTIN.MinWidth = 25;
            this.gridTIN.Name = "gridTIN";
            this.gridTIN.Visible = true;
            this.gridTIN.VisibleIndex = 3;
            this.gridTIN.Width = 94;
            // 
            // bsCustomers
            // 
            this.bsCustomers.CurrentChanged += new System.EventHandler(this.bindingPetShopCustomers_CurrentChanged);
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(129, 38);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(76, 22);
            this.ctrlName.StyleController = this.layoutControl1;
            this.ctrlName.TabIndex = 2;
            this.ctrlName.EditValueChanged += new System.EventHandler(this.ctrlName_EditValueChanged);
            this.ctrlName.TextChanged += new System.EventHandler(this.ctrlName_TextChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnNew);
            this.layoutControl1.Controls.Add(this.ctrlFullname);
            this.layoutControl1.Controls.Add(this.gridCustomerList);
            this.layoutControl1.Controls.Add(this.ctrlTIN);
            this.layoutControl1.Controls.Add(this.ctrlPhoneNumber);
            this.layoutControl1.Controls.Add(this.ctrlName);
            this.layoutControl1.Controls.Add(this.ctrlSurname);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(805, 450);
            this.layoutControl1.TabIndex = 15;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(404, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(389, 27);
            this.btnClose.StyleController = this.layoutControl1;
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(12, 411);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(388, 27);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(404, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(389, 27);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Location = new System.Drawing.Point(12, 380);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(388, 27);
            this.btnNew.StyleController = this.layoutControl1;
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ctrlFullname
            // 
            this.ctrlFullname.Location = new System.Drawing.Point(129, 12);
            this.ctrlFullname.Name = "ctrlFullname";
            this.ctrlFullname.Size = new System.Drawing.Size(120, 22);
            this.ctrlFullname.StyleController = this.layoutControl1;
            this.ctrlFullname.TabIndex = 0;
            // 
            // ctrlTIN
            // 
            this.ctrlTIN.Location = new System.Drawing.Point(129, 116);
            this.ctrlTIN.Name = "ctrlTIN";
            this.ctrlTIN.Size = new System.Drawing.Size(66, 22);
            this.ctrlTIN.StyleController = this.layoutControl1;
            this.ctrlTIN.TabIndex = 5;
            // 
            // ctrlPhoneNumber
            // 
            this.ctrlPhoneNumber.Location = new System.Drawing.Point(129, 90);
            this.ctrlPhoneNumber.Name = "ctrlPhoneNumber";
            this.ctrlPhoneNumber.Size = new System.Drawing.Size(66, 22);
            this.ctrlPhoneNumber.StyleController = this.layoutControl1;
            this.ctrlPhoneNumber.TabIndex = 4;
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(129, 64);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(76, 22);
            this.ctrlSurname.StyleController = this.layoutControl1;
            this.ctrlSurname.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.FullName,
            this.Name,
            this.Surname,
            this.TelephoneNumber,
            this.TIN,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.emptySpaceItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(805, 450);
            this.Root.TextVisible = false;
            // 
            // FullName
            // 
            this.FullName.Control = this.ctrlFullname;
            this.FullName.Location = new System.Drawing.Point(0, 0);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(241, 26);
            this.FullName.TextSize = new System.Drawing.Size(105, 16);
            // 
            // Name
            // 
            this.Name.Control = this.ctrlName;
            this.Name.Location = new System.Drawing.Point(0, 26);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(197, 26);
            this.Name.TextSize = new System.Drawing.Size(105, 16);
            // 
            // Surname
            // 
            this.Surname.Control = this.ctrlSurname;
            this.Surname.Location = new System.Drawing.Point(0, 52);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(197, 26);
            this.Surname.TextSize = new System.Drawing.Size(105, 16);
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.Control = this.ctrlPhoneNumber;
            this.TelephoneNumber.Location = new System.Drawing.Point(0, 78);
            this.TelephoneNumber.Name = "TelephoneNumber";
            this.TelephoneNumber.Size = new System.Drawing.Size(187, 26);
            this.TelephoneNumber.TextSize = new System.Drawing.Size(105, 16);
            // 
            // TIN
            // 
            this.TIN.Control = this.ctrlTIN;
            this.TIN.Location = new System.Drawing.Point(0, 104);
            this.TIN.Name = "TIN";
            this.TIN.Size = new System.Drawing.Size(187, 26);
            this.TIN.TextSize = new System.Drawing.Size(105, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridCustomerList;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(785, 238);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnNew;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 368);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(392, 31);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSave;
            this.layoutControlItem8.Location = new System.Drawing.Point(392, 368);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(393, 31);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnDelete;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 399);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(392, 31);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnClose;
            this.layoutControlItem10.Location = new System.Drawing.Point(392, 399);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(393, 31);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(241, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(544, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(197, 26);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(588, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(197, 52);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(588, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(392, 78);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(393, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(392, 104);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(393, 26);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(187, 91);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(205, 39);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(187, 78);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(205, 13);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.layoutControl1);
            //this.Name = "FormCustomer";
            this.Text = "FormCustomers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomer_FormClosing);
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Surname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCustomerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn gridName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridTIN;
        private BindingSource bsCustomers;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlFullname;
        private DevExpress.XtraEditors.TextEdit ctrlTIN;
        private DevExpress.XtraEditors.TextEdit ctrlPhoneNumber;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem FullName;
        private DevExpress.XtraLayout.LayoutControlItem Name;
        private DevExpress.XtraLayout.LayoutControlItem Surname;
        private DevExpress.XtraLayout.LayoutControlItem TelephoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem TIN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
    }
}