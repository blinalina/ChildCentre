using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChildCentre.Utility.DB;


namespace ChildCentre
{
    public partial class ChangingPasswordForm : Form
    {
        public ChangingPasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            string OldPassword = OldPasswordTextBox.Text;
            string NewPassword = NewPasswordTextBox.Text;
            AccountModel user = DBClient.GetAccount(Properties.Settings.Default.id);
            int idUser = user.ID;
            bool res = false;
            try
            {
                res = DBClient.ChangingPassword(idUser, OldPassword, NewPassword);
                if (res)
                {
                    MessageBox.Show("Пароль успешно изменен");
                    OldPasswordTextBox.Clear();
                    NewPasswordTextBox.Clear();
                }
                else
                    MessageBox.Show("Пароль должен содержать больше 5 символов");
            }
            catch (WrongPasswordException)
            {
                MessageBox.Show("Старый пароль введен неправильно");
            }
            

        }

        private void ClearPasswordButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
