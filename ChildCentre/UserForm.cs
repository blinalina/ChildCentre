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
    public partial class UserForm : Form
    {
        InformationPanel InformationPanel;
        ScheduleStudentPanel ScheduleStudentPanel;
        ScheduleTeacherPanel ScheduleTeacherPanel;
        public UserForm()
        {
            InitializeComponent();

            InformationPanel = new InformationPanel();
            InformationPanel.Visible = true;
            MainPanel.Controls.Add(InformationPanel);

            ScheduleStudentPanel = new ScheduleStudentPanel(Properties.Settings.Default.id);
            ScheduleStudentPanel.Visible = false;
            MainPanel.Controls.Add(ScheduleStudentPanel);

            ScheduleTeacherPanel = new ScheduleTeacherPanel(Properties.Settings.Default.id);
            ScheduleTeacherPanel.Visible = false;
            MainPanel.Controls.Add(ScheduleTeacherPanel);
        }

        private void ExitBotton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.id = -1;
            Properties.Settings.Default.role = -1;
            Properties.Settings.Default.Save();
            Hide();
            Application.OpenForms["AuthorizationForm"].Show();
        }
        private void ActivePanel(UserControl panel)
        {
            if (panel == InformationPanel)
            {
                InformationPanel.Visible = true;
                ScheduleStudentPanel.Visible = ScheduleTeacherPanel.Visible = false;
            }
            else if (panel == ScheduleStudentPanel)
            {
                ScheduleStudentPanel.Visible = true;
                ScheduleTeacherPanel.Visible = InformationPanel.Visible = false;
            }
            else if (panel == ScheduleTeacherPanel)
            {
                ScheduleTeacherPanel.Visible = true;
                ScheduleStudentPanel.Visible = InformationPanel.Visible = false;
            }
        }

        private void InformationButton_Click(object sender, EventArgs e)
        {
            ActivePanel(InformationPanel);
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.role==(int)Role.STUDENT)
                ActivePanel(ScheduleStudentPanel);
            if (Properties.Settings.Default.role == (int)Role.TEACHER)
                ActivePanel(ScheduleTeacherPanel);
        }

        private void ChangePassBotton_Click(object sender, EventArgs e)
        {
            ChangingPasswordForm frm = new ChangingPasswordForm();
            frm.Show();
        }
    }
}
