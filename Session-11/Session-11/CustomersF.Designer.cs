namespace Session_11
{
    partial class CustomersF
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
            this.GrdCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.Btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.Btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.Btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.CustomersFlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.GrdCustomersitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btncloseitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btndeleteitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnedititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnnewitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersFlayoutControl1ConvertedLayout)).BeginInit();
            this.CustomersFlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomersitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncloseitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btndeleteitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnedititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnnewitem)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdCustomers
            // 
            this.GrdCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdCustomers.Location = new System.Drawing.Point(12, 12);
            this.GrdCustomers.MainView = this.gridView1;
            this.GrdCustomers.Name = "GrdCustomers";
            this.GrdCustomers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.GrdCustomers.Size = new System.Drawing.Size(776, 400);
            this.GrdCustomers.TabIndex = 5;
            this.GrdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdCustomers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // Btnclose
            // 
            this.Btnclose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnclose.Location = new System.Drawing.Point(584, 416);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(204, 22);
            this.Btnclose.StyleController = this.CustomersFlayoutControl1ConvertedLayout;
            this.Btnclose.TabIndex = 9;
            this.Btnclose.Text = "Close";
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btndelete.Location = new System.Drawing.Point(396, 416);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(184, 22);
            this.Btndelete.StyleController = this.CustomersFlayoutControl1ConvertedLayout;
            this.Btndelete.TabIndex = 8;
            this.Btndelete.Text = "Delete";
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // Btnedit
            // 
            this.Btnedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnedit.Location = new System.Drawing.Point(213, 416);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(179, 22);
            this.Btnedit.StyleController = this.CustomersFlayoutControl1ConvertedLayout;
            this.Btnedit.TabIndex = 7;
            this.Btnedit.Text = "Edit";
            this.Btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // Btnnew
            // 
            this.Btnnew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnnew.Location = new System.Drawing.Point(12, 416);
            this.Btnnew.Name = "Btnnew";
            this.Btnnew.Size = new System.Drawing.Size(197, 22);
            this.Btnnew.StyleController = this.CustomersFlayoutControl1ConvertedLayout;
            this.Btnnew.TabIndex = 6;
            this.Btnnew.Text = "New";
            this.Btnnew.Click += new System.EventHandler(this.Btnnew_Click);
            // 
            // CustomersFlayoutControl1ConvertedLayout
            // 
            this.CustomersFlayoutControl1ConvertedLayout.Controls.Add(this.GrdCustomers);
            this.CustomersFlayoutControl1ConvertedLayout.Controls.Add(this.Btnclose);
            this.CustomersFlayoutControl1ConvertedLayout.Controls.Add(this.Btndelete);
            this.CustomersFlayoutControl1ConvertedLayout.Controls.Add(this.Btnedit);
            this.CustomersFlayoutControl1ConvertedLayout.Controls.Add(this.Btnnew);
            this.CustomersFlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersFlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.CustomersFlayoutControl1ConvertedLayout.Name = "CustomersFlayoutControl1ConvertedLayout";
            this.CustomersFlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.CustomersFlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(800, 450);
            this.CustomersFlayoutControl1ConvertedLayout.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.GrdCustomersitem,
            this.Btncloseitem,
            this.Btndeleteitem,
            this.Btnedititem,
            this.Btnnewitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // GrdCustomersitem
            // 
            this.GrdCustomersitem.Control = this.GrdCustomers;
            this.GrdCustomersitem.Location = new System.Drawing.Point(0, 0);
            this.GrdCustomersitem.Name = "GrdCustomersitem";
            this.GrdCustomersitem.Size = new System.Drawing.Size(780, 404);
            this.GrdCustomersitem.TextSize = new System.Drawing.Size(0, 0);
            this.GrdCustomersitem.TextVisible = false;
            // 
            // Btncloseitem
            // 
            this.Btncloseitem.Control = this.Btnclose;
            this.Btncloseitem.Location = new System.Drawing.Point(572, 404);
            this.Btncloseitem.Name = "Btncloseitem";
            this.Btncloseitem.Size = new System.Drawing.Size(208, 26);
            this.Btncloseitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btncloseitem.TextVisible = false;
            // 
            // Btndeleteitem
            // 
            this.Btndeleteitem.Control = this.Btndelete;
            this.Btndeleteitem.Location = new System.Drawing.Point(384, 404);
            this.Btndeleteitem.Name = "Btndeleteitem";
            this.Btndeleteitem.Size = new System.Drawing.Size(188, 26);
            this.Btndeleteitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btndeleteitem.TextVisible = false;
            // 
            // Btnedititem
            // 
            this.Btnedititem.Control = this.Btnedit;
            this.Btnedititem.Location = new System.Drawing.Point(201, 404);
            this.Btnedititem.Name = "Btnedititem";
            this.Btnedititem.Size = new System.Drawing.Size(183, 26);
            this.Btnedititem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnedititem.TextVisible = false;
            // 
            // Btnnewitem
            // 
            this.Btnnewitem.Control = this.Btnnew;
            this.Btnnewitem.Location = new System.Drawing.Point(0, 404);
            this.Btnnewitem.Name = "Btnnewitem";
            this.Btnnewitem.Size = new System.Drawing.Size(201, 26);
            this.Btnnewitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnnewitem.TextVisible = false;
            // 
            // CustomersF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomersFlayoutControl1ConvertedLayout);
            this.Name = "CustomersF";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersFlayoutControl1ConvertedLayout)).EndInit();
            this.CustomersFlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCustomersitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncloseitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btndeleteitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnedititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnnewitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btnclose;
        private DevExpress.XtraEditors.SimpleButton Btndelete;
        private DevExpress.XtraEditors.SimpleButton Btnedit;
        private DevExpress.XtraEditors.SimpleButton Btnnew;
        private System.Windows.Forms.BindingSource bsCustomers;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraLayout.LayoutControl CustomersFlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem GrdCustomersitem;
        private DevExpress.XtraLayout.LayoutControlItem Btncloseitem;
        private DevExpress.XtraLayout.LayoutControlItem Btndeleteitem;
        private DevExpress.XtraLayout.LayoutControlItem Btnedititem;
        private DevExpress.XtraLayout.LayoutControlItem Btnnewitem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}