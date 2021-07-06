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

namespace ChildCentre
{
    public partial class TeacherScheduleForm : Form
    {
        ScheduleTeacherPanel ScheduleTeacherPanel;
        public TeacherScheduleForm(int idfr)
        {
            InitializeComponent();
            ScheduleTeacherPanel = new ScheduleTeacherPanel(idfr);
            ScheduleTeacherPanel.Visible = true;
            MainPanel.Controls.Add(ScheduleTeacherPanel);
        }
    }
}
