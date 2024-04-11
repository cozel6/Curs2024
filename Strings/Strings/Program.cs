using System.Security.Cryptography.X509Certificates;

public static class Program
{
    public static void Main(string[] args)
    {
        #region Strings

        // String = secvente de carctere / vector / 
        // String object contain immutable (read only) nu l mai poti modifica / reffrenece type

        #region Declare string

        string myFirstString = "Hello World";
        Console.WriteLine(myFirstString);

        int myNumber = 42;
        Console.WriteLine(myNumber);    

        string mynumberAsString = myNumber.ToString();
        #endregion




        #region manipulating strigs

        string firstName = "Ionel";
        string lastName = "Popescu";
        string fullName = firstName + " " + lastName;
        Console.WriteLine(fullName);
        string nameFullConcat = String.Concat(firstName," ",lastName);
        Console.WriteLine(nameFullConcat);
        Console.WriteLine($"{firstName} {lastName}");

        //interpolare

        #endregion










        #endregion
    }
}
