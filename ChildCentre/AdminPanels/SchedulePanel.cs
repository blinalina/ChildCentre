using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildCentre.AdminPanels
{
    public partial class SchedulePanel : UserControl
    {
        public SchedulePanel()
        {
            InitializeComponent();
        }
        List<ScheduleModel> ListOfAllSchedule = new List<ScheduleModel>();
        public void UpdateListOfCourses(List<ScheduleModel> list)
        {
            ListOfAllSchedule = list;
            CoursesComboBox.Items.Clear();
            for (int i = 0; i < ListOfAllSchedule.Count; i++)
            {
                if (!CoursesComboBox.Items.Contains(ListOfAllSchedule[i].Cours_name))
                {
                    CoursesComboBox.Items.Add(ListOfAllSchedule[i].Cours_name);
                }
            }
        }

        //public void UpdateInformation(AccountModel user)
        //{
        //    FullNameLabel.Text = user.FullName;
        //    LoginLabel.Text = user.Login;
        //    PhoneNumberLabel.Text = user.PhoneNumber;
        //    EmailLabel.Text = user.Email;
        //    DateOfBirthLabel.Text = user.DateOfBirth.Date.ToString();
        //}
        //private void ClearInformation()
        //{
        //    FullNameLabel.Text = "Нет данных";
        //    LoginLabel.Text = "Нет данных";
        //    PhoneNumberLabel.Text = "Нет данных";
        //    EmailLabel.Text = "Нет данных";
        //    DateOfBirthLabel.Text = "Нет данных";
        //}

        private void TeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoursesComboBox.SelectedIndex == -1)
            {
                //ClearInformation();
                return;
            }
            //UpdateInformation(ListOfAllCourses[CoursesComboBox.SelectedIndex]);
        }
    }
}
