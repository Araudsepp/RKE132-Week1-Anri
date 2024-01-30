// See https://aka.ms/new-console-template for more information
//ralemdus küsib nime sisestamise
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //Output
//string - sõne
string userName = Console.ReadLine(); //Input
//Esimene voimalus
Console.WriteLine("Hello" + ", " + userName + "!"); //Output

//String interpolatsion 2 voimalus, dollar kohustuslik
Console.WriteLine($"Hello, {userName}!"); //Output

