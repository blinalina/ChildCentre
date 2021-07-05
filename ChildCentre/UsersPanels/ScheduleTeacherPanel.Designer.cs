﻿
namespace ChildCentre.UsersPanels
{
    partial class ScheduleTeacherPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.Занятие = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПН = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ВТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СР = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЧТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СБ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(129, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расписание занятий";
            // 
            // TeacherScheduleDataGridView
            // 
            this.TeacherScheduleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeacherScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherScheduleDataGridView.BackgroundColor = System.Drawing.Color.Linen;
            this.TeacherScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Занятие,
            this.ПН,
            this.ВТ,
            this.СР,
            this.ЧТ,
            this.ПТ,
            this.СБ});
            this.TeacherScheduleDataGridView.Location = new System.Drawing.Point(2, 62);
            this.TeacherScheduleDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherScheduleDataGridView.Name = "TeacherScheduleDataGridView";
            this.TeacherScheduleDataGridView.RowHeadersVisible = false;
            this.TeacherScheduleDataGridView.RowHeadersWidth = 62;
            this.TeacherScheduleDataGridView.RowTemplate.Height = 28;
            this.TeacherScheduleDataGridView.Size = new System.Drawing.Size(417, 111);
            this.TeacherScheduleDataGridView.TabIndex = 8;
            // 
            // Занятие
            // 
            this.Занятие.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Занятие.FillWeight = 357.9546F;
            this.Занятие.HeaderText = "Занятие";
            this.Занятие.MinimumWidth = 8;
            this.Занятие.Name = "Занятие";
            this.Занятие.Width = 150;
            // 
            // ПН
            // 
            this.ПН.FillWeight = 57.00757F;
            this.ПН.HeaderText = "ПН";
            this.ПН.MinimumWidth = 8;
            this.ПН.Name = "ПН";
            // 
            // ВТ
            // 
            this.ВТ.FillWeight = 57.00757F;
            this.ВТ.HeaderText = "ВТ";
            this.ВТ.MinimumWidth = 8;
            this.ВТ.Name = "ВТ";
            // 
            // СР
            // 
            this.СР.FillWeight = 57.00757F;
            this.СР.HeaderText = "СР";
            this.СР.MinimumWidth = 8;
            this.СР.Name = "СР";
            // 
            // ЧТ
            // 
            this.ЧТ.FillWeight = 57.00757F;
            this.ЧТ.HeaderText = "ЧТ";
            this.ЧТ.MinimumWidth = 8;
            this.ЧТ.Name = "ЧТ";
            this.ЧТ.ReadOnly = true;
            // 
            // ПТ
            // 
            this.ПТ.FillWeight = 57.00757F;
            this.ПТ.HeaderText = "ПТ";
            this.ПТ.MinimumWidth = 8;
            this.ПТ.Name = "ПТ";
            this.ПТ.ReadOnly = true;
            // 
            // СБ
            // 
            this.СБ.FillWeight = 57.00757F;
            this.СБ.HeaderText = "СБ";
            this.СБ.MinimumWidth = 8;
            this.СБ.Name = "СБ";
            this.СБ.ReadOnly = true;
            // 
            // ScheduleTeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeacherScheduleDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleTeacherPanel";
            this.Size = new System.Drawing.Size(421, 320);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TeacherScheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Занятие;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПН;
        private System.Windows.Forms.DataGridViewTextBoxColumn ВТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn СР;
        private System.Windows.Forms.DataGridViewTextBoxColumn ЧТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn СБ;
    }
}