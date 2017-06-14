namespace UniversityApplication
{
    partial class ViewStudents
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
            this.cmbDpt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDpt
            // 
            this.cmbDpt.FormattingEnabled = true;
            this.cmbDpt.Items.AddRange(new object[] {
            "Computer Science",
            "Computer Engineering",
            "Electrical Engineering",
            "Math",
            "Technology Management"});
            this.cmbDpt.Location = new System.Drawing.Point(129, 38);
            this.cmbDpt.Name = "cmbDpt";
            this.cmbDpt.Size = new System.Drawing.Size(121, 21);
            this.cmbDpt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department";
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnViewStudents.Location = new System.Drawing.Point(52, 82);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(92, 23);
            this.btnViewStudents.TabIndex = 2;
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(173, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 142);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDpt);
            this.Name = "ViewStudents";
            this.Text = "ViewStudents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnCancel;
    }
}