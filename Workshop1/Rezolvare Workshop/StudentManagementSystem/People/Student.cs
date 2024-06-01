using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.People
{
    public class Student : Person
    {
        public int Grade {  get; set; }
        public string Address { get; set; }

        public Student(string name, int age, int grade, string address) : base(name, age)
        {
            this.Grade = grade;
            this.Address = address;
        }
        public override string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, Grade: {Grade}, Address: {Address}";
        }
    }
}
