using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    public class User
    {
        private string loging;
        private string firstName;
        private string lastName;
        private string age;
        private string DateTimeregistrationDate;

        public User(string login, string firsName, string lastName, string age)
        {
            this.loging = login;
            this.firstName = firsName;
            this.lastName = lastName;
            this.age = age;
            this.DateTimeregistrationDate = DateTimeregistrationDate;
        }
        public void DisplayUserInfo()
        {
            Console.WriteLine("Інформація про користувача:");
            Console.WriteLine("login");
            Console.WriteLine("firstName");
            Console.WriteLine("lastName");
            Console.WriteLine("age");
            Console.WriteLine(DateTimeregistrationDate);
        }

    }
   
}
