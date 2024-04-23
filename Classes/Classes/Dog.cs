using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //Enums
    public enum Breed
    {
        NotKnown, // 0
        Beagle, // 1
        Dalmatian, // 2 
        Pitbull,
        Hushy,
    }

    enum Level
    {
        Bigginer = 100,
        Inter = 200,
        Advenced = 300,
    }

    internal class Dog
    {
        


        //Constants

        public const string OWNER = "Gigi"; // compile time
        public readonly DateTime birthDate; // runtime



        //Atribute
        //Fileds - se scriu cu literele mici - keep state of the class
        private string name;
        private string breed;

        

        //Constructors
        public Dog() : this("Undefined","NotKnown")//Parameterless constructor
        {
           /* name = "Undefined";
            breed = "NotKnown";*/
           birthDate = DateTime.Now;
        }

        //Constructor With Parameter
        public Dog(string name , string breed)
        {
            this.name = name;
            this.breed = breed;
            
        }



        //Properties -
        /*public string Name
        {
            get;
            set;
            //Automatic propery
        }*/


        public string Name
        {
            //getter
            get 
            {
                return name;
            }
            //setter
            set 
            {
                name = value;
            }
        }
        public string Breed
        {
            get{return breed;}
            set {breed = value;}
        }

        public string OwnerName // readonly property
        {
            get { return OWNER + " " + Name;}
        }
        /*public long SecurityNumber
        {
            set { }
        }*/


        //Behavior methods
        public void Bark()
        {
            Console.WriteLine($"woof woof, I'm {name}");
        }



    }
}
