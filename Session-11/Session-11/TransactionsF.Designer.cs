namespace Session_11
{
    partial class TransactionsF
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
            this.GrdTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.CarLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ManagerLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.CustomerLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsCarColumns = new System.Windows.Forms.BindingSource(this.components);
            this.Btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.Btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.Btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.bsManagerColumns = new System.Windows.Forms.BindingSource(this.components);
            this.bsCustomerColumns = new System.Windows.Forms.BindingSource(this.components);
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.TransactionsFlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.GrdTransactionsitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btncloseitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btndeleteitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnnewitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCarColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManagerColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsFlayoutControl1ConvertedLayout)).BeginInit();
            this.TransactionsFlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransactionsitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncloseitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btndeleteitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnnewitem)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdTransactions
            // 
            this.GrdTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdTransactions.Location = new System.Drawing.Point(12, 12);
            this.GrdTransactions.MainView = this.gridView1;
            this.GrdTransactions.Name = "GrdTransactions";
            this.GrdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.CarLookUp,
            this.ManagerLookUp,
            this.CustomerLookUp});
            this.GrdTransactions.Size = new System.Drawing.Size(776, 400);
            this.GrdTransactions.TabIndex = 15;
            this.GrdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdTransactions;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // CarLookUp
            // 
            this.CarLookUp.AutoHeight = false;
            this.CarLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CarLookUp.Name = "CarLookUp";
            // 
            // ManagerLookUp
            // 
            this.ManagerLookUp.AutoHeight = false;
            this.ManagerLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ManagerLookUp.Name = "ManagerLookUp";
            // 
            // CustomerLookUp
            // 
            this.CustomerLookUp.AutoHeight = false;
            this.CustomerLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerLookUp.Name = "CustomerLookUp";
            // 
            // Btnclose
            // 
            this.Btnclose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnclose.Location = new System.Drawing.Point(524, 416);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(264, 22);
            this.Btnclose.StyleController = this.TransactionsFlayoutControl1ConvertedLayout;
            this.Btnclose.TabIndex = 19;
            this.Btnclose.Text = "Close";
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btndelete.Location = new System.Drawing.Point(269, 416);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(251, 22);
            this.Btndelete.StyleController = this.TransactionsFlayoutControl1ConvertedLayout;
            this.Btndelete.TabIndex = 18;
            this.Btndelete.Text = "Delete";
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // Btnnew
            // 
            this.Btnnew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnnew.Location = new System.Drawing.Point(12, 416);
            this.Btnnew.Name = "Btnnew";
            this.Btnnew.Size = new System.Drawing.Size(253, 22);
            this.Btnnew.StyleController = this.TransactionsFlayoutControl1ConvertedLayout;
            this.Btnnew.TabIndex = 16;
            this.Btnnew.Text = "New";
            this.Btnnew.Click += new System.EventHandler(this.Btnnew_Click);
            // 
            // TransactionsFlayoutControl1ConvertedLayout
            // 
            this.TransactionsFlayoutControl1ConvertedLayout.Controls.Add(this.GrdTransactions);
            this.TransactionsFlayoutControl1ConvertedLayout.Controls.Add(this.Btnclose);
            this.TransactionsFlayoutControl1ConvertedLayout.Controls.Add(this.Btndelete);
            this.TransactionsFlayoutControl1ConvertedLayout.Controls.Add(this.Btnnew);
            this.TransactionsFlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionsFlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.TransactionsFlayoutControl1ConvertedLayout.Name = "TransactionsFlayoutControl1ConvertedLayout";
            this.TransactionsFlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.TransactionsFlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(800, 450);
            this.TransactionsFlayoutControl1ConvertedLayout.TabIndex = 20;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.GrdTransactionsitem,
            this.Btncloseitem,
            this.Btndeleteitem,
            this.Btnnewitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // GrdTransactionsitem
            // 
            this.GrdTransactionsitem.Control = this.GrdTransactions;
            this.GrdTransactionsitem.Location = new System.Drawing.Point(0, 0);
            this.GrdTransactionsitem.Name = "GrdTransactionsitem";
            this.GrdTransactionsitem.Size = new System.Drawing.Size(780, 404);
            this.GrdTransactionsitem.TextSize = new System.Drawing.Size(0, 0);
            this.GrdTransactionsitem.TextVisible = false;
            // 
            // Btncloseitem
            // 
            this.Btncloseitem.Control = this.Btnclose;
            this.Btncloseitem.Location = new System.Drawing.Point(512, 404);
            this.Btncloseitem.Name = "Btncloseitem";
            this.Btncloseitem.Size = new System.Drawing.Size(268, 26);
            this.Btncloseitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btncloseitem.TextVisible = false;
            // 
            // Btndeleteitem
            // 
            this.Btndeleteitem.Control = this.Btndelete;
            this.Btndeleteitem.Location = new System.Drawing.Point(257, 404);
            this.Btndeleteitem.Name = "Btndeleteitem";
            this.Btndeleteitem.Size = new System.Drawing.Size(255, 26);
            this.Btndeleteitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btndeleteitem.TextVisible = false;
            // 
            // Btnnewitem
            // 
            this.Btnnewitem.Control = this.Btnnew;
            this.Btnnewitem.Location = new System.Drawing.Point(0, 404);
            this.Btnnewitem.Name = "Btnnewitem";
            this.Btnnewitem.Size = new System.Drawing.Size(257, 26);
            this.Btnnewitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnnewitem.TextVisible = false;
            // 
            // TransactionsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TransactionsFlayoutControl1ConvertedLayout);
            this.Name = "TransactionsF";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TransactionsF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCarColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManagerColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsFlayoutControl1ConvertedLayout)).EndInit();
            this.TransactionsFlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransactionsitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncloseitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btndeleteitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnnewitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btnclose;
        private DevExpress.XtraEditors.SimpleButton Btndelete;
        private DevExpress.XtraEditors.SimpleButton Btnnew;
        private System.Windows.Forms.BindingSource bsTransactions;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.BindingSource bsManagerColumns;
        private System.Windows.Forms.BindingSource bsCustomerColumns;
        private System.Windows.Forms.BindingSource bsCarColumns;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit CarLookUp;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ManagerLookUp;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit CustomerLookUp;
        private DevExpress.XtraLayout.LayoutControl TransactionsFlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem GrdTransactionsitem;
        private DevExpress.XtraLayout.LayoutControlItem Btncloseitem;
        private DevExpress.XtraLayout.LayoutControlItem Btndeleteitem;
        private DevExpress.XtraLayout.LayoutControlItem Btnnewitem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}