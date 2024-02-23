namespace Session_11
{
    partial class EngineerF
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Ctrlsurname = new DevExpress.XtraEditors.TextEdit();
            this.Ctrlname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bsEngineer = new System.Windows.Forms.BindingSource(this.components);
            this.CtrlmanagerID = new DevExpress.XtraEditors.LookUpEdit();
            this.Ctrlsallarypermonth = new DevExpress.XtraEditors.SpinEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.EngineerFlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panelControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnexititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnsaveitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlsurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEngineer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlmanagerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlsallarypermonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EngineerFlayoutControl1ConvertedLayout)).BeginInit();
            this.EngineerFlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnexititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnsaveitem)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnexit
            // 
            this.Btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnexit.Location = new System.Drawing.Point(292, 327);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(280, 22);
            this.Btnexit.StyleController = this.EngineerFlayoutControl1ConvertedLayout;
            this.Btnexit.TabIndex = 19;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnsave.Location = new System.Drawing.Point(12, 327);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(276, 22);
            this.Btnsave.StyleController = this.EngineerFlayoutControl1ConvertedLayout;
            this.Btnsave.TabIndex = 18;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Location = new System.Drawing.Point(83, 207);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "SallaryPerMonth";
            // 
            // Ctrlsurname
            // 
            this.Ctrlsurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ctrlsurname.Location = new System.Drawing.Point(208, 115);
            this.Ctrlsurname.Name = "Ctrlsurname";
            this.Ctrlsurname.Size = new System.Drawing.Size(277, 20);
            this.Ctrlsurname.TabIndex = 14;
            this.Ctrlsurname.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlsurname_Validating);
            // 
            // Ctrlname
            // 
            this.Ctrlname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ctrlname.Location = new System.Drawing.Point(208, 69);
            this.Ctrlname.Name = "Ctrlname";
            this.Ctrlname.Size = new System.Drawing.Size(277, 20);
            this.Ctrlname.TabIndex = 13;
            this.Ctrlname.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlname_Validating);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Location = new System.Drawing.Point(83, 165);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Manager";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(83, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Surname";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(83, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Name";
            // 
            // CtrlmanagerID
            // 
            this.CtrlmanagerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CtrlmanagerID.Location = new System.Drawing.Point(208, 160);
            this.CtrlmanagerID.Name = "CtrlmanagerID";
            this.CtrlmanagerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlmanagerID.Properties.NullText = "";
            this.CtrlmanagerID.Size = new System.Drawing.Size(277, 20);
            this.CtrlmanagerID.TabIndex = 15;
            this.CtrlmanagerID.Validating += new System.ComponentModel.CancelEventHandler(this.CtrlmanagerID_Validating);
            // 
            // Ctrlsallarypermonth
            // 
            this.Ctrlsallarypermonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ctrlsallarypermonth.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Ctrlsallarypermonth.Location = new System.Drawing.Point(208, 206);
            this.Ctrlsallarypermonth.Name = "Ctrlsallarypermonth";
            this.Ctrlsallarypermonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ctrlsallarypermonth.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.Ctrlsallarypermonth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.Ctrlsallarypermonth.Size = new System.Drawing.Size(277, 20);
            this.Ctrlsallarypermonth.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.Ctrlsallarypermonth);
            this.panelControl1.Controls.Add(this.CtrlmanagerID);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.Ctrlsurname);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.Ctrlname);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(560, 311);
            this.panelControl1.TabIndex = 20;
            // 
            // EngineerFlayoutControl1ConvertedLayout
            // 
            this.EngineerFlayoutControl1ConvertedLayout.Controls.Add(this.panelControl1);
            this.EngineerFlayoutControl1ConvertedLayout.Controls.Add(this.Btnexit);
            this.EngineerFlayoutControl1ConvertedLayout.Controls.Add(this.Btnsave);
            this.EngineerFlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EngineerFlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.EngineerFlayoutControl1ConvertedLayout.Name = "EngineerFlayoutControl1ConvertedLayout";
            this.EngineerFlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.EngineerFlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(584, 361);
            this.EngineerFlayoutControl1ConvertedLayout.TabIndex = 21;
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
            this.Btnexititem.Location = new System.Drawing.Point(280, 315);
            this.Btnexititem.Name = "Btnexititem";
            this.Btnexititem.Size = new System.Drawing.Size(284, 26);
            this.Btnexititem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnexititem.TextVisible = false;
            // 
            // Btnsaveitem
            // 
            this.Btnsaveitem.Control = this.Btnsave;
            this.Btnsaveitem.Location = new System.Drawing.Point(0, 315);
            this.Btnsaveitem.Name = "Btnsaveitem";
            this.Btnsaveitem.Size = new System.Drawing.Size(280, 26);
            this.Btnsaveitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnsaveitem.TextVisible = false;
            // 
            // EngineerF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.EngineerFlayoutControl1ConvertedLayout);
            this.Name = "EngineerF";
            this.Text = "Engineer";
            this.Load += new System.EventHandler(this.CarF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlsurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEngineer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlmanagerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlsallarypermonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EngineerFlayoutControl1ConvertedLayout)).EndInit();
            this.EngineerFlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnexititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnsaveitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Ctrlsurname;
        private DevExpress.XtraEditors.TextEdit Ctrlname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsEngineer;
        private DevExpress.XtraEditors.LookUpEdit CtrlmanagerID;
        private DevExpress.XtraEditors.SpinEdit Ctrlsallarypermonth;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl EngineerFlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem panelControl1item;
        private DevExpress.XtraLayout.LayoutControlItem Btnexititem;
        private DevExpress.XtraLayout.LayoutControlItem Btnsaveitem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}