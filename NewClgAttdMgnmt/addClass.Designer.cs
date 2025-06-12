namespace NewClgAttdMgnmt
{
    partial class addClass
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
            this.pnlbtnCourse = new System.Windows.Forms.Button();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewCourse = new System.Windows.Forms.Button();
            this.btnNewSem = new System.Windows.Forms.Button();
            this.btnNewSub = new System.Windows.Forms.Button();
            this.pnlCourse = new System.Windows.Forms.Panel();
            this.pnlSemester = new System.Windows.Forms.Panel();
            this.pnlSubject = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSubSem = new System.Windows.Forms.ComboBox();
            this.pnlbtnSub = new System.Windows.Forms.Button();
            this.pnltxtSub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlbtnSem = new System.Windows.Forms.Button();
            this.pnltxtSemester = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCourse.SuspendLayout();
            this.pnlSemester.SuspendLayout();
            this.pnlSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlbtnCourse
            // 
            this.pnlbtnCourse.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlbtnCourse.Location = new System.Drawing.Point(142, 211);
            this.pnlbtnCourse.Name = "pnlbtnCourse";
            this.pnlbtnCourse.Size = new System.Drawing.Size(150, 46);
            this.pnlbtnCourse.TabIndex = 5;
            this.pnlbtnCourse.Text = "ADD";
            this.pnlbtnCourse.UseVisualStyleBackColor = true;
            this.pnlbtnCourse.Click += new System.EventHandler(this.pnlbtnCourse_Click);
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(104, 148);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(226, 33);
            this.txtCourse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Course Name :";
            // 
            // btnNewCourse
            // 
            this.btnNewCourse.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCourse.Location = new System.Drawing.Point(30, 61);
            this.btnNewCourse.Name = "btnNewCourse";
            this.btnNewCourse.Size = new System.Drawing.Size(300, 46);
            this.btnNewCourse.TabIndex = 10;
            this.btnNewCourse.Text = "Add New Course ";
            this.btnNewCourse.UseVisualStyleBackColor = true;
            this.btnNewCourse.Click += new System.EventHandler(this.btnNewCourse_Click);
            // 
            // btnNewSem
            // 
            this.btnNewSem.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSem.Location = new System.Drawing.Point(30, 148);
            this.btnNewSem.Name = "btnNewSem";
            this.btnNewSem.Size = new System.Drawing.Size(306, 46);
            this.btnNewSem.TabIndex = 11;
            this.btnNewSem.Text = "Add Semester To Existing Course";
            this.btnNewSem.UseVisualStyleBackColor = true;
            this.btnNewSem.Click += new System.EventHandler(this.btnNewSem_Click);
            // 
            // btnNewSub
            // 
            this.btnNewSub.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSub.Location = new System.Drawing.Point(30, 232);
            this.btnNewSub.Name = "btnNewSub";
            this.btnNewSub.Size = new System.Drawing.Size(306, 46);
            this.btnNewSub.TabIndex = 12;
            this.btnNewSub.Text = "Add Subject To Existing Semester";
            this.btnNewSub.UseVisualStyleBackColor = true;
            this.btnNewSub.Click += new System.EventHandler(this.btnNewSub_Click);
            // 
            // pnlCourse
            // 
            this.pnlCourse.Controls.Add(this.pnlSemester);
            this.pnlCourse.Controls.Add(this.txtCourse);
            this.pnlCourse.Controls.Add(this.label3);
            this.pnlCourse.Controls.Add(this.pnlbtnCourse);
            this.pnlCourse.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCourse.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCourse.Location = new System.Drawing.Point(372, 0);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.Size = new System.Drawing.Size(434, 503);
            this.pnlCourse.TabIndex = 13;
            // 
            // pnlSemester
            // 
            this.pnlSemester.Controls.Add(this.pnlSubject);
            this.pnlSemester.Controls.Add(this.pnlbtnSem);
            this.pnlSemester.Controls.Add(this.pnltxtSemester);
            this.pnlSemester.Controls.Add(this.label1);
            this.pnlSemester.Controls.Add(this.label2);
            this.pnlSemester.Controls.Add(this.cmbCourse);
            this.pnlSemester.Location = new System.Drawing.Point(3, 14);
            this.pnlSemester.Name = "pnlSemester";
            this.pnlSemester.Size = new System.Drawing.Size(416, 475);
            this.pnlSemester.TabIndex = 10;
            // 
            // pnlSubject
            // 
            this.pnlSubject.Controls.Add(this.label8);
            this.pnlSubject.Controls.Add(this.cmbSubSem);
            this.pnlSubject.Controls.Add(this.pnlbtnSub);
            this.pnlSubject.Controls.Add(this.pnltxtSub);
            this.pnlSubject.Controls.Add(this.label6);
            this.pnlSubject.Location = new System.Drawing.Point(3, 156);
            this.pnlSubject.Name = "pnlSubject";
            this.pnlSubject.Size = new System.Drawing.Size(416, 323);
            this.pnlSubject.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Subject Name :";
            // 
            // cmbSubSem
            // 
            this.cmbSubSem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubSem.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubSem.FormattingEnabled = true;
            this.cmbSubSem.Location = new System.Drawing.Point(106, 39);
            this.cmbSubSem.Name = "cmbSubSem";
            this.cmbSubSem.Size = new System.Drawing.Size(200, 34);
            this.cmbSubSem.TabIndex = 13;
            this.cmbSubSem.SelectedIndexChanged += new System.EventHandler(this.cmbSubSem_SelectedIndexChanged);
            // 
            // pnlbtnSub
            // 
            this.pnlbtnSub.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlbtnSub.Location = new System.Drawing.Point(133, 201);
            this.pnlbtnSub.Name = "pnlbtnSub";
            this.pnlbtnSub.Size = new System.Drawing.Size(150, 46);
            this.pnlbtnSub.TabIndex = 11;
            this.pnlbtnSub.Text = "ADD";
            this.pnlbtnSub.UseVisualStyleBackColor = true;
            this.pnlbtnSub.Click += new System.EventHandler(this.pnlbtnSub_Click);
            // 
            // pnltxtSub
            // 
            this.pnltxtSub.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnltxtSub.Location = new System.Drawing.Point(93, 127);
            this.pnltxtSub.Name = "pnltxtSub";
            this.pnltxtSub.Size = new System.Drawing.Size(226, 33);
            this.pnltxtSub.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Semester Name :";
            // 
            // pnlbtnSem
            // 
            this.pnlbtnSem.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlbtnSem.Location = new System.Drawing.Point(139, 282);
            this.pnlbtnSem.Name = "pnlbtnSem";
            this.pnlbtnSem.Size = new System.Drawing.Size(150, 46);
            this.pnlbtnSem.TabIndex = 11;
            this.pnlbtnSem.Text = "ADD";
            this.pnlbtnSem.UseVisualStyleBackColor = true;
            this.pnlbtnSem.Click += new System.EventHandler(this.pnlbtnSem_Click);
            // 
            // pnltxtSemester
            // 
            this.pnltxtSemester.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnltxtSemester.Location = new System.Drawing.Point(100, 228);
            this.pnltxtSemester.Name = "pnltxtSemester";
            this.pnltxtSemester.Size = new System.Drawing.Size(226, 33);
            this.pnltxtSemester.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Semester Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Course :";
            // 
            // cmbCourse
            // 
            this.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCourse.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(113, 110);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(200, 34);
            this.cmbCourse.TabIndex = 11;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 14;
            // 
            // addClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNewSub);
            this.Controls.Add(this.btnNewSem);
            this.Controls.Add(this.btnNewCourse);
            this.Font = new System.Drawing.Font("Calibri", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "addClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Course Information";
            this.Load += new System.EventHandler(this.addClass_Load);
            this.pnlCourse.ResumeLayout(false);
            this.pnlCourse.PerformLayout();
            this.pnlSemester.ResumeLayout(false);
            this.pnlSemester.PerformLayout();
            this.pnlSubject.ResumeLayout(false);
            this.pnlSubject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pnlbtnCourse;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewCourse;
        private System.Windows.Forms.Button btnNewSem;
        private System.Windows.Forms.Button btnNewSub;
        private System.Windows.Forms.Panel pnlCourse;
        private System.Windows.Forms.Panel pnlSemester;
        private System.Windows.Forms.Button pnlbtnSem;
        private System.Windows.Forms.TextBox pnltxtSemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSubSem;
        private System.Windows.Forms.Button pnlbtnSub;
        private System.Windows.Forms.TextBox pnltxtSub;
        private System.Windows.Forms.Label label6;
    }
}