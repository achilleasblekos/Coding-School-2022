namespace Session_11
{
    partial class TransactionLineF
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
            this.Btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.Btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bsTransactionLine = new System.Windows.Forms.BindingSource(this.components);
            this.CtrlservicetaskID = new DevExpress.XtraEditors.LookUpEdit();
            this.CtrlengineerID = new DevExpress.XtraEditors.LookUpEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.TransactionLineFlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panelControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnexititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnsaveitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlservicetaskID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlengineerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLineFlayoutControl1ConvertedLayout)).BeginInit();
            this.TransactionLineFlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnexititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnsaveitem)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnexit
            // 
            this.Btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnexit.Location = new System.Drawing.Point(296, 327);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(276, 22);
            this.Btnexit.StyleController = this.TransactionLineFlayoutControl1ConvertedLayout;
            this.Btnexit.TabIndex = 29;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnsave.Location = new System.Drawing.Point(12, 327);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(280, 22);
            this.Btnsave.StyleController = this.TransactionLineFlayoutControl1ConvertedLayout;
            this.Btnsave.TabIndex = 28;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Location = new System.Drawing.Point(87, 167);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Engineer";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(87, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "ServiceTask";
            // 
            // CtrlservicetaskID
            // 
            this.CtrlservicetaskID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CtrlservicetaskID.Location = new System.Drawing.Point(212, 117);
            this.CtrlservicetaskID.Name = "CtrlservicetaskID";
            this.CtrlservicetaskID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlservicetaskID.Properties.NullText = "";
            this.CtrlservicetaskID.Size = new System.Drawing.Size(277, 20);
            this.CtrlservicetaskID.TabIndex = 24;
            this.CtrlservicetaskID.EditValueChanged += new System.EventHandler(this.CtrlservicetaskID_EditValueChanged);
            this.CtrlservicetaskID.Validating += new System.ComponentModel.CancelEventHandler(this.CtrlservicetaskID_Validating);
            // 
            // CtrlengineerID
            // 
            this.CtrlengineerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CtrlengineerID.Location = new System.Drawing.Point(212, 162);
            this.CtrlengineerID.Name = "CtrlengineerID";
            this.CtrlengineerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlengineerID.Properties.NullText = "";
            this.CtrlengineerID.Size = new System.Drawing.Size(277, 20);
            this.CtrlengineerID.TabIndex = 25;
            this.CtrlengineerID.Validating += new System.ComponentModel.CancelEventHandler(this.CtrlengineerID_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.CtrlengineerID);
            this.panelControl1.Controls.Add(this.CtrlservicetaskID);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(560, 311);
            this.panelControl1.TabIndex = 30;
            // 
            // TransactionLineFlayoutControl1ConvertedLayout
            // 
            this.TransactionLineFlayoutControl1ConvertedLayout.Controls.Add(this.panelControl1);
            this.TransactionLineFlayoutControl1ConvertedLayout.Controls.Add(this.Btnexit);
            this.TransactionLineFlayoutControl1ConvertedLayout.Controls.Add(this.Btnsave);
            this.TransactionLineFlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionLineFlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.TransactionLineFlayoutControl1ConvertedLayout.Name = "TransactionLineFlayoutControl1ConvertedLayout";
            this.TransactionLineFlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.TransactionLineFlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(584, 361);
            this.TransactionLineFlayoutControl1ConvertedLayout.TabIndex = 31;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.panelControl1item,
            this.Btnexititem,
            this.Btnsaveitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 361);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // panelControl1item
            // 
            this.panelControl1item.Control = this.panelControl1;
            this.panelControl1item.Location = new System.Drawing.Point(0, 0);
            this.panelControl1item.Name = "panelControl1item";
            this.panelControl1item.Size = new System.Drawing.Size(564, 315);
            this.panelControl1item.TextSize = new System.Drawing.Size(0, 0);
            this.panelControl1item.TextVisible = false;
            // 
            // Btnexititem
            // 
            this.Btnexititem.Control = this.Btnexit;
            this.Btnexititem.Location = new System.Drawing.Point(284, 315);
            this.Btnexititem.Name = "Btnexititem";
            this.Btnexititem.Size = new System.Drawing.Size(280, 26);
            this.Btnexititem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnexititem.TextVisible = false;
            // 
            // Btnsaveitem
            // 
            this.Btnsaveitem.Control = this.Btnsave;
            this.Btnsaveitem.Location = new System.Drawing.Point(0, 315);
            this.Btnsaveitem.Name = "Btnsaveitem";
            this.Btnsaveitem.Size = new System.Drawing.Size(284, 26);
            this.Btnsaveitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnsaveitem.TextVisible = false;
            // 
            // TransactionLineF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.TransactionLineFlayoutControl1ConvertedLayout);
            this.Name = "TransactionLineF";
            this.Text = "TransactionLine";
            this.Load += new System.EventHandler(this.TransactionLineF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlservicetaskID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlengineerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLineFlayoutControl1ConvertedLayout)).EndInit();
            this.TransactionLineFlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnexititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnsaveitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource bsTransactionLine;
        private DevExpress.XtraEditors.LookUpEdit CtrlservicetaskID;
        private DevExpress.XtraEditors.LookUpEdit CtrlengineerID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl TransactionLineFlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem panelControl1item;
        private DevExpress.XtraLayout.LayoutControlItem Btnexititem;
        private DevExpress.XtraLayout.LayoutControlItem Btnsaveitem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}