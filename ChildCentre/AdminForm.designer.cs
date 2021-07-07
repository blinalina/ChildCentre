
namespace ChildCentre
{
    partial class AdminForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.StudentsButton = new System.Windows.Forms.Button();
            this.TeachersButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ScheduleButton.FlatAppearance.BorderSize = 0;
            this.ScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleButton.Location = new System.Drawing.Point(12, 12);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(123, 75);
            this.ScheduleButton.TabIndex = 0;
            this.ScheduleButton.Text = "Расписание";
            this.ScheduleButton.UseVisualStyleBackColor = false;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // StudentsButton
            // 
            this.StudentsButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.StudentsButton.FlatAppearance.BorderSize = 0;
            this.StudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsButton.Location = new System.Drawing.Point(12, 92);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(123, 75);
            this.StudentsButton.TabIndex = 1;
            this.StudentsButton.Text = "Ученики";
            this.StudentsButton.UseVisualStyleBackColor = false;
            this.StudentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
            // 
            // TeachersButton
            // 
            this.TeachersButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TeachersButton.FlatAppearance.BorderSize = 0;
            this.TeachersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeachersButton.Location = new System.Drawing.Point(12, 174);
            this.TeachersButton.Name = "TeachersButton";
            this.TeachersButton.Size = new System.Drawing.Size(123, 75);
            this.TeachersButton.TabIndex = 2;
            this.TeachersButton.Text = "Учителя";
            this.TeachersButton.UseVisualStyleBackColor = false;
            this.TeachersButton.Click += new System.EventHandler(this.TeachersButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(12, 431);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(123, 75);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AddUserButton.FlatAppearance.BorderSize = 0;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Location = new System.Drawing.Point(12, 255);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(123, 75);
            this.AddUserButton.TabIndex = 19;
            this.AddUserButton.Text = "Создать аккаунт";
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.Location = new System.Drawing.Point(150, 12);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(632, 492);
            this.ContentPanel.TabIndex = 20;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(795, 517);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TeachersButton);
            this.Controls.Add(this.StudentsButton);
            this.Controls.Add(this.ScheduleButton);
            this.Name = "AdminForm";
            this.Text = "Детский центр";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button StudentsButton;
        private System.Windows.Forms.Button TeachersButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}

