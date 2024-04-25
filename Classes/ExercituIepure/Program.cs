namespace ExercituIepure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iepurele myIepure = new Iepurele(EyeColor.Blue, FurColor.White, Gender.Male, new DateTime(2014, 10, 10));
            Iepurele myIepure2 = new Iepurele(EyeColor.Red, FurColor.Black, Gender.Female, new DateTime(2018, 5, 5));
            Iepurele myIepure3 = new Iepurele(EyeColor.Black, FurColor.Brown, Gender.Male, new DateTime(2004, 10, 30));

            Console.WriteLine($"Iepurele meu are varsta de {myIepure.Age()} si culoarea de {myIepure.EyeColor} acesta fiind de sex {myIepure.Gender}");
            Console.WriteLine($"Iepurele meu are varsta de {myIepure2.Age()} si culoarea de {myIepure2.EyeColor} acesta fiind de sex  {myIepure2.Gender}");
            Console.WriteLine($"Iepurele meu are varsta de {myIepure3.Age()} si culoarea de {myIepure3.EyeColor} acesta fiind de sex {myIepure3.Gender}");

        }
    }
}
