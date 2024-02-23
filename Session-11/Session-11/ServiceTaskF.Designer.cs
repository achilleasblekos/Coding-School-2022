namespace Session_11
{
    partial class ServiceTaskF
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
            this.Ctrlcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bsServiceTask = new System.Windows.Forms.BindingSource(this.components);
            this.Ctrldescription = new DevExpress.XtraEditors.TextEdit();
            this.Ctrlhours = new DevExpress.XtraEditors.SpinEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.ServiceTaskFlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panelControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnexititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnsaveitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlhours.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTaskFlayoutControl1ConvertedLayout)).BeginInit();
            this.ServiceTaskFlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnexititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnsaveitem)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnexit
            // 
            this.Btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnexit.Location = new System.Drawing.Point(306, 327);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(266, 22);
            this.Btnexit.StyleController = this.ServiceTaskFlayoutControl1ConvertedLayout;
            this.Btnexit.TabIndex = 29;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnsave.Location = new System.Drawing.Point(12, 327);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(290, 22);
            this.Btnsave.StyleController = this.ServiceTaskFlayoutControl1ConvertedLayout;
            this.Btnsave.TabIndex = 28;
            this.Btnsave.Text = "Save";
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // Ctrlcode
            // 
            this.Ctrlcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ctrlcode.Location = new System.Drawing.Point(213, 102);
            this.Ctrlcode.Name = "Ctrlcode";
            this.Ctrlcode.Size = new System.Drawing.Size(277, 20);
            this.Ctrlcode.TabIndex = 23;
            this.Ctrlcode.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrlcode_Validating);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Location = new System.Drawing.Point(88, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Hours";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(88, 198);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Description";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(88, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Code";
            // 
            // Ctrldescription
            // 
            this.Ctrldescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ctrldescription.Location = new System.Drawing.Point(213, 193);
            this.Ctrldescription.Name = "Ctrldescription";
            this.Ctrldescription.Size = new System.Drawing.Size(277, 20);
            this.Ctrldescription.TabIndex = 30;
            this.Ctrldescription.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrldescription_Validating);
            // 
            // Ctrlhours
            // 
            this.Ctrlhours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ctrlhours.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Ctrlhours.Location = new System.Drawing.Point(213, 148);
            this.Ctrlhours.Name = "Ctrlhours";
            this.Ctrlhours.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ctrlhours.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.Ctrlhours.Properties.MaxValue = new decimal(new int[] {
            80,
            0,
            0,
            65536});
            this.Ctrlhours.Size = new System.Drawing.Size(277, 20);
            this.Ctrlhours.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.Ctrlhours);
            this.panelControl1.Controls.Add(this.Ctrldescription);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.Ctrlcode);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(560, 311);
            this.panelControl1.TabIndex = 31;
            // 
            // ServiceTaskFlayoutControl1ConvertedLayout
            // 
            this.ServiceTaskFlayoutControl1ConvertedLayout.Controls.Add(this.panelControl1);
            this.ServiceTaskFlayoutControl1ConvertedLayout.Controls.Add(this.Btnexit);
            this.ServiceTaskFlayoutControl1ConvertedLayout.Controls.Add(this.Btnsave);
            this.ServiceTaskFlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceTaskFlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ServiceTaskFlayoutControl1ConvertedLayout.Name = "ServiceTaskFlayoutControl1ConvertedLayout";
            this.ServiceTaskFlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.ServiceTaskFlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(584, 361);
            this.ServiceTaskFlayoutControl1ConvertedLayout.TabIndex = 32;
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
            this.Btnexititem.Location = new System.Drawing.Point(294, 315);
            this.Btnexititem.Name = "Btnexititem";
            this.Btnexititem.Size = new System.Drawing.Size(270, 26);
            this.Btnexititem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnexititem.TextVisible = false;
            // 
            // Btnsaveitem
            // 
            this.Btnsaveitem.Control = this.Btnsave;
            this.Btnsaveitem.Location = new System.Drawing.Point(0, 315);
            this.Btnsaveitem.Name = "Btnsaveitem";
            this.Btnsaveitem.Size = new System.Drawing.Size(294, 26);
            this.Btnsaveitem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnsaveitem.TextVisible = false;
            // 
            // ServiceTaskF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.ServiceTaskFlayoutControl1ConvertedLayout);
            this.Name = "ServiceTaskF";
            this.Text = "Service Task";
            this.Load += new System.EventHandler(this.ServiceTaskF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrldescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctrlhours.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTaskFlayoutControl1ConvertedLayout)).EndInit();
            this.ServiceTaskFlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnexititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnsaveitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.SimpleButton Btnsave;
        private DevExpress.XtraEditors.TextEdit Ctrlcode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsServiceTask;
        private DevExpress.XtraEditors.TextEdit Ctrldescription;
        private DevExpress.XtraEditors.SpinEdit Ctrlhours;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl ServiceTaskFlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem panelControl1item;
        private DevExpress.XtraLayout.LayoutControlItem Btnexititem;
        private DevExpress.XtraLayout.LayoutControlItem Btnsaveitem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}