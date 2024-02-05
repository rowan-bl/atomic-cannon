using System.Collections;
using System.Runtime.Versioning;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

//declaring variables
int velocity;
int angle;
double userDist;
int correctDist;
double radians;
int diffDist;
int i = 0;
//allow error of 5 metres in answer
int hitRadius = 5;

//declaring arrays
List<object> velocityList = new List<object> { "?", "?", "?", "?", "?" };
List<object> angleList = new List<object> { "?", "?", "?", "?", "?" };
List<object> diffList = new List<object> { "?", "?", "?", "?", "?" };

//ascii title print


Console.WriteLine("   __   ____  _____  __  __  ____  ___     ___    __    _  _  _  _  _____  _  _ ");
Console.WriteLine("  /__\\ (_  _)(  _  )(  \\/  )(_  _)/ __)   / __)  /__\\  ( \\( )( \\( )(  _  )( \\( )");
Console.WriteLine(" /(__)\\  )(   )(_)(  )    (  _)(_( (__   ( (__  /(__)\\  )  (  )  (  )(_)(  )  ( ");
Console.WriteLine("(__)(__)(__) (_____)(_/\\/\\_)(____)\\___)   \\___)(__)(__)(_)\\_)(_)\\_)(_____)(_)\\_)");
Console.WriteLine();
Console.WriteLine();    
Console.WriteLine();
Console.WriteLine("You will have 5 shots to locate and destroy the building.");
Console.WriteLine("After each shot you will be told given the distance away from the target");
Console.WriteLine("Good luck! Press any key to start the game...");
Console.ReadKey();


//create a array for possible target distances 
int[] values = [250, 500, 750, 1000];
Random rnd = new Random();
correctDist = values[rnd.Next(0, 4)];
do
{
    Console.Clear();
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"The target is {correctDist} metres out.");
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine($"Shot 1 | Power: {velocityList[0]} \t Angle: {angleList[0]} \t Distance from target: {diffList[0]}");
    Console.WriteLine($"Shot 2 | Power: {velocityList[1]} \t Angle: {angleList[1]} \t Distance from target: {diffList[1]}");
    Console.WriteLine($"Shot 3 | Power: {velocityList[2]} \t Angle: {angleList[2]} \t Distance from target: {diffList[2]}");
    Console.WriteLine($"Shot 4 | Power: {velocityList[3]} \t Angle: {angleList[3]} \t Distance from target: {diffList[3]}");
    Console.WriteLine($"Shot 5 | Power: {velocityList[4]} \t Angle: {angleList[4]} \t Distance from target: {diffList[4]}");
    Console.WriteLine();

    Console.Write("What velocity would you like to use on your shot (1-100 m/s): ");
    while (!int.TryParse(Console.ReadLine(), out velocity) || velocity < 1 || velocity > 101)
    {
        Console.Write("Enter a valid velocity between 1-100 m/s: ");
    }
    Console.WriteLine();
    Console.Write("What angle would you like to use on your shot (in degrees): ");
    while (!int.TryParse(Console.ReadLine(), out angle) || angle < 1 || angle > 89)
    {
        Console.Write("Enter a valid angle between 1-90 degrees: ");
    }

    //converting degrees to radians for Math.Sin
    radians = angle * Math.PI / 180.0;


    //calculation of users shot
    userDist = (Math.Pow(velocity, 2) * Math.Sin(2 * radians)) / 9.81;
    //calculation of difference in distance
    diffDist = Math.Abs(Convert.ToInt32(userDist) - correctDist);

    Console.WriteLine($"Your shot landed {diffDist} meteres away from the target.");
    Console.WriteLine();

    velocityList[i] = velocity;
    angleList[i] = angle;
    diffList[i] = diffDist; 

    if (diffDist <= hitRadius)
    {
        Console.WriteLine($"You have hit the target in {i + 1} shots!");
        Console.WriteLine();
        Console.WriteLine("Press any key to close the game...");
        Console.ReadLine();
        break;
    }

    Console.Write("Press any key to reload the cannon...");
    Console.ReadKey();

    i++;
}
while (i < 5);

