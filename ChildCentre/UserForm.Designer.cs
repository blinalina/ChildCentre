
namespace ChildCentre
{
    partial class UserForm
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
            this.ExitBotton = new System.Windows.Forms.Button();
            this.ChangePassBotton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.InformationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBotton
            // 
            this.ExitBotton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ExitBotton.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.ExitBotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBotton.Location = new System.Drawing.Point(11, 320);
            this.ExitBotton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBotton.Name = "ExitBotton";
            this.ExitBotton.Size = new System.Drawing.Size(100, 49);
            this.ExitBotton.TabIndex = 0;
            this.ExitBotton.Text = "Выход";
            this.ExitBotton.UseVisualStyleBackColor = false;
            this.ExitBotton.Click += new System.EventHandler(this.ExitBotton_Click);
            // 
            // ChangePassBotton
            // 
            this.ChangePassBotton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ChangePassBotton.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.ChangePassBotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePassBotton.Location = new System.Drawing.Point(11, 176);
            this.ChangePassBotton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePassBotton.Name = "ChangePassBotton";
            this.ChangePassBotton.Size = new System.Drawing.Size(100, 49);
            this.ChangePassBotton.TabIndex = 1;
            this.ChangePassBotton.Text = "Смена\r\nпароля";
            this.ChangePassBotton.UseVisualStyleBackColor = false;
            this.ChangePassBotton.Click += new System.EventHandler(this.ChangePassBotton_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ScheduleButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.ScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScheduleButton.Location = new System.Drawing.Point(11, 94);
            this.ScheduleButton.Margin = new System.Windows.Forms.Padding(2);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(100, 49);
            this.ScheduleButton.TabIndex = 2;
            this.ScheduleButton.Text = "Расписание";
            this.ScheduleButton.UseVisualStyleBackColor = false;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(125, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(423, 357);
            this.MainPanel.TabIndex = 3;
            // 
            // InformationButton
            // 
            this.InformationButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.InformationButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.InformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationButton.Location = new System.Drawing.Point(11, 12);
            this.InformationButton.Margin = new System.Windows.Forms.Padding(2);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(100, 49);
            this.InformationButton.TabIndex = 4;
            this.InformationButton.Text = "Моя\r\nстраница\r\n";
            this.InformationButton.UseVisualStyleBackColor = false;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(563, 380);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ScheduleButton);
            this.Controls.Add(this.ChangePassBotton);
            this.Controls.Add(this.ExitBotton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.Text = "Личная страница";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBotton;
        private System.Windows.Forms.Button ChangePassBotton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button InformationButton;
    }
}