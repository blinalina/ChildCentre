using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ChildCentre.Utility.DB
{
    public class DBClient
    {
        /*static string connStr = "server=" + "db4free.net" +
            ";user=" + "admindubna" +
            ";database=" + "childcentre" +
            ";port=" + "3306" +
            ";password=" + "pnmyu2rVTRQF963" + ";SslMode=None;";*/
        static string connStr = "server=" + "remotemysql.com" +
            ";user=" + "UlFaq3Ih7N" +
            ";database=" + "UlFaq3Ih7N" +
            ";port=" + "3306" +
            ";password=" + "XcBiM1R2Ay" + ";convert zero datetime = True;";

        public static string GetPasswordByID(int id)
        {
            var connection = Connect();
            string sql = "SELECT PASSWORD FROM ACCOUNT WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("id", id);

            string password = "";
            using (var res = cmd.ExecuteReader())
            {
                while (res.Read())
                {
                    password = res.GetString(0);
                }
            }
            connection.Close();
            return password;
        }

        private static MySqlConnection Connect() 
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connStr;
            connection.Open();
            return connection;
        }
       
        public static bool Login(string login, string password)
        {
            login = login.Trim();
            password = password.Trim();
            if (login.Length == 0)
            {
                return false;
            }
            if (password.Length == 0)
            {
                return false;
            }

            //создаем соединение
            var connection = Connect();

            //создаем строку запроса, и можно указать параметры через @
            string sql = "SELECT ID, PASSWORD, ROLE_ID FROM ACCOUNT WHERE BINARY LOGIN = @login";
            
            //создание команды
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            //добавляем параметры 
            cmd.Parameters.AddWithValue("login", login);

            string passwordFromDB = "";
            int idFromDB = -1;

            // cmd.ExecuteReader для запроса с несколькими строками с толбцами
            //cmd.ExecuteNonQuery для insert, delete, update
            //cmd.ExecuteScalar одно значение
            using (var res = cmd.ExecuteReader())
            {
                while (res.Read())
                {
                    idFromDB = res.GetInt32(0);
                    passwordFromDB = res.GetString(1);
                    int role = res.GetInt32(2);


                    Properties.Settings.Default.id = idFromDB;
                    Properties.Settings.Default.role = role;
                    Properties.Settings.Default.Save();
                }
            }
            connection.Close();

            if (idFromDB == -1)
            {
                throw new UserNotFoundException();
            }
            if(password != passwordFromDB)
            {
                throw new WrongPasswordException();
            }
            return true;
        }

        public static List<AccountModel> GetAccounts(int role)
        {
            var connection = Connect();
            string sql = "SELECT ID, LOGIN, FULL_NAME, PHONE_NUMBER, EMAIL, DATE_OF_BIRTH FROM ACCOUNT WHERE ROLE_ID = @role";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("role", role);

            List<AccountModel> list = new List<AccountModel>();
            using (var res = cmd.ExecuteReader())
            {
                while (res.Read())
                {
                    AccountModel user = new AccountModel(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3), res.GetString(4), res.GetDateTime(5));
                    list.Add(user);
                }
            }
            connection.Close();
            return list;
        }

        public static List<ScheduleModel> GetCourses()
        {
            var connection = Connect();
            string sql = "SELECT ID, ID_COURS, (SELECT NAME FROM COURSES C WHERE C.ID = ID_COURS), ID_TEACHER, DAY_OF_THE_WEEK, START_TIME, END_TIME, CLASS FROM SCHEDULE";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            List<ScheduleModel> schedule = new List<ScheduleModel>();
            using (var res = cmd.ExecuteReader())
            {
                while (res.Read())
                {
                    ScheduleModel entry = new ScheduleModel(res.GetInt32(0), res.GetInt32(1), res.GetString(2), res.GetInt32(3), res.GetString(4), res.GetDateTime(5), res.GetDateTime(6), res.GetString(7));
                    schedule.Add(entry);
                }
            }
            connection.Close();
            return schedule;
        }

        public static void UpdateAccountUnformation(AccountModel account, string password)
        {
            var connection = Connect();
            string sql = "UPDATE ACCOUNT SET FULL_NAME = @fullname, DATE_OF_BIRTH = @date_of_birth, PHONE_NUMBER = @phone_number, EMAIL = @email, LOGIN = @login, PASSWORD = @password WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("fullname", account.FullName);
            cmd.Parameters.AddWithValue("date_of_birth", account.DateOfBirth);
            cmd.Parameters.AddWithValue("phone_number", account.PhoneNumber);
            cmd.Parameters.AddWithValue("email", account.Email);
            cmd.Parameters.AddWithValue("login", account.Login);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("id", account.ID);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
