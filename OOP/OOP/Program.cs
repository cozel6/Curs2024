using OOP.Fly;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oop
            //4 principii OOP
            //Mostenire
            // ne permite sa avem clase copil , clase parinte , copilul mosteneste caractetristici din clasa parinte. (ce are )
            // atribute - field uri, prop
            //comportament - metode (ce face clasa)
            // clasa parinte , (base class)
            //child class (derived class)
            /* interfetele definesc un fel de operatiuni care trebuie interpretat
             *  este un cotract. tell what the class has to implement
             *  a Class implemenst an interface 
             * the class neesds ti provide an implementation for that member in the interface
             * Abstractizarea 
             * 
             * 
             * 
             */
            
            Beagle begle = new Beagle("Lola");
            begle.Bark();
            begle.DoTrick();
            begle.Eat();
            Dog dog = new Dog("Gugu");
            dog = begle;
            dog.Eat();
            dog.Bark();


            Bird bird = new Bird();
            bird.Fly();
            bird.Walk();


            Plane plane = new Plane();
            plane.Fly();

            IFlyable flyblaObject = new PaperAirplane();
            flyblaObject = bird;
            flyblaObject.Fly();


            var paperPlane = new PaperAirplane();

            AngryBirds angryBirds = new AngryBirds();

            IFlyable[] flayables = new IFlyable[] { bird , plane , angryBirds , paperPlane };
            for (int i = 0; i < flayables.Length; i++)
            {
                flayables[i].Fly();
            }

            //Abstractizare
            //incapsulare
            //polyforphism


        }
    }
}
