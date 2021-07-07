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
    public partial class StudentScheduleForm : Form
    {
        ScheduleStudentPanel ScheduleStudentPanel;
        public StudentScheduleForm(int idfr)
        {
            InitializeComponent();

            ScheduleStudentPanel = new ScheduleStudentPanel(idfr);
            ScheduleStudentPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            ScheduleStudentPanel.Visible = true;
            MainPanel.Controls.Add(ScheduleStudentPanel);
        }
    }
}
