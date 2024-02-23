namespace Session_11
{
    partial class CustomerF
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Ctrlname = new DevExpress.XtraEditors.TextEdit();
            this.Ctrlsurname = new DevExpress.XtraEditors.TextEdit();
            this.Ctrlphone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CtrlTIN = new DevExpress.XtraEditors.TextEdit();
            this.Btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.Btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.CustomerFlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panelControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnexititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnsaveitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlsurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlphone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlTIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerFlayoutControl1ConvertedLayout)).BeginInit();
            this.CustomerFlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnexititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnsaveitem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(88, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(88, 126);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Surname";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Location = new System.Drawing.Point(88, 175);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Phone";
            // 
            // Ctrlname
            // 
            this.Ctrlname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ctrlname.Location = new System.Drawing.Point(213, 77);
            this.Ctrlname.Name = "Ctrlname";
            this.Ctrlname.Size = new System.Drawing.Size(277, 20);
            this.Ctrlname.TabIndex = 3;
            this.Ctrlname.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlname_Validating);
            // 
            // Ctrlsurname
            // 
            this.Ctrlsurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ctrlsurname.Location = new System.Drawing.Point(213, 125);
            this.Ctrlsurname.Name = "Ctrlsurname";
            this.Ctrlsurname.Size = new System.Drawing.Size(277, 20);
            this.Ctrlsurname.TabIndex = 4;
            this.Ctrlsurname.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlsurname_Validating);
            // 
            // Ctrlphone
            // 
            this.Ctrlphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ctrlphone.Location = new System.Drawing.Point(213, 170);
            this.Ctrlphone.Name = "Ctrlphone";
            this.Ctrlphone.Size = new System.Drawing.Size(277, 20);
            this.Ctrlphone.TabIndex = 5;
            this.Ctrlphone.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlphone_Validating);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Location = new System.Drawing.Point(88, 217);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(17, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "TIN";
            // 
            // CtrlTIN
            // 
            this.CtrlTIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CtrlTIN.Location = new System.Drawing.Point(213, 216);
            this.CtrlTIN.Name = "CtrlTIN";
            this.CtrlTIN.Size = new System.Drawing.Size(277, 20);
            this.CtrlTIN.TabIndex = 7;
            this.CtrlTIN.Validating += new System.ComponentModel.CancelEventHandler(this.CtrlTIN_Validating);
            // 
            // Btnsave
            // 
            this.Btnsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnsave.Location = new System.Drawing.Point(12, 327);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(274, 22);
            this.Btnsave.StyleController = this.CustomerFlayoutControl1ConvertedLayout;
            this.Btnsave.TabIndex = 8;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnexit.Location = new System.Drawing.Point(290, 327);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(282, 22);
            this.Btnexit.StyleController = this.CustomerFlayoutControl1ConvertedLayout;
            this.Btnexit.TabIndex = 9;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.CtrlTIN);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.Ctrlname);
            this.panelControl1.Controls.Add(this.Ctrlphone);
            this.panelControl1.Controls.Add(this.Ctrlsurname);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(560, 311);
            this.panelControl1.TabIndex = 10;
            // 
            // CustomerFlayoutControl1ConvertedLayout
            // 
            this.CustomerFlayoutControl1ConvertedLayout.Controls.Add(this.panelControl1);
            this.CustomerFlayoutControl1ConvertedLayout.Controls.Add(this.Btnexit);
            this.CustomerFlayoutControl1ConvertedLayout.Controls.Add(this.Btnsave);
            this.CustomerFlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerFlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.CustomerFlayoutControl1ConvertedLayout.Name = "CustomerFlayoutControl1ConvertedLayout";
            this.CustomerFlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.CustomerFlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(584, 361);
            this.CustomerFlayoutControl1ConvertedLayout.TabIndex = 11;
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
            this.Btnexititem.Location = new System.Drawing.Point(278, 315);
            this.Btnexititem.Name = "Btnexititem";
            this.Btnexititem.Size = new System.Drawing.Size(286, 26);
            this.Btnexititem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnexititem.TextVisible = false;
            // 
            // Btnsaveitem
            // 
            this.Btnsaveitem.Control = this.Btnsave;
            this.Btnsaveitem.Location = new System.Drawing.Point(0, 315);
            this.Btnsaveitem.Name = "Btnsaveitem";
            this.Btnsaveitem.Size = new System.Drawing.Size(278, 26);
            this.Btnsaveitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnsaveitem.TextVisible = false;
            // 
            // CustomerF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.CustomerFlayoutControl1ConvertedLayout);
            this.Name = "CustomerF";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlsurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlphone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlTIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerFlayoutControl1ConvertedLayout)).EndInit();
            this.CustomerFlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnexititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnsaveitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Ctrlname;
        private DevExpress.XtraEditors.TextEdit Ctrlsurname;
        private DevExpress.XtraEditors.TextEdit Ctrlphone;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit CtrlTIN;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl CustomerFlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem panelControl1item;
        private DevExpress.XtraLayout.LayoutControlItem Btnexititem;
        private DevExpress.XtraLayout.LayoutControlItem Btnsaveitem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}