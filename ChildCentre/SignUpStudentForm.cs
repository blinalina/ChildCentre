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
using ChildCentre.Utility.DB;


namespace ChildCentre
{
    public partial class SignUpStudentForm : Form
    {
        public SignUpStudentForm(ComboBox combo)
        {
            combo1 = combo;
            InitializeComponent();
            AddLessons();
            
        }
        private ComboBox combo1; 

        private void AddLessons()
        {
            LessonComboBox.Items.AddRange(DBClient.AddLessonsFromDB());
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpStudentButton_Click(object sender, EventArgs e)
        {
            string nameStudent = combo1.Text;
            int idLesson = LessonComboBox.Items.IndexOf(LessonComboBox.Text) + 1;
            string idLesson1 = Convert.ToString(idLesson);
            string nameTeacher = TeacherСomboBox.Text;
            string nameDayAndTime = DayAndTimeComboBox.Text;
            
            bool res = false;
            try
            {
                string[] result = DBClient.SignUpStudent(nameStudent, nameTeacher, idLesson1, nameDayAndTime);
                string idStudent = result[0];
                string idSchedule = result[1];
                res = DBClient.SignUpStudent(idStudent, idSchedule);
                
            }
            catch (UserNotFoundException)
            {
                MessageBox.Show("Не выбран ученик");
            }
            catch (FieldsEmptyException)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            catch(UserAlreadyExistsException)
            {
                MessageBox.Show("Такая запись уже существует");
            }
            
            if (res)
            {
                MessageBox.Show("Ученик записан");
            }
        }

        private void LessonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeacherСomboBox.Items.Clear();
            TeacherСomboBox.ResetText();
            DayAndTimeComboBox.Items.Clear();
            DayAndTimeComboBox.ResetText();
            int indexLessonDB = LessonComboBox.Items.IndexOf(LessonComboBox.Text) +1;
            TeacherСomboBox.Items.AddRange(DBClient.AddTeachersFromDB(indexLessonDB));

        }

        private void TeacherСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayAndTimeComboBox.Items.Clear();
            int indexLessonDB = LessonComboBox.Items.IndexOf(LessonComboBox.Text) + 1;
            string indexTeacherDB = TeacherСomboBox.Text;
            DayAndTimeComboBox.Items.AddRange(DBClient.AddDayAndTimeFromDB(indexLessonDB,indexTeacherDB));
        }
    }
}
