using ChildCentre.Utility.DB;
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
    public partial class AddUserPanel : UserControl
    {
        public AddUserPanel()
        {
            InitializeComponent();
        }

        private void AddUserToDbButton_Click(object sender, EventArgs e)
        {
            int[] passwordGenerator = new int[8];
            Random rnd = new Random();
            string getpassword = "";

            for(int i = 0; i < passwordGenerator.Length; i++)
            {
                passwordGenerator[i] = rnd.Next(65, 116);
                getpassword += (char)passwordGenerator[i];
            }
            PasswordTextBox1.Text = getpassword;

            string login = LoginTextBox1.Text;
            string password = PasswordTextBox1.Text;
            string role = RoleComboBox.Text;
            if (role == "Ученик")
                role = "1";
            if (role == "Учитель")
                role = "2";
            if (role == "Администратор")
                role = "0";
            string fullname = FullNameTextBox.Text;
            string birth = dateTimePicker1.Text;
            string number = NumberTextBox.Text;
            string email = EmailTextBox.Text;

            bool res = false;
            bool res1;
            try
            {
                res1 = DBClient.ControlAddUserToDb(login, password, role, fullname, birth, number, email);
                if(res1 == true)
                    res = DBClient.AddUserToDb(login, password, role, fullname, birth, number, email);
                else
                    MessageBox.Show("Не все поля заполнены");
            }
            catch (UserNotFoundException)
            {
                MessageBox.Show("Такой пользователь уже существует!");
            }
            if (res)
            {
                MessageBox.Show("Аккуант был создан");
                clean();
            }
            

        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            clean();
        }
        private void clean()
        {
            LoginTextBox1.Clear();
            PasswordTextBox1.Clear();
            FullNameTextBox.Clear();
            NumberTextBox.Clear();
            EmailTextBox.Clear();
        }

    }
}
