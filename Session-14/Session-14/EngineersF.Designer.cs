namespace Session_11
{
    partial class EngineersF
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
            this.GrdEngineers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ManagerIDlookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.Btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.Btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.Btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.bsEngineers = new System.Windows.Forms.BindingSource(this.components);
            this.bsManagerID = new System.Windows.Forms.BindingSource(this.components);
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.EngineersFlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.GrdEngineersitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btncloseitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btndeleteitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnedititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnnewitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerIDlookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManagerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EngineersFlayoutControl1ConvertedLayout)).BeginInit();
            this.EngineersFlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEngineersitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncloseitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btndeleteitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnedititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnnewitem)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdEngineers
            // 
            this.GrdEngineers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdEngineers.Location = new System.Drawing.Point(12, 12);
            this.GrdEngineers.MainView = this.gridView1;
            this.GrdEngineers.Name = "GrdEngineers";
            this.GrdEngineers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ManagerIDlookup});
            this.GrdEngineers.Size = new System.Drawing.Size(776, 400);
            this.GrdEngineers.TabIndex = 10;
            this.GrdEngineers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdEngineers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // ManagerIDlookup
            // 
            this.ManagerIDlookup.AutoHeight = false;
            this.ManagerIDlookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ManagerIDlookup.Name = "ManagerIDlookup";
            // 
            // Btnclose
            // 
            this.Btnclose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnclose.Location = new System.Drawing.Point(595, 416);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(193, 22);
            this.Btnclose.StyleController = this.EngineersFlayoutControl1ConvertedLayout;
            this.Btnclose.TabIndex = 14;
            this.Btnclose.Text = "Close";
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btndelete.Location = new System.Drawing.Point(401, 416);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(190, 22);
            this.Btndelete.StyleController = this.EngineersFlayoutControl1ConvertedLayout;
            this.Btndelete.TabIndex = 13;
            this.Btndelete.Text = "Delete";
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // Btnedit
            // 
            this.Btnedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnedit.Location = new System.Drawing.Point(213, 416);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(184, 22);
            this.Btnedit.StyleController = this.EngineersFlayoutControl1ConvertedLayout;
            this.Btnedit.TabIndex = 12;
            this.Btnedit.Text = "Edit";
            this.Btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // Btnnew
            // 
            this.Btnnew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnnew.Location = new System.Drawing.Point(12, 416);
            this.Btnnew.Name = "Btnnew";
            this.Btnnew.Size = new System.Drawing.Size(197, 22);
            this.Btnnew.StyleController = this.EngineersFlayoutControl1ConvertedLayout;
            this.Btnnew.TabIndex = 11;
            this.Btnnew.Text = "New";
            this.Btnnew.Click += new System.EventHandler(this.Btnnew_Click);
            // 
            // EngineersFlayoutControl1ConvertedLayout
            // 
            this.EngineersFlayoutControl1ConvertedLayout.Controls.Add(this.GrdEngineers);
            this.EngineersFlayoutControl1ConvertedLayout.Controls.Add(this.Btnclose);
            this.EngineersFlayoutControl1ConvertedLayout.Controls.Add(this.Btndelete);
            this.EngineersFlayoutControl1ConvertedLayout.Controls.Add(this.Btnedit);
            this.EngineersFlayoutControl1ConvertedLayout.Controls.Add(this.Btnnew);
            this.EngineersFlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EngineersFlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.EngineersFlayoutControl1ConvertedLayout.Name = "EngineersFlayoutControl1ConvertedLayout";
            this.EngineersFlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.EngineersFlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(800, 450);
            this.EngineersFlayoutControl1ConvertedLayout.TabIndex = 15;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.GrdEngineersitem,
            this.Btncloseitem,
            this.Btndeleteitem,
            this.Btnedititem,
            this.Btnnewitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // GrdEngineersitem
            // 
            this.GrdEngineersitem.Control = this.GrdEngineers;
            this.GrdEngineersitem.Location = new System.Drawing.Point(0, 0);
            this.GrdEngineersitem.Name = "GrdEngineersitem";
            this.GrdEngineersitem.Size = new System.Drawing.Size(780, 404);
            this.GrdEngineersitem.TextSize = new System.Drawing.Size(0, 0);
            this.GrdEngineersitem.TextVisible = false;
            // 
            // Btncloseitem
            // 
            this.Btncloseitem.Control = this.Btnclose;
            this.Btncloseitem.Location = new System.Drawing.Point(583, 404);
            this.Btncloseitem.Name = "Btncloseitem";
            this.Btncloseitem.Size = new System.Drawing.Size(197, 26);
            this.Btncloseitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btncloseitem.TextVisible = false;
            // 
            // Btndeleteitem
            // 
            this.Btndeleteitem.Control = this.Btndelete;
            this.Btndeleteitem.Location = new System.Drawing.Point(389, 404);
            this.Btndeleteitem.Name = "Btndeleteitem";
            this.Btndeleteitem.Size = new System.Drawing.Size(194, 26);
            this.Btndeleteitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btndeleteitem.TextVisible = false;
            // 
            // Btnedititem
            // 
            this.Btnedititem.Control = this.Btnedit;
            this.Btnedititem.Location = new System.Drawing.Point(201, 404);
            this.Btnedititem.Name = "Btnedititem";
            this.Btnedititem.Size = new System.Drawing.Size(188, 26);
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
            // EngineersF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EngineersFlayoutControl1ConvertedLayout);
            this.Name = "EngineersF";
            this.Text = "Engineers";
            this.Load += new System.EventHandler(this.EngineersF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerIDlookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManagerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EngineersFlayoutControl1ConvertedLayout)).EndInit();
            this.EngineersFlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEngineersitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncloseitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btndeleteitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnedititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnnewitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdEngineers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btnclose;
        private DevExpress.XtraEditors.SimpleButton Btndelete;
        private DevExpress.XtraEditors.SimpleButton Btnedit;
        private DevExpress.XtraEditors.SimpleButton Btnnew;
        private System.Windows.Forms.BindingSource bsEngineers;
        private System.Windows.Forms.BindingSource bsManagerID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ManagerIDlookup;
        private DevExpress.XtraLayout.LayoutControl EngineersFlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem GrdEngineersitem;
        private DevExpress.XtraLayout.LayoutControlItem Btncloseitem;
        private DevExpress.XtraLayout.LayoutControlItem Btndeleteitem;
        private DevExpress.XtraLayout.LayoutControlItem Btnedititem;
        private DevExpress.XtraLayout.LayoutControlItem Btnnewitem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}