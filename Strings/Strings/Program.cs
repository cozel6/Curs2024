using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Text;


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

        #endregion


        #region Searching in strings

        int index = fullName.IndexOf("Io"); // pozitia 0
        index = fullName.IndexOf("Popescu"); // pozitia 6
        index = fullName.IndexOf("POPESCU"); // -1 not found
        index = fullName.IndexOf("o", 1); //pozitia 1
        index = fullName.IndexOf("o", 3); //pozitia 7
        Console.WriteLine(index);

        #endregion

        #region Extract
        // C:/Holiday/2025/1/nice_pic.png

        string path = "C:/Holiday/2025/1/nice_pic.png";

        //search dot in string
        int indexOfDot = path.IndexOf(".");
        int indexOfLastDot = path.IndexOf(".");  
        //take the file extension
        string extension = path.Substring(indexOfLastDot + 1);
        Console.WriteLine(extension);

        //extract the file name
        int lastIndexOfSlash = path.LastIndexOf("/");
        int substringLenght = indexOfDot - lastIndexOfSlash - 1;
        string fileName = path.Substring(lastIndexOfSlash + 1, substringLenght);
        Console.WriteLine($"{fileName}.{extension}");
        #endregion

        #region Compare Strings

        string str1 = "oradea";
        string str2 = "Oradea";

        int result = string.Compare(str1, str2, true); ;
        if ( result == 0)
        {
            Console.WriteLine("Are equals");
        }

        if ( str1 == str2)
        {
            //
        }

        if (str1.Equals(str2))
        {
            //
        }

        #endregion

        #region Split

        //Splt
        string listOfCity = "Londra, Paris, Oradea, Iasi, Cluj.";
        string[] cities = listOfCity.Split(',', '.', ' ');
        foreach (string city in cities)
        {
            if (!string.IsNullOrWhiteSpace(city))
            {
                Console.WriteLine(city.ToUpper()); // or .ToLower()
            }
        }

        //trim
        string mySpacedString = "                   this is a string      ";
        Console.WriteLine(mySpacedString.TrimStart()); //trim la inceput
        Console.WriteLine(mySpacedString.TrimEnd()); // trim la sfarsit
        Console.WriteLine(mySpacedString.Trim()); //tot sirul de string

        string myFunnyString = "+++++--------++++++++++- this is a string+++++++ +++++++-----------";
        Console.WriteLine(myFunnyString.Trim('+', '-'));
        Console.WriteLine(myFunnyString.Replace("+",""));

        // with classic concat
        /*var stopWatch = new Stopwatch();
        string myCoolString = "Counting bottle";

        stopWatch.Start();
        for (int i = 0; i < 10000;  i++)
        {
            myCoolString += i.ToString();
            Console.WriteLine(myCoolString);
            
        }
        stopWatch.Stop();
        Console.WriteLine(stopWatch.Elapsed.TotalSeconds.ToString()); //25.1997858
*/

        StringBuilder stringBuilder = new StringBuilder();


        /*var stopWatch2 = new Stopwatch();
        string myCoolString = "Counting bottle:";

        stopWatch2.Start();
        stringBuilder.Append(myCoolString);

        for (int i = 0; i < 10000; i++)
        {
            //myCoolString += i.ToString();
            stringBuilder.Append(i.ToString());
            //Console.WriteLine(i);
        }
*/
        //Console.WriteLine(stringBuilder.ToString()); // 0.0546481 sec 10.000 numere 
        //stopWatch2.Stop();
        //Console.WriteLine(stopWatch2.Elapsed.TotalSeconds.ToString()); //25.1997858 sec 10.000 numere 

        #region String.Format


        double d = 0.375;
        string infoToDisplay = d.ToString("P2");
        string myFormatString = string.Format("{0:F5}",d);

        Console.WriteLine(infoToDisplay);
        Console.WriteLine(myFormatString);

        //Date time
        DateTime myDate = DateTime.Now;
        Console.WriteLine(myDate);

        var myFormattedDate = string.Format("{0:d.MM.yyyy HH:mm}", myDate);
        Console.WriteLine(myFormattedDate);

        CultureInfo culture = new CultureInfo("ro-Ro");
        Console.WriteLine(myDate.ToString("d",culture));

        string myDate2 = "01.05.2024";
       //var tomorrow = myDate.AddDays(1);
        var tomorrow = myDate.AddDays(-1);

        DateTime futtureDate = DateTime.ParseExact(myDate2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        var yesterday = futtureDate.AddDays(-1);

        // string interpolation

        string student = "Jony";
        string age = "25";

        string str = $"student {student} is {age} years old";
        Console.WriteLine(str);

        string myStudent = "Jony is \"the best\""; // escaping caracter
        string myStudent2 = "Jony is 'the best'"; // using single quote
        string verbatimStudent = @"Jony is ""the best""";
        string spacedString = "This is my super long string" +
            "yea";
        string verbatimString = @"this
                                    is
                                    my 
                                    long
                                    string";
        Console.WriteLine("Enter your text using quote");
        Console.ReadLine();
        #endregion
        #endregion
        #endregion
    }
}
