namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beagle beagle = new Beagle();
            beagle.Bark();

            Dog dog = beagle;
            dog.Bark();


        }

        //Method overloading
        //semnatura metodei este diferita 

        public static int Sum(int x , int y)
        {
            return x + y;
        }
        public static double Sum(double x , double y)
        {
              return (double)x + y;
        }
        public static float Sum(float x, float y)
        {
            return (float)x + y;
        }
    }
}
