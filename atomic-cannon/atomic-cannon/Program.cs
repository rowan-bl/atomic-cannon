double velocity;
double angle;
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
Console.Write("What power level would you like to use on your shot (1-100): ");
velocity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("What angle would you like to use on your shot (in degrees): ");
angle = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

radians = angle * Math.PI / 180.0;
userDist = (Math.Pow(velocity, 2)*Math.Sin(2*radians))/ 9.81;
Console.WriteLine((int)Math.Round(userDist));





