namespace Session_11
{
    partial class LoginF
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
            this.ctrlPassword = new DevExpress.XtraEditors.TextEdit();
            this.Btnenter = new DevExpress.XtraEditors.SimpleButton();
            this.Btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlUsername = new DevExpress.XtraEditors.LookUpEdit();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.LoginFlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panelControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnexititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btnenteritem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFlayoutControl1ConvertedLayout)).BeginInit();
            this.LoginFlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnexititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnenteritem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(122, 128);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(122, 176);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlPassword.Location = new System.Drawing.Point(197, 173);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ctrlPassword.Properties.UseSystemPasswordChar = true;
            this.ctrlPassword.Size = new System.Drawing.Size(239, 20);
            this.ctrlPassword.TabIndex = 3;
            // 
            // Btnenter
            // 
            this.Btnenter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnenter.Location = new System.Drawing.Point(12, 327);
            this.Btnenter.Name = "Btnenter";
            this.Btnenter.Size = new System.Drawing.Size(278, 22);
            this.Btnenter.StyleController = this.LoginFlayoutControl1ConvertedLayout;
            this.Btnenter.TabIndex = 4;
            this.Btnenter.Text = "Enter";
            this.Btnenter.Click += new System.EventHandler(this.Btnenter_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnexit.Location = new System.Drawing.Point(294, 327);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(278, 22);
            this.Btnexit.StyleController = this.LoginFlayoutControl1ConvertedLayout;
            this.Btnexit.TabIndex = 5;
            this.Btnexit.Text = "Exit";
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // ctrlUsername
            // 
            this.ctrlUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlUsername.Location = new System.Drawing.Point(197, 125);
            this.ctrlUsername.Name = "ctrlUsername";
            this.ctrlUsername.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlUsername.Properties.NullText = "";
            this.ctrlUsername.Properties.ShowHeader = false;
            this.ctrlUsername.Size = new System.Drawing.Size(239, 20);
            this.ctrlUsername.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.ctrlPassword);
            this.panelControl1.Controls.Add(this.ctrlUsername);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(560, 311);
            this.panelControl1.TabIndex = 6;
            // 
            // LoginFlayoutControl1ConvertedLayout
            // 
            this.LoginFlayoutControl1ConvertedLayout.Controls.Add(this.panelControl1);
            this.LoginFlayoutControl1ConvertedLayout.Controls.Add(this.Btnexit);
            this.LoginFlayoutControl1ConvertedLayout.Controls.Add(this.Btnenter);
            this.LoginFlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginFlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.LoginFlayoutControl1ConvertedLayout.Name = "LoginFlayoutControl1ConvertedLayout";
            this.LoginFlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.LoginFlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(584, 361);
            this.LoginFlayoutControl1ConvertedLayout.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.panelControl1item,
            this.Btnexititem,
            this.Btnenteritem});
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
            this.Btnexititem.Location = new System.Drawing.Point(282, 315);
            this.Btnexititem.Name = "Btnexititem";
            this.Btnexititem.Size = new System.Drawing.Size(282, 26);
            this.Btnexititem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnexititem.TextVisible = false;
            // 
            // Btnenteritem
            // 
            this.Btnenteritem.Control = this.Btnenter;
            this.Btnenteritem.Location = new System.Drawing.Point(0, 315);
            this.Btnenteritem.Name = "Btnenteritem";
            this.Btnenteritem.Size = new System.Drawing.Size(282, 26);
            this.Btnenteritem.TextSize = new System.Drawing.Size(0, 0);
            this.Btnenteritem.TextVisible = false;
            // 
            // LoginF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.LoginFlayoutControl1ConvertedLayout);
            this.Name = "LoginF";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFlayoutControl1ConvertedLayout)).EndInit();
            this.LoginFlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnexititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnenteritem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit ctrlPassword;
        private DevExpress.XtraEditors.SimpleButton Btnenter;
        private DevExpress.XtraEditors.SimpleButton Btnexit;
        private DevExpress.XtraEditors.LookUpEdit ctrlUsername;
        private System.Windows.Forms.BindingSource bsUsers;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl LoginFlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem panelControl1item;
        private DevExpress.XtraLayout.LayoutControlItem Btnexititem;
        private DevExpress.XtraLayout.LayoutControlItem Btnenteritem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}