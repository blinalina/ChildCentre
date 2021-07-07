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
    public partial class TeacherPanel : UserControl
    {
        public TeacherPanel()
        {
            InitializeComponent();
        }
        List<AccountModel> ListOfAllUser = new List<AccountModel>();
        public void UpdateListOfUser(List<AccountModel> list)
        {
            ListOfAllUser = list;
            TeacherComboBox.Items.Clear();
            for (int i = 0; i < ListOfAllUser.Count; i++)
            {
                TeacherComboBox.Items.Add(ListOfAllUser[i].FullName);
            }
        }

        public void UpdateInformation(AccountModel user)
        {
            FullNameLabel.Text = user.FullName;
            LoginLabel.Text = user.Login;
            PhoneNumberLabel.Text = user.PhoneNumber;
            EmailLabel.Text = user.Email;
            DateOfBirthLabel.Text = user.DateOfBirth.ToString("dd.MM.yyyy");
        }
        private void ClearInformation()
        {
            FullNameLabel.Text = "Нет данных";
            LoginLabel.Text = "Нет данных";
            PhoneNumberLabel.Text = "Нет данных";
            EmailLabel.Text = "Нет данных";
            DateOfBirthLabel.Text = "Нет данных";
        }

        private void TeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TeacherComboBox.SelectedIndex == -1)
            {
                ClearInformation();
                return;
            }
            UpdateInformation(ListOfAllUser[TeacherComboBox.SelectedIndex]);
        }

        private void EditAccountButton_Click(object sender, EventArgs e)
        {
            if (TeacherComboBox.SelectedIndex == -1)
            {
                return;
            }
            EditUserForm editUserForm = new EditUserForm(ListOfAllUser[TeacherComboBox.SelectedIndex]);
            if (editUserForm.ShowDialog() == DialogResult.OK)
            {
                ListOfAllUser[TeacherComboBox.SelectedIndex] = editUserForm.Account;
                UpdateInformation(ListOfAllUser[TeacherComboBox.SelectedIndex]);
                TeacherComboBox.Items[TeacherComboBox.SelectedIndex] = ListOfAllUser[TeacherComboBox.SelectedIndex].FullName;
            }
        }

        private void TeacherPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                ClearInformation();
                TeacherComboBox.SelectedIndex = -1;
            }
        }
    }
}
