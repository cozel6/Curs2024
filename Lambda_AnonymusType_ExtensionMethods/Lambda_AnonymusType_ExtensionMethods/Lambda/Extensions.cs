using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public static class Extensions
    {
        //just a static method
        public static int WordCount(string sentence)
        {
            int wordCount = sentence.Split(' ').Length;
            return wordCount;
        }
        //extension method
        public static int WordCountExtension(this string sentence)
        {
            int wordCount = sentence.Split(' ').Length;
            return wordCount;
        }
        public static bool GreaterThen(this int a , int b)
        {
            return a > b; // a.GreatherThen(b)
        }

        //public static List<Person> Filrer(this List<Person> persons, string country)
        //{
        //   var peopleInCountry = persons.Where(p => p.Country == country).ToList();
        //    return peopleInCountry;
        //}

        public static List<Person> Filter(this List<Person> persons , GroupType groupType, string value)
        {
            switch (groupType)
            {
                case GroupType.Country:
                    return persons.Where(p => p.Country == value).ToList();
                case GroupType.City:
                    return persons.Where(p => p.City == value).ToList();
                case GroupType.FirstName:
                    return persons.Where(p => p.FirstName == value).ToList();
                case GroupType.LastName:
                    return persons.Where(p => p.LastName == value).ToList();
                default:
                    return persons;
            }
        }
        //de completat restul de cod
        public enum GroupType
        {
            Country,
            City,
            FirstName,
            LastName
        }
    }
}
