namespace Session_11
{
    partial class CarsF
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
            this.grdCars = new DevExpress.XtraGrid.GridControl();
            this.grvCars = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.Btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.Btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.Btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.bsCars = new System.Windows.Forms.BindingSource(this.components);
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.CarsFlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Btncloseitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btndeleteitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnedititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnnewitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.GrdCarsitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsFlayoutControl1ConvertedLayout)).BeginInit();
            this.CarsFlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncloseitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btndeleteitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnedititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnnewitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCarsitem)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCars
            // 
            this.grdCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCars.Location = new System.Drawing.Point(12, 12);
            this.grdCars.MainView = this.grvCars;
            this.grdCars.Name = "grdCars";
            this.grdCars.Size = new System.Drawing.Size(776, 400);
            this.grdCars.TabIndex = 0;
            this.grdCars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCars});
            // 
            // grvCars
            // 
            this.grvCars.GridControl = this.grdCars;
            this.grvCars.Name = "grvCars";
            this.grvCars.OptionsBehavior.ReadOnly = true;
            // 
            // Btnnew
            // 
            this.Btnnew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnnew.Location = new System.Drawing.Point(12, 416);
            this.Btnnew.Name = "Btnnew";
            this.Btnnew.Size = new System.Drawing.Size(197, 22);
            this.Btnnew.StyleController = this.CarsFlayoutControl1ConvertedLayout;
            this.Btnnew.TabIndex = 1;
            this.Btnnew.Text = "New";
            this.Btnnew.Click += new System.EventHandler(this.Btnnew_Click);
            // 
            // Btnedit
            // 
            this.Btnedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnedit.Location = new System.Drawing.Point(213, 416);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(177, 22);
            this.Btnedit.StyleController = this.CarsFlayoutControl1ConvertedLayout;
            this.Btnedit.TabIndex = 2;
            this.Btnedit.Text = "Edit";
            this.Btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btndelete.Location = new System.Drawing.Point(394, 416);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(171, 22);
            this.Btndelete.StyleController = this.CarsFlayoutControl1ConvertedLayout;
            this.Btndelete.TabIndex = 3;
            this.Btndelete.Text = "Delete";
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // Btnclose
            // 
            this.Btnclose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnclose.Location = new System.Drawing.Point(569, 416);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(219, 22);
            this.Btnclose.StyleController = this.CarsFlayoutControl1ConvertedLayout;
            this.Btnclose.TabIndex = 4;
            this.Btnclose.Text = "Close";
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // CarsFlayoutControl1ConvertedLayout
            // 
            this.CarsFlayoutControl1ConvertedLayout.Controls.Add(this.Btnclose);
            this.CarsFlayoutControl1ConvertedLayout.Controls.Add(this.Btndelete);
            this.CarsFlayoutControl1ConvertedLayout.Controls.Add(this.Btnedit);
            this.CarsFlayoutControl1ConvertedLayout.Controls.Add(this.Btnnew);
            this.CarsFlayoutControl1ConvertedLayout.Controls.Add(this.grdCars);
            this.CarsFlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarsFlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.CarsFlayoutControl1ConvertedLayout.Name = "CarsFlayoutControl1ConvertedLayout";
            this.CarsFlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.CarsFlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(800, 450);
            this.CarsFlayoutControl1ConvertedLayout.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Btncloseitem,
            this.Btndeleteitem,
            this.Btnedititem,
            this.Btnnewitem,
            this.GrdCarsitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // Btncloseitem
            // 
            this.Btncloseitem.Control = this.Btnclose;
            this.Btncloseitem.Location = new System.Drawing.Point(557, 404);
            this.Btncloseitem.Name = "Btncloseitem";
            this.Btncloseitem.Size = new System.Drawing.Size(223, 26);
            this.Btncloseitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btncloseitem.TextVisible = false;
            // 
            // Btndeleteitem
            // 
            this.Btndeleteitem.Control = this.Btndelete;
            this.Btndeleteitem.Location = new System.Drawing.Point(382, 404);
            this.Btndeleteitem.Name = "Btndeleteitem";
            this.Btndeleteitem.Size = new System.Drawing.Size(175, 26);
            this.Btndeleteitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btndeleteitem.TextVisible = false;
            // 
            // Btnedititem
            // 
            this.Btnedititem.Control = this.Btnedit;
            this.Btnedititem.Location = new System.Drawing.Point(201, 404);
            this.Btnedititem.Name = "Btnedititem";
            this.Btnedititem.Size = new System.Drawing.Size(181, 26);
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
            // GrdCarsitem
            // 
            this.GrdCarsitem.Control = this.grdCars;
            this.GrdCarsitem.Location = new System.Drawing.Point(0, 0);
            this.GrdCarsitem.Name = "GrdCarsitem";
            this.GrdCarsitem.Size = new System.Drawing.Size(780, 404);
            this.GrdCarsitem.TextSize = new System.Drawing.Size(0, 0);
            this.GrdCarsitem.TextVisible = false;
            // 
            // CarsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarsFlayoutControl1ConvertedLayout);
            this.Name = "CarsF";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.CarsF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsFlayoutControl1ConvertedLayout)).EndInit();
            this.CarsFlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncloseitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btndeleteitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnedititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnnewitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCarsitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCars;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCars;
        private DevExpress.XtraEditors.SimpleButton Btnnew;
        private DevExpress.XtraEditors.SimpleButton Btnedit;
        private DevExpress.XtraEditors.SimpleButton Btndelete;
        private DevExpress.XtraEditors.SimpleButton Btnclose;
        private System.Windows.Forms.BindingSource bsCars;
        private DevExpress.XtraLayout.LayoutControl CarsFlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem Btncloseitem;
        private DevExpress.XtraLayout.LayoutControlItem Btndeleteitem;
        private DevExpress.XtraLayout.LayoutControlItem Btnedititem;
        private DevExpress.XtraLayout.LayoutControlItem Btnnewitem;
        private DevExpress.XtraLayout.LayoutControlItem GrdCarsitem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}