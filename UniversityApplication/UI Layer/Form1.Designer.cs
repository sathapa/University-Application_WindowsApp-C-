//#Author: Santosh Thapa / UBID: 0997148 
namespace UniversityApplication
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.initializeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDbStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.IdbDepartments = new System.Windows.Forms.ToolStripMenuItem();
            this.IdbProfessors = new System.Windows.Forms.ToolStripMenuItem();
            this.IdbC = new System.Windows.Forms.ToolStripMenuItem();
            this.IdbCP = new System.Windows.Forms.ToolStripMenuItem();
            this.IdbCO = new System.Windows.Forms.ToolStripMenuItem();
            this.IdbCT = new System.Windows.Forms.ToolStripMenuItem();
            this.IdbSC = new System.Windows.Forms.ToolStripMenuItem();
            this.idbSM = new System.Windows.Forms.ToolStripMenuItem();
            this.idbPD = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SMViewStd = new System.Windows.Forms.ToolStripMenuItem();
            this.SMViewStdgd = new System.Windows.Forms.ToolStripMenuItem();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.courseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMViewCO = new System.Windows.Forms.ToolStripMenuItem();
            this.CMViewE = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeDBToolStripMenuItem,
            this.studentManagementToolStripMenuItem,
            this.courseManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // initializeDBToolStripMenuItem
            // 
            this.initializeDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IDbStudents,
            this.IdbDepartments,
            this.IdbProfessors,
            this.IdbC,
            this.IdbCP,
            this.IdbCO,
            this.IdbCT,
            this.IdbSC,
            this.idbSM,
            this.idbPD});
            this.initializeDBToolStripMenuItem.Name = "initializeDBToolStripMenuItem";
            this.initializeDBToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.initializeDBToolStripMenuItem.Text = "InitializeDB";
            // 
            // IDbStudents
            // 
            this.IDbStudents.Name = "IDbStudents";
            this.IDbStudents.Size = new System.Drawing.Size(191, 22);
            this.IDbStudents.Text = "Students";
            this.IDbStudents.Click += new System.EventHandler(this.IDbStudents_Click);
            // 
            // IdbDepartments
            // 
            this.IdbDepartments.Name = "IdbDepartments";
            this.IdbDepartments.Size = new System.Drawing.Size(191, 22);
            this.IdbDepartments.Text = "Departments";
            this.IdbDepartments.Click += new System.EventHandler(this.IdbDepartments_Click);
            // 
            // IdbProfessors
            // 
            this.IdbProfessors.Name = "IdbProfessors";
            this.IdbProfessors.Size = new System.Drawing.Size(191, 22);
            this.IdbProfessors.Text = "Professors";
            this.IdbProfessors.Click += new System.EventHandler(this.IdbProfessors_Click);
            // 
            // IdbC
            // 
            this.IdbC.Name = "IdbC";
            this.IdbC.Size = new System.Drawing.Size(191, 22);
            this.IdbC.Text = "Courses";
            this.IdbC.Click += new System.EventHandler(this.IdbC_Click);
            // 
            // IdbCP
            // 
            this.IdbCP.Name = "IdbCP";
            this.IdbCP.Size = new System.Drawing.Size(191, 22);
            this.IdbCP.Text = "CoursePrerequisites";
            this.IdbCP.Click += new System.EventHandler(this.IdbCP_Click);
            // 
            // IdbCO
            // 
            this.IdbCO.Name = "IdbCO";
            this.IdbCO.Size = new System.Drawing.Size(191, 22);
            this.IdbCO.Text = "CoursesOffered";
            this.IdbCO.Click += new System.EventHandler(this.IdbCO_Click);
            // 
            // IdbCT
            // 
            this.IdbCT.Name = "IdbCT";
            this.IdbCT.Size = new System.Drawing.Size(191, 22);
            this.IdbCT.Text = "CoursesTaken";
            this.IdbCT.Click += new System.EventHandler(this.IdbCT_Click);
            // 
            // IdbSC
            // 
            this.IdbSC.Name = "IdbSC";
            this.IdbSC.Size = new System.Drawing.Size(191, 22);
            this.IdbSC.Text = "StudentCourses";
            this.IdbSC.Click += new System.EventHandler(this.IdbSC_Click);
            // 
            // idbSM
            // 
            this.idbSM.Name = "idbSM";
            this.idbSM.Size = new System.Drawing.Size(191, 22);
            this.idbSM.Text = "StudentMajors";
            this.idbSM.Click += new System.EventHandler(this.idbSM_Click);
            // 
            // idbPD
            // 
            this.idbPD.Name = "idbPD";
            this.idbPD.Size = new System.Drawing.Size(191, 22);
            this.idbPD.Text = "ProfessorDepartments";
            this.idbPD.Click += new System.EventHandler(this.idbPD_Click);
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMViewStd,
            this.SMViewStdgd});
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // SMViewStd
            // 
            this.SMViewStd.Name = "SMViewStd";
            this.SMViewStd.Size = new System.Drawing.Size(182, 22);
            this.SMViewStd.Text = "View Students";
            this.SMViewStd.Click += new System.EventHandler(this.SMViewStd_Click);
            // 
            // SMViewStdgd
            // 
            this.SMViewStdgd.Name = "SMViewStdgd";
            this.SMViewStdgd.Size = new System.Drawing.Size(182, 22);
            this.SMViewStdgd.Text = "View Student Grades";
            this.SMViewStdgd.Click += new System.EventHandler(this.SMViewStdgd_Click);
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(12, 37);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(443, 190);
            this.dgData.TabIndex = 1;
            // 
            // courseManagementToolStripMenuItem
            // 
            this.courseManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMViewCO,
            this.CMViewE});
            this.courseManagementToolStripMenuItem.Name = "courseManagementToolStripMenuItem";
            this.courseManagementToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.courseManagementToolStripMenuItem.Text = "Course Management";
            // 
            // CMViewCO
            // 
            this.CMViewCO.Name = "CMViewCO";
            this.CMViewCO.Size = new System.Drawing.Size(187, 22);
            this.CMViewCO.Text = "View Courses Offered";
            this.CMViewCO.Click += new System.EventHandler(this.CMViewCO_Click);
            // 
            // CMViewE
            // 
            this.CMViewE.Name = "CMViewE";
            this.CMViewE.Size = new System.Drawing.Size(187, 22);
            this.CMViewE.Text = "View Enrollments";
            this.CMViewE.Click += new System.EventHandler(this.CMViewE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 252);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem initializeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IDbStudents;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.ToolStripMenuItem IdbDepartments;
        private System.Windows.Forms.ToolStripMenuItem IdbProfessors;
        private System.Windows.Forms.ToolStripMenuItem IdbC;
        private System.Windows.Forms.ToolStripMenuItem IdbCP;
        private System.Windows.Forms.ToolStripMenuItem IdbCO;
        private System.Windows.Forms.ToolStripMenuItem IdbCT;
        private System.Windows.Forms.ToolStripMenuItem IdbSC;
        private System.Windows.Forms.ToolStripMenuItem idbSM;
        private System.Windows.Forms.ToolStripMenuItem idbPD;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SMViewStd;
        private System.Windows.Forms.ToolStripMenuItem SMViewStdgd;
        private System.Windows.Forms.ToolStripMenuItem courseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMViewCO;
        private System.Windows.Forms.ToolStripMenuItem CMViewE;
    }
}

