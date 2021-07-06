namespace ChildCentre
{
    partial class SignUpStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LessonComboBox = new System.Windows.Forms.ComboBox();
            this.TeacherСomboBox = new System.Windows.Forms.ComboBox();
            this.SignUpStudentButton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.DayAndTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запись ребенка на занятие";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Выберите занятие: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(66, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Выберите преподавателя: ";
            // 
            // LessonComboBox
            // 
            this.LessonComboBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonComboBox.FormattingEnabled = true;
            this.LessonComboBox.Location = new System.Drawing.Point(371, 81);
            this.LessonComboBox.Name = "LessonComboBox";
            this.LessonComboBox.Size = new System.Drawing.Size(196, 25);
            this.LessonComboBox.TabIndex = 42;
            this.LessonComboBox.SelectedIndexChanged += new System.EventHandler(this.LessonComboBox_SelectedIndexChanged);
            // 
            // TeacherСomboBox
            // 
            this.TeacherСomboBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherСomboBox.FormattingEnabled = true;
            this.TeacherСomboBox.Location = new System.Drawing.Point(371, 121);
            this.TeacherСomboBox.Name = "TeacherСomboBox";
            this.TeacherСomboBox.Size = new System.Drawing.Size(196, 25);
            this.TeacherСomboBox.TabIndex = 43;
            this.TeacherСomboBox.SelectedIndexChanged += new System.EventHandler(this.TeacherСomboBox_SelectedIndexChanged);
            // 
            // SignUpStudentButton
            // 
            this.SignUpStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SignUpStudentButton.FlatAppearance.BorderSize = 0;
            this.SignUpStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpStudentButton.Location = new System.Drawing.Point(375, 232);
            this.SignUpStudentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpStudentButton.Name = "SignUpStudentButton";
            this.SignUpStudentButton.Size = new System.Drawing.Size(153, 48);
            this.SignUpStudentButton.TabIndex = 50;
            this.SignUpStudentButton.Text = "Записать ";
            this.SignUpStudentButton.UseVisualStyleBackColor = false;
            this.SignUpStudentButton.Click += new System.EventHandler(this.SignUpStudentButton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Location = new System.Drawing.Point(534, 232);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(153, 48);
            this.Exitbutton.TabIndex = 51;
            this.Exitbutton.Text = "Выход";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // DayAndTimeComboBox
            // 
            this.DayAndTimeComboBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayAndTimeComboBox.FormattingEnabled = true;
            this.DayAndTimeComboBox.Location = new System.Drawing.Point(371, 161);
            this.DayAndTimeComboBox.Name = "DayAndTimeComboBox";
            this.DayAndTimeComboBox.Size = new System.Drawing.Size(196, 25);
            this.DayAndTimeComboBox.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(66, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Выберите день недели и время: ";
            // 
            // SignUpStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(699, 301);
            this.Controls.Add(this.DayAndTimeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.SignUpStudentButton);
            this.Controls.Add(this.TeacherСomboBox);
            this.Controls.Add(this.LessonComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpStudentForm";
            this.Text = "Детский центр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LessonComboBox;
        private System.Windows.Forms.ComboBox TeacherСomboBox;
        private System.Windows.Forms.Button SignUpStudentButton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.ComboBox DayAndTimeComboBox;
        private System.Windows.Forms.Label label4;
    }
}