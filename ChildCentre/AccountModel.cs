using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildCentre
{
    public class AccountModel 
    {
        int ID { get; }
        string FullName { get; }
        string PhoneNumber { get; }
        string Email { get; }
        private AccountModel (int id, string fullName, string phoneNumber, string email)
        {
            ID = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
