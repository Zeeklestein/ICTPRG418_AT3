namespace AT3_418
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
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxNewStudent = new System.Windows.Forms.GroupBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.cbxStudent = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.gbxViewStudent = new System.Windows.Forms.GroupBox();
            this.lblStudentResults = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.gbxLoadArray = new System.Windows.Forms.GroupBox();
            this.lbxArray = new System.Windows.Forms.ListBox();
            this.btnLoadArray = new System.Windows.Forms.Button();
            this.gbxNewStudent.SuspendLayout();
            this.gbxViewStudent.SuspendLayout();
            this.gbxLoadArray.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(6, 48);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(175, 26);
            this.txtStudentId.TabIndex = 0;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(3, 32);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(61, 13);
            this.lblStudentId.TabIndex = 1;
            this.lblStudentId.Text = "Student ID:";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(6, 93);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(202, 26);
            this.txtSubject.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(3, 77);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Subject:";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(6, 138);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 26);
            this.txtResult.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(3, 122);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(118, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxNewStudent
            // 
            this.gbxNewStudent.Controls.Add(this.lblStudentId);
            this.gbxNewStudent.Controls.Add(this.btnSave);
            this.gbxNewStudent.Controls.Add(this.txtStudentId);
            this.gbxNewStudent.Controls.Add(this.lblResult);
            this.gbxNewStudent.Controls.Add(this.txtResult);
            this.gbxNewStudent.Controls.Add(this.lblSubject);
            this.gbxNewStudent.Controls.Add(this.txtSubject);
            this.gbxNewStudent.Location = new System.Drawing.Point(12, 57);
            this.gbxNewStudent.Name = "gbxNewStudent";
            this.gbxNewStudent.Size = new System.Drawing.Size(224, 229);
            this.gbxNewStudent.TabIndex = 7;
            this.gbxNewStudent.TabStop = false;
            this.gbxNewStudent.Text = "New Student";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(581, 9);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(117, 13);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Ben Szekely 10042443";
            // 
            // cbxStudent
            // 
            this.cbxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStudent.FormattingEnabled = true;
            this.cbxStudent.Location = new System.Drawing.Point(6, 48);
            this.cbxStudent.Name = "cbxStudent";
            this.cbxStudent.Size = new System.Drawing.Size(184, 28);
            this.cbxStudent.TabIndex = 9;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(6, 32);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(47, 13);
            this.lblStudent.TabIndex = 10;
            this.lblStudent.Text = "Student:";
            // 
            // gbxViewStudent
            // 
            this.gbxViewStudent.Controls.Add(this.lblStudentResults);
            this.gbxViewStudent.Controls.Add(this.btnView);
            this.gbxViewStudent.Controls.Add(this.lblStudent);
            this.gbxViewStudent.Controls.Add(this.cbxStudent);
            this.gbxViewStudent.Location = new System.Drawing.Point(242, 57);
            this.gbxViewStudent.Name = "gbxViewStudent";
            this.gbxViewStudent.Size = new System.Drawing.Size(200, 229);
            this.gbxViewStudent.TabIndex = 11;
            this.gbxViewStudent.TabStop = false;
            this.gbxViewStudent.Text = "View Student";
            // 
            // lblStudentResults
            // 
            this.lblStudentResults.AutoSize = true;
            this.lblStudentResults.Location = new System.Drawing.Point(6, 93);
            this.lblStudentResults.Name = "lblStudentResults";
            this.lblStudentResults.Size = new System.Drawing.Size(0, 13);
            this.lblStudentResults.TabIndex = 11;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(90, 188);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 35);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // gbxLoadArray
            // 
            this.gbxLoadArray.Controls.Add(this.lbxArray);
            this.gbxLoadArray.Controls.Add(this.btnLoadArray);
            this.gbxLoadArray.Location = new System.Drawing.Point(448, 57);
            this.gbxLoadArray.Name = "gbxLoadArray";
            this.gbxLoadArray.Size = new System.Drawing.Size(250, 229);
            this.gbxLoadArray.TabIndex = 12;
            this.gbxLoadArray.TabStop = false;
            this.gbxLoadArray.Text = "Send to Array";
            // 
            // lbxArray
            // 
            this.lbxArray.FormattingEnabled = true;
            this.lbxArray.Location = new System.Drawing.Point(7, 20);
            this.lbxArray.Name = "lbxArray";
            this.lbxArray.Size = new System.Drawing.Size(237, 160);
            this.lbxArray.TabIndex = 13;
            // 
            // btnLoadArray
            // 
            this.btnLoadArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadArray.Location = new System.Drawing.Point(110, 188);
            this.btnLoadArray.Name = "btnLoadArray";
            this.btnLoadArray.Size = new System.Drawing.Size(134, 35);
            this.btnLoadArray.TabIndex = 12;
            this.btnLoadArray.Text = "Send to Array";
            this.btnLoadArray.UseVisualStyleBackColor = true;
            this.btnLoadArray.Click += new System.EventHandler(this.btnLoadArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 330);
            this.Controls.Add(this.gbxLoadArray);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.gbxNewStudent);
            this.Controls.Add(this.gbxViewStudent);
            this.Name = "Form1";
            this.Text = "AT3 - Student Results";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxNewStudent.ResumeLayout(false);
            this.gbxNewStudent.PerformLayout();
            this.gbxViewStudent.ResumeLayout(false);
            this.gbxViewStudent.PerformLayout();
            this.gbxLoadArray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxNewStudent;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cbxStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.GroupBox gbxViewStudent;
        private System.Windows.Forms.Label lblStudentResults;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox gbxLoadArray;
        private System.Windows.Forms.ListBox lbxArray;
        private System.Windows.Forms.Button btnLoadArray;
    }
}

