namespace UniversityApp
{
    partial class MainUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.CourseEntryButton = new System.Windows.Forms.Button();
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Department Entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DepartmentButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EnrollmentButton);
            this.groupBox1.Controls.Add(this.CourseEntryButton);
            this.groupBox1.Controls.Add(this.StudentEntryButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "University Management System";
            // 
            // EnrollmentButton
            // 
            this.EnrollmentButton.Location = new System.Drawing.Point(216, 121);
            this.EnrollmentButton.Name = "EnrollmentButton";
            this.EnrollmentButton.Size = new System.Drawing.Size(135, 43);
            this.EnrollmentButton.TabIndex = 0;
            this.EnrollmentButton.Text = "Enrollment";
            this.EnrollmentButton.UseVisualStyleBackColor = true;
            // 
            // CourseEntryButton
            // 
            this.CourseEntryButton.Location = new System.Drawing.Point(52, 121);
            this.CourseEntryButton.Name = "CourseEntryButton";
            this.CourseEntryButton.Size = new System.Drawing.Size(135, 43);
            this.CourseEntryButton.TabIndex = 0;
            this.CourseEntryButton.Text = "Course Entry";
            this.CourseEntryButton.UseVisualStyleBackColor = true;
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.Location = new System.Drawing.Point(216, 54);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(135, 43);
            this.StudentEntryButton.TabIndex = 0;
            this.StudentEntryButton.Text = "Student Entry";
            this.StudentEntryButton.UseVisualStyleBackColor = true;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 227);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainUI";
            this.Text = "University Management System";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EnrollmentButton;
        private System.Windows.Forms.Button CourseEntryButton;
        private System.Windows.Forms.Button StudentEntryButton;
    }
}

