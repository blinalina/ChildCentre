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
            ";password=" + "XcBiM1R2Ay" + ";";

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
            string sql = "SELECT ID, FULLNAME, PHONENUMBER, EMAIL FROM ACCOUNT WHERE ROLE_ID = @role";
            MySqlCommand cmd = new MySqlCommand(sql, connection);


            connection.Close();
            throw new NotImplementedException();
        }
    }
}
