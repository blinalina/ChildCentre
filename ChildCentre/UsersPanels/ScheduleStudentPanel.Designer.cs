
namespace ChildCentre.UsersPanels
{
    partial class ScheduleStudentPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.Занятие = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПН = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ВТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СР = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЧТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СБ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Расписание занятий";
            // 
            // StudentScheduleDataGridView
            // 
            this.StudentScheduleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentScheduleDataGridView.BackgroundColor = System.Drawing.Color.Linen;
            this.StudentScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Занятие,
            this.ПН,
            this.ВТ,
            this.СР,
            this.ЧТ,
            this.ПТ,
            this.СБ});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentScheduleDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.StudentScheduleDataGridView.Location = new System.Drawing.Point(3, 77);
            this.StudentScheduleDataGridView.Name = "StudentScheduleDataGridView";
            this.StudentScheduleDataGridView.RowHeadersVisible = false;
            this.StudentScheduleDataGridView.RowHeadersWidth = 10;
            this.StudentScheduleDataGridView.RowTemplate.Height = 28;
            this.StudentScheduleDataGridView.Size = new System.Drawing.Size(758, 460);
            this.StudentScheduleDataGridView.TabIndex = 9;
            // 
            // Занятие
            // 
            this.Занятие.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Занятие.FillWeight = 357.9546F;
            this.Занятие.HeaderText = "Занятие";
            this.Занятие.MinimumWidth = 8;
            this.Занятие.Name = "Занятие";
            this.Занятие.ReadOnly = true;
            this.Занятие.Width = 90;
            // 
            // ПН
            // 
            this.ПН.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ПН.FillWeight = 57.00757F;
            this.ПН.HeaderText = "ПН";
            this.ПН.MinimumWidth = 8;
            this.ПН.Name = "ПН";
            this.ПН.ReadOnly = true;
            // 
            // ВТ
            // 
            this.ВТ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ВТ.FillWeight = 57.00757F;
            this.ВТ.HeaderText = "ВТ";
            this.ВТ.MinimumWidth = 8;
            this.ВТ.Name = "ВТ";
            this.ВТ.ReadOnly = true;
            // 
            // СР
            // 
            this.СР.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.СР.FillWeight = 57.00757F;
            this.СР.HeaderText = "СР";
            this.СР.MinimumWidth = 8;
            this.СР.Name = "СР";
            this.СР.ReadOnly = true;
            // 
            // ЧТ
            // 
            this.ЧТ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ЧТ.FillWeight = 57.00757F;
            this.ЧТ.HeaderText = "ЧТ";
            this.ЧТ.MinimumWidth = 8;
            this.ЧТ.Name = "ЧТ";
            this.ЧТ.ReadOnly = true;
            // 
            // ПТ
            // 
            this.ПТ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ПТ.FillWeight = 57.00757F;
            this.ПТ.HeaderText = "ПТ";
            this.ПТ.MinimumWidth = 8;
            this.ПТ.Name = "ПТ";
            this.ПТ.ReadOnly = true;
            // 
            // СБ
            // 
            this.СБ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.СБ.FillWeight = 57.00757F;
            this.СБ.HeaderText = "СБ";
            this.СБ.MinimumWidth = 8;
            this.СБ.Name = "СБ";
            this.СБ.ReadOnly = true;
            // 
            // ScheduleStudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentScheduleDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleStudentPanel";
            this.Size = new System.Drawing.Size(764, 549);
            ((System.ComponentModel.ISupportInitialize)(this.StudentScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StudentScheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Занятие;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПН;
        private System.Windows.Forms.DataGridViewTextBoxColumn ВТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn СР;
        private System.Windows.Forms.DataGridViewTextBoxColumn ЧТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn СБ;
    }
}
