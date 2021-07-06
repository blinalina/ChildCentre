using ChildCentre.Utility.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildCentre
{
    public partial class EditUserForm : Form
    {
        public AccountModel Account;
        
        public EditUserForm(AccountModel accountModel)
        {
            InitializeComponent();
            Account = accountModel;
            InitUI();
        }

        private void InitUI()
        {
            FullnameTextBox.Text = Account.FullName;
            DateOfBirthTextBox.Text = Account.DateOfBirth.ToString("dd.MM.yyyy");
            PhoneNubmerTextBox.Text = Account.PhoneNumber;
            EmailTextBox.Text = Account.Email;
            LoginTextBox.Text = Account.Login;
            PasswordTextBox.Text = GetPasswordFromDB();
        }
        private string GetPasswordFromDB()
        {
            return DBClient.GetPasswordByID(Account.ID);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var val = ValidateInput(FullnameTextBox.Text, PhoneNubmerTextBox.Text, EmailTextBox.Text, LoginTextBox.Text, DateOfBirthTextBox.Text);
            if (val)
            {
                AccountModel updatedAccount = new AccountModel(Account.ID, LoginTextBox.Text, FullnameTextBox.Text, PhoneNubmerTextBox.Text, EmailTextBox.Text, DateTime.ParseExact(DateOfBirthTextBox.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture));
                DBClient.UpdateAccountUnformation(updatedAccount, PasswordTextBox.Text);
                Account = updatedAccount;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateInput(string fullname, string phone, string email, string login, string date)
        {
            try
            {
                DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            }
            catch (Exception e)
            {
                MessageBox.Show("Неверный формат даты");
                DateOfBirthTextBox.Text = Account.DateOfBirth.ToString("dd.MM.yyyy");
                return false;
            }
            if(fullname.Length == 0 || login.Length == 0)
            {
                MessageBox.Show("Логин и ФИО не могут быть пустыми");
                LoginTextBox.Text = Account.Login;
                FullnameTextBox.Text = Account.FullName;
                return false;
            }
            
            return true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
