using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChildCentre.AdminPanels;
using ChildCentre.Utility;
using ChildCentre.Utility.DB;

namespace ChildCentre
{
    public partial class AdminForm : Form
    {
        StudentsPanel StudentsPanel;
        TeacherPanel TeacherPanel;
        SchedulePanel SchedulePanel;
        AddUserPanel AddUserPanel;
        public AdminForm()
        {
            InitializeComponent();
            StudentsPanel = new StudentsPanel();
            StudentsPanel.Visible = false;
            ContentPanel.Controls.Add(StudentsPanel);

            TeacherPanel = new TeacherPanel();
            TeacherPanel.Visible = false;
            ContentPanel.Controls.Add(TeacherPanel);

            SchedulePanel = new SchedulePanel();
            SchedulePanel.Visible = false;
            ContentPanel.Controls.Add(SchedulePanel);

            AddUserPanel = new AddUserPanel();
            AddUserPanel.Visible = false;
            ContentPanel.Controls.Add(AddUserPanel);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentsButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(StudentsPanel);
        }

        private void TeachersButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(TeacherPanel);
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(SchedulePanel);
        }

        private void SetActivePanel(UserControl panel)
        {
            if (panel == StudentsPanel)
            {
                StudentsPanel.Visible = true;
                TeacherPanel.Visible = SchedulePanel.Visible = AddUserPanel.Visible = false;
               
                var res = DBClient.GetAccounts((int)Role.STUDENT);
                StudentsPanel.UpdateListOfUser(res);
                Console.WriteLine(res.Count);
            }
            else if (panel == TeacherPanel)
            {
                TeacherPanel.Visible = true;
                StudentsPanel.Visible = SchedulePanel.Visible = AddUserPanel.Visible = false;

                var res = DBClient.GetAccounts((int)Role.TEACHER);
                TeacherPanel.UpdateListOfUser(res);
                Console.WriteLine(res.Count);
            }
            else if (panel == SchedulePanel)
            {
                SchedulePanel.Visible = true;
                TeacherPanel.Visible = StudentsPanel.Visible = AddUserPanel.Visible = false;

                var res = DBClient.GetCourses();
                SchedulePanel.UpdateListOfCourses(res);
                Console.WriteLine(res.Count);
            }
            else if (panel == AddUserPanel)
            {
                AddUserPanel.Visible = true;
                TeacherPanel.Visible = SchedulePanel.Visible = StudentsPanel.Visible = false;
            }
            else
            {
                StudentsPanel.Visible = TeacherPanel.Visible = SchedulePanel.Visible = AddUserPanel.Visible = false;
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(AddUserPanel);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.id = -1;
            Properties.Settings.Default.role = -1;
            Properties.Settings.Default.Save();
            Hide();
            Application.OpenForms["AuthorizationForm"].Show();
        }
    }
}
