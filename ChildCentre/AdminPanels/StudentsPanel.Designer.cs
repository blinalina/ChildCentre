
namespace ChildCentre.AdminPanels
{
    partial class StudentsPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SignUpStudentButton = new System.Windows.Forms.Button();
            this.EditAccountButton = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.StudentsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScheduleStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(410, 220);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(99, 20);
            this.LoginLabel.TabIndex = 31;
            this.LoginLabel.Text = "Нет данных";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Логин:";
            // 
            // SignUpStudentButton
            // 
            this.SignUpStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SignUpStudentButton.FlatAppearance.BorderSize = 0;
            this.SignUpStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpStudentButton.Location = new System.Drawing.Point(234, 403);
            this.SignUpStudentButton.Name = "SignUpStudentButton";
            this.SignUpStudentButton.Size = new System.Drawing.Size(172, 60);
            this.SignUpStudentButton.TabIndex = 29;
            this.SignUpStudentButton.Text = "Записать на занятие";
            this.SignUpStudentButton.UseVisualStyleBackColor = false;
            this.SignUpStudentButton.Click += new System.EventHandler(this.SignUpStudentButton_Click);
            // 
            // EditAccountButton
            // 
            this.EditAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditAccountButton.FlatAppearance.BorderSize = 0;
            this.EditAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditAccountButton.Location = new System.Drawing.Point(57, 403);
            this.EditAccountButton.Name = "EditAccountButton";
            this.EditAccountButton.Size = new System.Drawing.Size(172, 60);
            this.EditAccountButton.TabIndex = 28;
            this.EditAccountButton.Text = "Редактировать аккаунт";
            this.EditAccountButton.UseVisualStyleBackColor = false;
            this.EditAccountButton.Click += new System.EventHandler(this.EditAccountButton_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(410, 325);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(99, 20);
            this.EmailLabel.TabIndex = 26;
            this.EmailLabel.Text = "Нет данных";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(410, 288);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(99, 20);
            this.PhoneNumberLabel.TabIndex = 25;
            this.PhoneNumberLabel.Text = "Нет данных";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(410, 252);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(99, 20);
            this.DateOfBirthLabel.TabIndex = 24;
            this.DateOfBirthLabel.Text = "Нет данных";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Электронная почта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Контактный номер:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Дата рождения:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(125, 149);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(147, 29);
            this.FullNameLabel.TabIndex = 19;
            this.FullNameLabel.Text = "Нет данных";
            // 
            // StudentsComboBox
            // 
            this.StudentsComboBox.FormattingEnabled = true;
            this.StudentsComboBox.Items.AddRange(new object[] {
            "Ленский Алексей Юрьевич",
            "Мурман Екатерина Александровна",
            "Сэльман Арсений Петрович"});
            this.StudentsComboBox.Location = new System.Drawing.Point(234, 89);
            this.StudentsComboBox.Name = "StudentsComboBox";
            this.StudentsComboBox.Size = new System.Drawing.Size(374, 28);
            this.StudentsComboBox.TabIndex = 18;
            this.StudentsComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выберите ученика:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(258, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ученики";
            // 
            // ScheduleStudentButton
            // 
            this.ScheduleStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScheduleStudentButton.FlatAppearance.BorderSize = 0;
            this.ScheduleStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleStudentButton.Location = new System.Drawing.Point(411, 403);
            this.ScheduleStudentButton.Name = "ScheduleStudentButton";
            this.ScheduleStudentButton.Size = new System.Drawing.Size(172, 60);
            this.ScheduleStudentButton.TabIndex = 32;
            this.ScheduleStudentButton.Text = "Расписание";
            this.ScheduleStudentButton.UseVisualStyleBackColor = false;
            this.ScheduleStudentButton.Click += new System.EventHandler(this.ScheduleStudentButton_Click);
            // 
            // StudentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScheduleStudentButton);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SignUpStudentButton);
            this.Controls.Add(this.EditAccountButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.StudentsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentsPanel";
            this.Size = new System.Drawing.Size(632, 492);
            this.VisibleChanged += new System.EventHandler(this.StudentsPanel_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SignUpStudentButton;
        private System.Windows.Forms.Button EditAccountButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.ComboBox StudentsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ScheduleStudentButton;
    }
}
