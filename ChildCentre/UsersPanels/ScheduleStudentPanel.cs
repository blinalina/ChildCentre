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
    public partial class ScheduleStudentPanel : UserControl
    {
        public ScheduleStudentPanel()
        {
            InitializeComponent();
            GetSchedule();
        }
        public void GetSchedule()
        {
            List<ScheduleModel> schedule = new List<ScheduleModel>();
            schedule = DBClient.GetStudentSchedule(Properties.Settings.Default.id);
            for (int i = 0; i < schedule.Count; i++)
            {
                StudentScheduleDataGridView.Rows.Add(schedule[i].Cours_name, schedule[i].Class_room, schedule[i].Day_of_the_week);
            }
        }
    }
}
