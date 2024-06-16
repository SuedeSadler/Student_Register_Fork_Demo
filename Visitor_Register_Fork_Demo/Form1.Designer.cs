namespace Visitor_Register_Fork_Demo
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
            this.CourseGroup = new System.Windows.Forms.GroupBox();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.PersonalGroup = new System.Windows.Forms.GroupBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.DOB_Dtp = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.LNlbl = new System.Windows.Forms.Label();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.FNLbl = new System.Windows.Forms.Label();
            this.DOBlbl = new System.Windows.Forms.Label();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.PHlbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ListedInfoGroup = new System.Windows.Forms.GroupBox();
            this.FinalOutputListBox = new System.Windows.Forms.ListBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CourseGroup.SuspendLayout();
            this.PersonalGroup.SuspendLayout();
            this.ListedInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseGroup
            // 
            this.CourseGroup.Controls.Add(this.courseComboBox);
            this.CourseGroup.Location = new System.Drawing.Point(47, 326);
            this.CourseGroup.Margin = new System.Windows.Forms.Padding(2);
            this.CourseGroup.Name = "CourseGroup";
            this.CourseGroup.Padding = new System.Windows.Forms.Padding(2);
            this.CourseGroup.Size = new System.Drawing.Size(306, 70);
            this.CourseGroup.TabIndex = 27;
            this.CourseGroup.TabStop = false;
            this.CourseGroup.Text = "Chosen Course";
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Items.AddRange(new object[] {
            "L5 ITTS (Information Technology Technical Support)",
            "L5 IS (Information Systems)",
            "L6 SD (Software Development)",
            "L6 SA (System Administration)",
            "L7 CM (Cloud Management)"});
            this.courseComboBox.Location = new System.Drawing.Point(26, 31);
            this.courseComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(254, 24);
            this.courseComboBox.TabIndex = 0;
            // 
            // PersonalGroup
            // 
            this.PersonalGroup.Controls.Add(this.EmailTxt);
            this.PersonalGroup.Controls.Add(this.Emaillbl);
            this.PersonalGroup.Controls.Add(this.DOB_Dtp);
            this.PersonalGroup.Controls.Add(this.genderComboBox);
            this.PersonalGroup.Controls.Add(this.LNlbl);
            this.PersonalGroup.Controls.Add(this.FirstNameTxt);
            this.PersonalGroup.Controls.Add(this.FNLbl);
            this.PersonalGroup.Controls.Add(this.DOBlbl);
            this.PersonalGroup.Controls.Add(this.PhoneTxt);
            this.PersonalGroup.Controls.Add(this.PHlbl);
            this.PersonalGroup.Controls.Add(this.GenderLbl);
            this.PersonalGroup.Controls.Add(this.LastNameTxt);
            this.PersonalGroup.Location = new System.Drawing.Point(47, 63);
            this.PersonalGroup.Margin = new System.Windows.Forms.Padding(2);
            this.PersonalGroup.Name = "PersonalGroup";
            this.PersonalGroup.Padding = new System.Windows.Forms.Padding(2);
            this.PersonalGroup.Size = new System.Drawing.Size(306, 236);
            this.PersonalGroup.TabIndex = 26;
            this.PersonalGroup.TabStop = false;
            this.PersonalGroup.Text = "Personal details";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(117, 197);
            this.EmailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(162, 22);
            this.EmailTxt.TabIndex = 17;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(64, 200);
            this.Emaillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(41, 16);
            this.Emaillbl.TabIndex = 16;
            this.Emaillbl.Text = "Email";
            // 
            // DOB_Dtp
            // 
            this.DOB_Dtp.Location = new System.Drawing.Point(117, 98);
            this.DOB_Dtp.Margin = new System.Windows.Forms.Padding(2);
            this.DOB_Dtp.Name = "DOB_Dtp";
            this.DOB_Dtp.Size = new System.Drawing.Size(162, 22);
            this.DOB_Dtp.TabIndex = 15;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Gender Diverse"});
            this.genderComboBox.Location = new System.Drawing.Point(117, 132);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(162, 24);
            this.genderComboBox.TabIndex = 14;
            // 
            // LNlbl
            // 
            this.LNlbl.AutoSize = true;
            this.LNlbl.Location = new System.Drawing.Point(41, 68);
            this.LNlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNlbl.Name = "LNlbl";
            this.LNlbl.Size = new System.Drawing.Size(72, 16);
            this.LNlbl.TabIndex = 13;
            this.LNlbl.Text = "Last Name";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(116, 30);
            this.FirstNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(163, 22);
            this.FirstNameTxt.TabIndex = 0;
            // 
            // FNLbl
            // 
            this.FNLbl.AutoSize = true;
            this.FNLbl.Location = new System.Drawing.Point(41, 35);
            this.FNLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FNLbl.Name = "FNLbl";
            this.FNLbl.Size = new System.Drawing.Size(72, 16);
            this.FNLbl.TabIndex = 1;
            this.FNLbl.Text = "First Name";
            // 
            // DOBlbl
            // 
            this.DOBlbl.AutoSize = true;
            this.DOBlbl.Location = new System.Drawing.Point(37, 102);
            this.DOBlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(79, 16);
            this.DOBlbl.TabIndex = 3;
            this.DOBlbl.Text = "Date of Birth";
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(116, 166);
            this.PhoneTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(162, 22);
            this.PhoneTxt.TabIndex = 6;
            // 
            // PHlbl
            // 
            this.PHlbl.AutoSize = true;
            this.PHlbl.Location = new System.Drawing.Point(23, 167);
            this.PHlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PHlbl.Name = "PHlbl";
            this.PHlbl.Size = new System.Drawing.Size(97, 16);
            this.PHlbl.TabIndex = 7;
            this.PHlbl.Text = "Phone Number";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Location = new System.Drawing.Point(56, 135);
            this.GenderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(52, 16);
            this.GenderLbl.TabIndex = 11;
            this.GenderLbl.Text = "Gender";
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(117, 66);
            this.LastNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(162, 22);
            this.LastNameTxt.TabIndex = 1;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(47, 414);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(160, 33);
            this.SubmitBtn.TabIndex = 24;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Enrollment Form";
            // 
            // ListedInfoGroup
            // 
            this.ListedInfoGroup.Controls.Add(this.FinalOutputListBox);
            this.ListedInfoGroup.Location = new System.Drawing.Point(373, 63);
            this.ListedInfoGroup.Margin = new System.Windows.Forms.Padding(2);
            this.ListedInfoGroup.Name = "ListedInfoGroup";
            this.ListedInfoGroup.Padding = new System.Windows.Forms.Padding(2);
            this.ListedInfoGroup.Size = new System.Drawing.Size(284, 384);
            this.ListedInfoGroup.TabIndex = 28;
            this.ListedInfoGroup.TabStop = false;
            this.ListedInfoGroup.Text = "Your Course Enrollment Information";
            // 
            // FinalOutputListBox
            // 
            this.FinalOutputListBox.FormattingEnabled = true;
            this.FinalOutputListBox.ItemHeight = 16;
            this.FinalOutputListBox.Location = new System.Drawing.Point(13, 26);
            this.FinalOutputListBox.Margin = new System.Windows.Forms.Padding(2);
            this.FinalOutputListBox.Name = "FinalOutputListBox";
            this.FinalOutputListBox.Size = new System.Drawing.Size(252, 340);
            this.FinalOutputListBox.TabIndex = 19;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(221, 415);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(123, 30);
            this.DeleteBtn.TabIndex = 29;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(699, 481);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CourseGroup);
            this.Controls.Add(this.PersonalGroup);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ListedInfoGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CourseGroup.ResumeLayout(false);
            this.PersonalGroup.ResumeLayout(false);
            this.PersonalGroup.PerformLayout();
            this.ListedInfoGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CourseGroup;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.GroupBox PersonalGroup;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.DateTimePicker DOB_Dtp;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label LNlbl;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.Label FNLbl;
        private System.Windows.Forms.Label DOBlbl;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.Label PHlbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox ListedInfoGroup;
        private System.Windows.Forms.ListBox FinalOutputListBox;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

