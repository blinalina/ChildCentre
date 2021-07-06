using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChildCentre.UsersPanels;
using ChildCentre.Utility;
using ChildCentre.Utility.DB;

namespace ChildCentre.UsersPanels
{
    public partial class ScheduleTeacherPanel : UserControl
    {
        int idfrom;
        public ScheduleTeacherPanel(int idfr)
        {
            idfrom = idfr;
            InitializeComponent();
            GetSchedule();
        }
        public void GetSchedule()
        {
            TeacherScheduleDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            List<ScheduleModel> schedule = new List<ScheduleModel>();
            schedule = DBClient.GetTeacherSchedule(idfrom);

            Dictionary<string, int> lines = new Dictionary<string, int>();
            int n = 0;
            for (int i = 0; i < schedule.Count; i++)
            {
                if (!lines.ContainsKey(schedule[i].Cours_name))
                {
                    lines.Add(schedule[i].Cours_name, n);
                    n++;
                }
                else
                    continue;
            }

            foreach (var pair in lines)
            {
                TeacherScheduleDataGridView.Rows.Add(pair.Key);

                for (int k = 0; k < schedule.Count; k++)
                {
                    if (pair.Key == schedule[k].Cours_name)
                    {
                        TeacherScheduleDataGridView[schedule[k].Day_of_the_week, pair.Value].Value += schedule[k].Class_room + "\n" + schedule[k].St_time.Substring(0, 5) + " -" + schedule[k].En_time.Substring(0, 5) + "\n";
                    }

                }
            }

            TeacherScheduleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TeacherScheduleDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TeacherScheduleDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }
    }
}
