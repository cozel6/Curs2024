namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create an innstance of class dog
            Dog dog = new Dog();
            dog.Name = "Max";
            dog.Breed = "Bichon";
            //dog.SecurityNumber = 12345678;
            dog.Bark();
            // Dog.OWNER = "VASILE"; not possible
            // dog.OwnerName = "Vasile" not possbile . read only

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Breed);
            Console.WriteLine(Dog.OWNER);
            Console.WriteLine(dog.OwnerName);





            Dog beagle = new Dog("Spot", "Beagle");
            Console.WriteLine($"{beagle.Name} - {beagle.Breed}" );
            beagle.Bark();

            var maxi = new Dog();
            maxi.Bark();

            var myLevel = Level.Bigginer;

            if (myLevel == Level.Bigginer)
            {
                //
            }
            else if(myLevel == Level.Inter)
            {
                //
            }
            var whatLevel = (int) myLevel;
            Console.WriteLine(whatLevel);
            Console.WriteLine(Breed.NotKnown);
        }
    }
}
