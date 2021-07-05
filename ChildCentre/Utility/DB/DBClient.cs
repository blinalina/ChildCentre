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
      
        public static string[] AddLessonsFromDB()
        {
            var connection = Connect();
            string sql = "SELECT * FROM COURSES ";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            var IdFromDB = new List<int>();
            var LessonFromDB = new List<string>();

            using (var res = cmd.ExecuteReader())
            {
                while (res.Read())
                {
                    IdFromDB.Add(res.GetInt32(0));
                    LessonFromDB.Add(res.GetString(1));

                }
            }
            connection.Close();
            string[] listLessons = LessonFromDB.Select(n => n.ToString()).ToArray();
            return listLessons;
        }
      
        public static string[] AddTeachersFromDB(int idLesson)
        {
            var connection = Connect();
            string sql = "SELECT DISTINCT FULL_NAME FROM SCHEDULE sc, ACCOUNT ac WHERE ID_COURS = @idLesson AND ac.ID = ID_TEACHER";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("idLesson", idLesson);

            var TeacherFromDB = new List<string>();

            using (var res = cmd.ExecuteReader())
            {
                while (res.Read())
                {
                    TeacherFromDB.Add(res.GetString(0));
                }
            }
            connection.Close();
            string[] listTeachers = TeacherFromDB.Select(n => n.ToString()).ToArray();
            return listTeachers;
        }
      
        public static string[] AddDayAndTimeFromDB(int idLesson, string idTeacher)
        {
            var connection = Connect();
            string sql = "SELECT DAY_OF_THE_WEEK, START_TIME FROM SCHEDULE  WHERE ID_COURS = @idLesson AND (SELECT ID FROM ACCOUNT WHERE FULL_NAME = @idTeacher ) = ID_TEACHER";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("idLesson", idLesson);
            cmd.Parameters.AddWithValue("idTeacher", idTeacher);

            var DayFromDB = new List<string>();
            var TimeFromDB = new List<string>();

            using (var res = cmd.ExecuteReader())
            {
                while (res.Read())
                {
                    DayFromDB.Add(res.GetString(0));
                    TimeFromDB.Add(res.GetString(1));
                }
            }

            connection.Close();
            string[] listDay = DayFromDB.Select(n => n.ToString()).ToArray();
            string[] listTime = TimeFromDB.Select(n => n.ToString()).ToArray();
            string[] listDayAndTime = new string[listDay.Length];
            for(int i = 0; i < listDay.Length; i++)
            {
                listDayAndTime[i] += $"{listDay[i]} {listTime[i]}";
            }
            return listDayAndTime;
        }
      
        public static string[] SignUpStudent(string fullnameStudent, string fullnameTeacher, string idLesson,string nameDayTime )
        {
            if (fullnameStudent.Length == 0 )
            {
                throw new UserNotFoundException();
            }
            if (fullnameTeacher.Length == 0 || idLesson.Length == 0 || nameDayTime.Length == 0)
            {
                throw new FieldsEmptyException();
            }
            string[] nDAT = nameDayTime.Split();
            string nameDay = nDAT[0];
            string nameTime = nDAT[1];
            var connection = Connect();
            string sql = "SELECT ac.ID, sc.ID FROM ACCOUNT ac, SCHEDULE sc WHERE FULL_NAME = @fullnameStudent AND (SELECT ID FROM ACCOUNT WHERE FULL_NAME = @fullnameTeacher) = ID_TEACHER AND DAY_OF_THE_WEEK = @nameDay AND START_TIME = @nameTime AND ID_COURS = @idLesson";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("fullnameStudent", fullnameStudent);
            cmd.Parameters.AddWithValue("fullnameTeacher", fullnameTeacher);
            cmd.Parameters.AddWithValue("idLesson", idLesson);
            cmd.Parameters.AddWithValue("nameDay", nameDay);
            cmd.Parameters.AddWithValue("nameTime", nameTime);

            string IdStudentFromDB = "";
            string IdScheduleFromDB = "";

            using (var res = cmd.ExecuteReader())
            {
                while (res.Read())
                {
                    IdStudentFromDB = res.GetString(0);
                    IdScheduleFromDB = res.GetString(1);

                }
            }
            
            string[] id_St_Sc = new string[2];
            if (IdScheduleFromDB == "" && IdStudentFromDB == "")
            {
                throw new UserNotFoundException();
            }
            id_St_Sc[0] = IdStudentFromDB;
            id_St_Sc[1] = IdScheduleFromDB;

            string IdStudentFromDB1 = "";
            string IdScheduleFromDB1 = "";
            string sql1 = "SELECT * FROM SCHEDULE_STUDENTS WHERE ID_STUDENTS = @IdStudentFromDB AND ID_SCHEDULE = @IdScheduleFromDB";
            MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
            cmd1.Parameters.AddWithValue("IdStudentFromDB", IdStudentFromDB);
            cmd1.Parameters.AddWithValue("IdScheduleFromDB", IdScheduleFromDB);
           
            using (var res1 = cmd1.ExecuteReader())
            {
                while (res1.Read())
                {
                    IdStudentFromDB1 = res1.GetString(0);
                    IdScheduleFromDB1 = res1.GetString(1);

                }
            }
            if (IdScheduleFromDB == IdStudentFromDB1 && IdStudentFromDB == IdScheduleFromDB1)
            {
                throw new UserAlreadyExistsException();
            }
            connection.Close();
            return id_St_Sc;
        }
      
        public static bool SignUpStudent(string idStudent, string idSchedule)
        {
            if (idStudent.Length == 0)
                return false;
            if (idSchedule.Length == 0)
                return false;
              
            int OK;

            var connection = Connect();

            string sql1 = "INSERT INTO `SCHEDULE_STUDENTS` (`ID_STUDENTS`, `ID_SCHEDULE`) VALUES (@idStudent, @idSchedule);";
            MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
            cmd1.Parameters.AddWithValue("idStudent", idStudent);
            cmd1.Parameters.AddWithValue("idSchedule", idSchedule);
          
            if (cmd1.ExecuteNonQuery() != 1)
                OK = -1;
            else
                OK = 1;

            connection.Close();

            if (OK == -1)
            {
                throw new UserAlreadyExistsException();
            }

            return true;
        }
    }
  }