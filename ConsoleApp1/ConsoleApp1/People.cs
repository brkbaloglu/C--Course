using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class People
    {
        //private int peopleId;
        //private string firstName;
        //private string lastName;
        //private string password;
        //private string email;
        //private DateTime birthDate;

        public People(int peopleId, string firstName, string lastName, string password, string email, DateTime birthDate)
        {
            this.peopleId = peopleId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
            this.birthDate = birthDate;
        }
        public People() { }

        //public int PeopleId { get => peopleId; set => peopleId = value; }
        //public string FirstName { get => firstName; set => firstName = value; }
        //public string LastName { get => lastName; set => lastName = value; }
        //public string Password { get => password; set => password = value; }
        //public string Email { get => email; set => email = value; }
        //public DateTime BirthDate { get => birthDate; set => birthDate = value; }

        //public string GetFullName()
        //{
        //    return this.firstName + " " + this.lastName;
        //}


        //public string getEmail(int peopleId)
        //{
        //    string result = string.Empty;

        //    if (peopleId > 0) 
        //    {
        //        result = this.email;
        //    }
        //    else
        //    {
        //        result = "E-mail is not found";
        //    }
        //    return result;
        //}



    }
}
