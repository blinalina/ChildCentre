using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChildCentre.Utility;
using ChildCentre.Utility.DB;

namespace ChildCentre.AdminPanels
{
    public partial class SchedulePanel : UserControl
    {
        public SchedulePanel()
        {
            InitializeComponent();
            ScheduleDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        List<CourseModel> CoursesList = new List<CourseModel>();
        public void UpdateListOfCourses(List<CourseModel> list)
        {
            CoursesList = list;
            CoursesComboBox.Items.Clear();
            for (int i = 0; i < CoursesList.Count; i++)
            {
                    CoursesComboBox.Items.Add(CoursesList[i].Name);
            }
        }
        private void SchedulePanel_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            { 
                ScheduleDataGridView.Rows.Clear();
                CoursesComboBox.SelectedIndex = -1;
            }
        }
        public void GetSchedule(int cours_id)
        {
            List<ScheduleModel> schedule = new List<ScheduleModel>();
            schedule = DBClient.GetAdminSchedule(cours_id);
            Dictionary<string, int> lines = new Dictionary<string, int>();

            if (schedule.Count == 0)
                MessageBox.Show("По этому предмету еще нет занятий.");
            else
            {
                int n = 0;
                for (int i = 0; i < schedule.Count; i++)
                {
                    if (!lines.ContainsKey(schedule[i].Name_teacher))
                    {
                        lines.Add(schedule[i].Name_teacher, n);
                        n++;
                    }
                }

                foreach (var pair in lines)
                {
                    ScheduleDataGridView.Rows.Add(pair.Key);

                    for (int k = 0; k < schedule.Count; k++)
                    {
                        if (pair.Key == schedule[k].Name_teacher)
                        {
                            ScheduleDataGridView[schedule[k].Day_of_the_week, pair.Value].Value = schedule[k].Class_room + "\n" + schedule[k].St_time.Substring(0, 5) + " -" + schedule[k].En_time.Substring(0, 5) + "\n";
                        }

                    }
                }

                ScheduleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                ScheduleDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                ScheduleDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public void ClearDataGridView()
        {
            ScheduleDataGridView.Rows.Clear();
        }

        private void CoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (CoursesComboBox.SelectedIndex == -1)
            {
                return;
            }
            GetSchedule(CoursesList[CoursesComboBox.SelectedIndex].ID);
        }
    }
}
