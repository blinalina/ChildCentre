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

namespace ChildCentre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show(Properties.Settings.Default.id.ToString());
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            bool res = false ;
            try
            {
                res = DBClient.Login("student", "student");
            }
            catch (WrongPasswordException ex)
            {

                MessageBox.Show("Неверный пароль!");
            }
            catch (UserNotFoundException ex)
            {
                MessageBox.Show("Такого пользователя не существует!");
            }

            if (res)
            {
                MessageBox.Show("Вход в систему!" );
            }
        }
    }
}
