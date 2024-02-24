namespace Session_07
{
    partial class UniversityF
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barMain = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonStudentsEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonProfessorsEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonCoursesEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonScheduledEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonSaveProgram = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLoadProgram = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 25);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(591, 397);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(591, 397);
            this.Root.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMain});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.barEditItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barStaticItem4,
            this.barButtonItem1,
            this.barButtonStudentsEdit,
            this.barButtonProfessorsEdit,
            this.barButtonCoursesEdit,
            this.barButtonScheduledEdit,
            this.barSubItem5,
            this.barButtonSaveProgram,
            this.barButtonLoadProgram});
            this.barManager1.MainMenu = this.barMain;
            this.barManager1.MaxItemId = 17;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // barMain
            // 
            this.barMain.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barMain.BarAppearance.Normal.Options.UseFont = true;
            this.barMain.BarName = "Main menu";
            this.barMain.DockCol = 0;
            this.barMain.DockRow = 0;
            this.barMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3)});
            this.barMain.OptionsBar.MultiLine = true;
            this.barMain.OptionsBar.UseWholeRow = true;
            this.barMain.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Students";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonStudentsEdit)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonStudentsEdit
            // 
            this.barButtonStudentsEdit.Caption = "Edit";
            this.barButtonStudentsEdit.Id = 10;
            this.barButtonStudentsEdit.Name = "barButtonStudentsEdit";
            this.barButtonStudentsEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonStudentsEdit_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Professors";
            this.barSubItem2.Id = 1;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonProfessorsEdit)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonProfessorsEdit
            // 
            this.barButtonProfessorsEdit.Caption = "Edit";
            this.barButtonProfessorsEdit.Id = 11;
            this.barButtonProfessorsEdit.Name = "barButtonProfessorsEdit";
            this.barButtonProfessorsEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonProfessorsEdit_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Courses";
            this.barSubItem3.Id = 2;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonCoursesEdit)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barButtonCoursesEdit
            // 
            this.barButtonCoursesEdit.Caption = "Edit";
            this.barButtonCoursesEdit.Id = 12;
            this.barButtonCoursesEdit.Name = "barButtonCoursesEdit";
            this.barButtonCoursesEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCoursesEdit_ItemClick);
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Scheduled Courses";
            this.barSubItem4.Id = 3;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonScheduledEdit)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonScheduledEdit
            // 
            this.barButtonScheduledEdit.Caption = "Edit";
            this.barButtonScheduledEdit.Id = 13;
            this.barButtonScheduledEdit.Name = "barButtonScheduledEdit";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(591, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 422);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(591, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 397);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(591, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 397);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Edit . . .";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 4;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Edit . . .";
            this.barStaticItem2.Id = 6;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Edit . . .";
            this.barStaticItem3.Id = 7;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Edit . . .";
            this.barStaticItem4.Id = 8;
            this.barStaticItem4.Name = "barStaticItem4";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Edit";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "System";
            this.barSubItem5.Id = 14;
            this.barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonSaveProgram),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonLoadProgram)});
            this.barSubItem5.Name = "barSubItem5";
            // 
            // barButtonSaveProgram
            // 
            this.barButtonSaveProgram.Caption = "Save";
            this.barButtonSaveProgram.Id = 15;
            this.barButtonSaveProgram.Name = "barButtonSaveProgram";
            this.barButtonSaveProgram.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSaveProgram_ItemClick);
            // 
            // barButtonLoadProgram
            // 
            this.barButtonLoadProgram.Caption = "Load";
            this.barButtonLoadProgram.Id = 16;
            this.barButtonLoadProgram.Name = "barButtonLoadProgram";
            this.barButtonLoadProgram.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLoadProgram_ItemClick);
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 422);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "UniversityForm";
            this.Text = "University";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UniversityForm_FormClosing);
            this.Load += new System.EventHandler(this.UniversityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barMain;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonStudentsEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonProfessorsEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonCoursesEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonScheduledEdit;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonSaveProgram;
        private DevExpress.XtraBars.BarButtonItem barButtonLoadProgram;
    }
}

