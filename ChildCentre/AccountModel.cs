using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildCentre
{
    public class AccountModel 
    {
        public int ID { get; }
        public string FullName { get; }
        public string Login { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
        public DateTime DateOfBirth { get; }

        public AccountModel (int id, string login, string fullName, string phoneNumber, string email, DateTime date)
        {
            ID = id;
            Login = login;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            DateOfBirth = date;
        }
    }
}
