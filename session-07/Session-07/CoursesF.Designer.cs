namespace Session_07
{
    partial class CoursesF
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.listBoxCourses = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditCode = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditSubject = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlSubject = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.buttonDeleteCourse = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonSaveForm = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonAddCourse = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonCancelForm = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.buttonCancelForm);
            this.layoutControl1.Controls.Add(this.buttonAddCourse);
            this.layoutControl1.Controls.Add(this.buttonSaveForm);
            this.layoutControl1.Controls.Add(this.buttonDeleteCourse);
            this.layoutControl1.Controls.Add(this.textEditSubject);
            this.layoutControl1.Controls.Add(this.textEditCode);
            this.layoutControl1.Controls.Add(this.listBoxCourses);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(620, 443);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlCode,
            this.layoutControlSubject,
            this.emptySpaceItem1,
            this.simpleSeparator1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(620, 443);
            this.Root.TextVisible = false;
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.Location = new System.Drawing.Point(12, 12);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(201, 419);
            this.listBoxCourses.StyleController = this.layoutControl1;
            this.listBoxCourses.TabIndex = 4;
            this.listBoxCourses.SelectedIndexChanged += new System.EventHandler(this.listBoxCourses_SelectedIndexChanged);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.listBoxCourses;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(205, 423);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // textEditCode
            // 
            this.textEditCode.Location = new System.Drawing.Point(302, 12);
            this.textEditCode.Name = "textEditCode";
            this.textEditCode.Size = new System.Drawing.Size(306, 20);
            this.textEditCode.StyleController = this.layoutControl1;
            this.textEditCode.TabIndex = 5;
            // 
            // layoutControlCode
            // 
            this.layoutControlCode.Control = this.textEditCode;
            this.layoutControlCode.Location = new System.Drawing.Point(205, 0);
            this.layoutControlCode.Name = "layoutControlCode";
            this.layoutControlCode.Size = new System.Drawing.Size(395, 24);
            this.layoutControlCode.Text = "Course\'s Code";
            this.layoutControlCode.TextSize = new System.Drawing.Size(73, 13);
            // 
            // textEditSubject
            // 
            this.textEditSubject.Location = new System.Drawing.Point(302, 36);
            this.textEditSubject.Name = "textEditSubject";
            this.textEditSubject.Size = new System.Drawing.Size(306, 20);
            this.textEditSubject.StyleController = this.layoutControl1;
            this.textEditSubject.TabIndex = 6;
            // 
            // layoutControlSubject
            // 
            this.layoutControlSubject.Control = this.textEditSubject;
            this.layoutControlSubject.Location = new System.Drawing.Point(205, 24);
            this.layoutControlSubject.Name = "layoutControlSubject";
            this.layoutControlSubject.Size = new System.Drawing.Size(395, 24);
            this.layoutControlSubject.Text = "Course Subject";
            this.layoutControlSubject.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(205, 49);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(395, 348);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(205, 48);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(395, 1);
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.Location = new System.Drawing.Point(315, 409);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(95, 22);
            this.buttonDeleteCourse.StyleController = this.layoutControl1;
            this.buttonDeleteCourse.TabIndex = 7;
            this.buttonDeleteCourse.Text = "Delete Course";
            this.buttonDeleteCourse.Click += new System.EventHandler(this.buttonDeleteCourse_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.buttonDeleteCourse;
            this.layoutControlItem2.Location = new System.Drawing.Point(303, 397);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(99, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // buttonSaveForm
            // 
            this.buttonSaveForm.Location = new System.Drawing.Point(414, 409);
            this.buttonSaveForm.Name = "buttonSaveForm";
            this.buttonSaveForm.Size = new System.Drawing.Size(95, 22);
            this.buttonSaveForm.StyleController = this.layoutControl1;
            this.buttonSaveForm.TabIndex = 8;
            this.buttonSaveForm.Text = "Save";
            this.buttonSaveForm.Click += new System.EventHandler(this.buttonSaveForm_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.buttonSaveForm;
            this.layoutControlItem3.Location = new System.Drawing.Point(402, 397);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(99, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(217, 409);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(94, 22);
            this.buttonAddCourse.StyleController = this.layoutControl1;
            this.buttonAddCourse.TabIndex = 9;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.buttonAddCourse;
            this.layoutControlItem4.Location = new System.Drawing.Point(205, 397);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(98, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // buttonCancelForm
            // 
            this.buttonCancelForm.Location = new System.Drawing.Point(513, 409);
            this.buttonCancelForm.Name = "buttonCancelForm";
            this.buttonCancelForm.Size = new System.Drawing.Size(95, 22);
            this.buttonCancelForm.StyleController = this.layoutControl1;
            this.buttonCancelForm.TabIndex = 10;
            this.buttonCancelForm.Text = "Cancel";
            this.buttonCancelForm.Click += new System.EventHandler(this.buttonCancelForm_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.buttonCancelForm;
            this.layoutControlItem5.Location = new System.Drawing.Point(501, 397);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(99, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 443);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CoursesForm";
            this.Text = "CoursesForm";
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEditSubject;
        private DevExpress.XtraEditors.TextEdit textEditCode;
        private DevExpress.XtraEditors.ListBoxControl listBoxCourses;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlSubject;
        private DevExpress.XtraEditors.SimpleButton buttonCancelForm;
        private DevExpress.XtraEditors.SimpleButton buttonAddCourse;
        private DevExpress.XtraEditors.SimpleButton buttonSaveForm;
        private DevExpress.XtraEditors.SimpleButton buttonDeleteCourse;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}