namespace Session_11
{
    partial class MonthlyLedgersF
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
            this.GrdMonthlyLedgers = new DevExpress.XtraGrid.GridControl();
            this.grvMothlyLedger = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bsMonthlyLedger = new System.Windows.Forms.BindingSource(this.components);
            this.bsLedgers = new System.Windows.Forms.BindingSource(this.components);
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.MonthlyLedgersFlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.GrdMonthlyLedgersitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMonthlyLedgers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMothlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLedgers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyLedgersFlayoutControl1ConvertedLayout)).BeginInit();
            this.MonthlyLedgersFlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMonthlyLedgersitem)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdMonthlyLedgers
            // 
            this.GrdMonthlyLedgers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdMonthlyLedgers.Location = new System.Drawing.Point(12, 12);
            this.GrdMonthlyLedgers.MainView = this.grvMothlyLedger;
            this.GrdMonthlyLedgers.Name = "GrdMonthlyLedgers";
            this.GrdMonthlyLedgers.Size = new System.Drawing.Size(776, 426);
            this.GrdMonthlyLedgers.TabIndex = 15;
            this.GrdMonthlyLedgers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMothlyLedger});
            // 
            // grvMothlyLedger
            // 
            this.grvMothlyLedger.GridControl = this.GrdMonthlyLedgers;
            this.grvMothlyLedger.Name = "grvMothlyLedger";
            this.grvMothlyLedger.OptionsBehavior.ReadOnly = true;
            // 
            // MonthlyLedgersFlayoutControl1ConvertedLayout
            // 
            this.MonthlyLedgersFlayoutControl1ConvertedLayout.Controls.Add(this.GrdMonthlyLedgers);
            this.MonthlyLedgersFlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthlyLedgersFlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.MonthlyLedgersFlayoutControl1ConvertedLayout.Name = "MonthlyLedgersFlayoutControl1ConvertedLayout";
            this.MonthlyLedgersFlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.MonthlyLedgersFlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(800, 450);
            this.MonthlyLedgersFlayoutControl1ConvertedLayout.TabIndex = 16;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.GrdMonthlyLedgersitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // GrdMonthlyLedgersitem
            // 
            this.GrdMonthlyLedgersitem.Control = this.GrdMonthlyLedgers;
            this.GrdMonthlyLedgersitem.Location = new System.Drawing.Point(0, 0);
            this.GrdMonthlyLedgersitem.Name = "GrdMonthlyLedgersitem";
            this.GrdMonthlyLedgersitem.Size = new System.Drawing.Size(780, 430);
            this.GrdMonthlyLedgersitem.TextSize = new System.Drawing.Size(0, 0);
            this.GrdMonthlyLedgersitem.TextVisible = false;
            // 
            // MonthlyLedgersF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MonthlyLedgersFlayoutControl1ConvertedLayout);
            this.Name = "MonthlyLedgersF";
            this.Text = "MonthlyLedgers";
            this.Load += new System.EventHandler(this.MonthlyLedgersF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMonthlyLedgers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMothlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLedgers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyLedgersFlayoutControl1ConvertedLayout)).EndInit();
            this.MonthlyLedgersFlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMonthlyLedgersitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdMonthlyLedgers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMothlyLedger;
        private System.Windows.Forms.BindingSource bsMonthlyLedger;
        private System.Windows.Forms.BindingSource bsLedgers;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.LayoutControl MonthlyLedgersFlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem GrdMonthlyLedgersitem;
    }
}