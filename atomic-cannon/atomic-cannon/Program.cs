using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

//i chose to set velocity and angle to an int to make it easier to hit targets 
int velocity;
int angle;
double userDist;
double correctDist;
double radians;


//ascii title print
Console.WriteLine("   __   ____  _____  __  __  ____  ___     ___    __    _  _  _  _  _____  _  _ ");
Console.WriteLine("  /__\\ (_  _)(  _  )(  \\/  )(_  _)/ __)   / __)  /__\\  ( \\( )( \\( )(  _  )( \\( )");
Console.WriteLine(" /(__)\\  )(   )(_)(  )    (  _)(_( (__   ( (__  /(__)\\  )  (  )  (  )(_)(  )  ( ");
Console.WriteLine("(__)(__)(__) (_____)(_/\\/\\_)(____)\\___)   \\___)(__)(__)(_)\\_)(_)\\_)(_____)(_)\\_)");
Console.WriteLine();
Console.WriteLine();    
Console.WriteLine();
Console.WriteLine("You will have 5 shots to locate and destroy the building.");
Console.WriteLine("After each shot you will be told if your shot was farther or closer than the target.");
Console.WriteLine("Good luck! Press any key to start the game...");
Console.ReadKey();

Console.Clear();
Console.Write("What velocity would you like to use on your shot (1-100): ");
while (!int.TryParse(Console.ReadLine(), out velocity)|| velocity < 1 || velocity > 101 )
{
    Console.WriteLine("Enter a valid velocity between 1 and 100: ");
}
Console.WriteLine();
Console.Write("What angle would you like to use on your shot (in degrees): ");
while (!int.TryParse(Console.ReadLine(), out angle)|| angle < 1 || angle > 89)
{
    Console.WriteLine("Enter a valid angle between 1-89: ");
}


//converting degrees to radians for Math.Sin
radians = angle * Math.PI / 180.0;


//calculation 
userDist = (Math.Pow(velocity, 2) * Math.Sin(2 * radians)) / 9.81;

Console.WriteLine(Math.Round(userDist));







