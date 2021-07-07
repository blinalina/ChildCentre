using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ChildCentre.Utility.DB;
using ChildCentre.Utility;
namespace ChildCentre
{
    public partial class AuthorizationForm : Form
    {        
        public AuthorizationForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.id != -1)
            {
                OpenMainApp();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            bool res = false;
            try
            {
                res = DBClient.Login(login, password);
            }
            catch (WrongPasswordException)
            {
                MessageBox.Show("Неверный пароль!");
            }
            catch (UserNotFoundException)
            {
                MessageBox.Show("Такого пользователя не существует!");
            }

            if (res)
            {
                OpenMainApp();
            }
        }

        private void OpenMainApp() {
            if (Properties.Settings.Default.role == (int)Role.ADMIN)
            {
                Visible = false;
                var AdminForm = new AdminForm();
                AdminForm.Closed += (s, args) => Close();
                AdminForm.Show();
            }
            else
            {
                Visible = false;
                var UserForm = new UserForm();
                UserForm.Closed += (s, args) => Close();
                UserForm.Show();
            }            
        }

        private void AuthorizationForm_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.id != -1)
            {
                Hide();
            }
        }
    }
}
