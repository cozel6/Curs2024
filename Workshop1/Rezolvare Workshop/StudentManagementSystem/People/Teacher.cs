using StudentManagementSystem.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagementSystem.People
{
    public class Teacher : Person
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Teacher(string name, int age, string email, string phoneNumber)
            : base(name, age)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public override string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, Email: {Email}, Phone Number: {PhoneNumber}";
        }
    }
}

