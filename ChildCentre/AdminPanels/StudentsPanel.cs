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
    public partial class StudentsPanel : UserControl
    {
        public StudentsPanel()
        {
            InitializeComponent();
        }
        List<AccountModel> ListOfAllUser = new List<AccountModel>();
        public void UpdateListOfUser(List<AccountModel> list)
        {
            ListOfAllUser = list;
            StudentsComboBox.Items.Clear();
            for (int i = 0; i < ListOfAllUser.Count; i++)
            {
                StudentsComboBox.Items.Add(ListOfAllUser[i].FullName);
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

        private void StudentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(StudentsComboBox.SelectedIndex == -1)
            {

                ClearInformation();
                return;
            }
            UpdateInformation(ListOfAllUser[StudentsComboBox.SelectedIndex]);
        }
    }
}
