
namespace ChildCentre.AdminPanels
{
    partial class SchedulePanel
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
            this.ScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.Учитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПН = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ВТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СР = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЧТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СБ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleDataGridView
            // 
            this.ScheduleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Учитель,
            this.ПН,
            this.ВТ,
            this.СР,
            this.ЧТ,
            this.ПТ,
            this.СБ});
            this.ScheduleDataGridView.Location = new System.Drawing.Point(3, 120);
            this.ScheduleDataGridView.Name = "ScheduleDataGridView";
            this.ScheduleDataGridView.RowHeadersWidth = 62;
            this.ScheduleDataGridView.RowTemplate.Height = 28;
            this.ScheduleDataGridView.Size = new System.Drawing.Size(625, 361);
            this.ScheduleDataGridView.TabIndex = 7;
            // 
            // Учитель
            // 
            this.Учитель.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Учитель.FillWeight = 357.9546F;
            this.Учитель.HeaderText = "Учитель";
            this.Учитель.MinimumWidth = 8;
            this.Учитель.Name = "Учитель";
            this.Учитель.Width = 150;
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
            // CoursesComboBox
            // 
            this.CoursesComboBox.FormattingEnabled = true;
            this.CoursesComboBox.Location = new System.Drawing.Point(330, 69);
            this.CoursesComboBox.Name = "CoursesComboBox";
            this.CoursesComboBox.Size = new System.Drawing.Size(210, 28);
            this.CoursesComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите занятие:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Расписание занятий";
            // 
            // SchedulePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScheduleDataGridView);
            this.Controls.Add(this.CoursesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SchedulePanel";
            this.Size = new System.Drawing.Size(631, 493);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ScheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Учитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПН;
        private System.Windows.Forms.DataGridViewTextBoxColumn ВТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn СР;
        private System.Windows.Forms.DataGridViewTextBoxColumn ЧТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn СБ;
        private System.Windows.Forms.ComboBox CoursesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
