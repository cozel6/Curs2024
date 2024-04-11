/*
//declare variable
ctrl k + ctrl c  -- comments out the selection using //
ctrl + shift + / -- comments out the selection using * /
int x;
int y;

//assign values

x = 7;
y = x + 3;
Console.WriteLine(y);
*/

byte centuries = 12;    // Usually a small number
ushort years = 12345;
uint days = 123456789;
ulong hours = 123456789023456789; // May be a very big number
Console.WriteLine("{0} centuries is {1} years, or {2} days, or {3} hours.", centuries, years, days, hours);

float myfloat = 3.141592653589793238f;

//Console.WriteLine("Care este numele tau?");
//Console.WriteLine("Introdu prenumele: ");

//string prenume;
//prenume = Console.ReadLine();

//string nume;
//Console.Write("Introdu numele: ");
//nume = Console.ReadLine();

//Console.WriteLine("Buna, " + prenume + " " + nume);


//implicit conversion
int myintX = 5;
long mylongX = (long)myintX;


//conversie explicita
myintX = (int)mylongX;


var myNum = 5;

int? age =  null;

//Var type

var myObject = new object();
myObject = 5;


// compile time

int a = 2 + 3; //compile time
int v = (a + 3) * (v - 4) + (2* a + 7)/4; // runtime 