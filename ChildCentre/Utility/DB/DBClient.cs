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
      
        public static bool ControlAddUserToDb(string login, string password, string role, string fullname, string birth, string number, string email)
        {
            login = login.Trim();
            password = password.Trim();
            role = role.Trim();
            fullname = fullname.Trim();
            birth = birth.Trim();
            number = number.Trim();
            email = email.Trim();
            if (login.Length == 0)
            {
                return false;
            }
            if (password.Length == 0)
            {
                return false;
            }
            if (role.Length == 0)
            {
                return false;
            }
            if (fullname.Length == 0)
            {
                return false;
            }
            if (birth.Length == 0)
            {
                return false;
            }
            if (number.Length == 0)
            {
                return false;
            }
            if (email.Length == 0)
            {
                return false;
            }

            var connection = Connect();
            string sql = "SELECT LOGIN, PASSWORD FROM ACCOUNT WHERE LOGIN = @login AND PASSWORD = @password ";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("login", login);
            cmd.Parameters.AddWithValue("password", password);

            string passwordFromDB = "";
            string loginFromDB = "";

            using (var res = cmd.ExecuteReader())
            {
                while (res.Read())
                {
                    loginFromDB = res.GetString(0);
                    passwordFromDB = res.GetString(1);

                }
            }
            connection.Close();
            if (login == loginFromDB && password == passwordFromDB)
            {
                throw new UserNotFoundException();
            }
            return true;

        }
      
        public static bool AddUserToDb(string login, string password, string role, string fullname, string birth, string number, string email)
        {
            login = login.Trim();
            password = password.Trim();
            role = role.Trim();
            fullname = fullname.Trim();
            birth = birth.Trim();
            number = number.Trim();
            email = email.Trim();
            int OK;

            var connection = Connect();

            string sql1 = "INSERT INTO `ACCOUNT` (`LOGIN`, `PASSWORD`, `ROLE_ID`, `FULL_NAME`, `DATE_OF_BIRTH`, `PHONE_NUMBER`, `EMAIL`) VALUES (@login, @password, @role, @fullname, @birth, @number, @email);";
            MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
            cmd1.Parameters.AddWithValue("login", login);
            cmd1.Parameters.AddWithValue("password", password);
            cmd1.Parameters.AddWithValue("role", role);
            cmd1.Parameters.AddWithValue("fullname", fullname);
            cmd1.Parameters.AddWithValue("birth",birth);
            cmd1.Parameters.AddWithValue("number", number);
            cmd1.Parameters.AddWithValue("email", email);
            if (cmd1.ExecuteNonQuery() != 1)
                OK = -1;
            else
                OK = 1;

            connection.Close();

            if (OK == -1)
            {
                throw new UserNotFoundException();
            }

             return true;

        }
        public static AccountModel GetAccount(int id)
        {
            AccountModel account= new AccountModel();

            var connection = Connect();
            string sql = "SELECT ID, LOGIN, FULL_NAME, PHONE_NUMBER, EMAIL, DATE_OF_BIRTH FROM ACCOUNT WHERE  ID = @id";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("id", id);

            using (var res = cmd.ExecuteReader())
            {
                while (res.Read())
                {
                    account = new AccountModel(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3), res.GetString(4), res.GetDateTime(5));
                }
            }
            connection.Close();
            return account;
        }
    
    }
  }