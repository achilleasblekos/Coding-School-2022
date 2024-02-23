// Question 1
Console.WriteLine("Hello Achilleas");
Console.WriteLine("\n");

// Question 2
int numberA = 25;
float numberB = 4.2f;

Console.WriteLine($"Let's add and divide numbers {numberA} and {numberB}");
Console.WriteLine($"Sum: {numberA + numberB}");
Console.WriteLine($"Division: {numberA / (float)numberB}");
Console.WriteLine("\n");

// Question 3
Console.WriteLine("Let's do some 'simple' calculus computations");
Console.WriteLine($"-1 + 5 * 6: {-1 + 5 * 6}");
Console.WriteLine($"38 + 5 % 7: {38 + 5 % 7}");
Console.WriteLine($"14 + ((-3 * 6) / 7): {14 + ((-3 * 6) / (float)7)}");
Console.WriteLine($"2 + (13 / 6) * 6 + (Square root of 7): {2 + (13 / (float)6) * 6 + Math.Sqrt(7)}");
Console.WriteLine($"(Power of 6 at 4) + (Power of 5 at 7) / 9 mod 4: {(Math.Pow(6, 4) + Math.Pow(5, 7)) / (float)(9 % 4)}");
Console.WriteLine("\n");

// Question 4
int age = 20;
string gender = "female";

Console.WriteLine($"You are {gender} and look younger than {age}.");
Console.WriteLine("\n");

// Question 5
int seconds = 45678;

Console.WriteLine("Calculating the number of minutes, hours, days, years");
Console.WriteLine("Dividing the total number with the appropriate number of seconds");
Console.WriteLine("The 45678 seconds are in:");
Console.WriteLine($"Minutes: {seconds / ((float)60)}");
Console.WriteLine($"Hours: {seconds / ((float)60 * 60)}");
Console.WriteLine($"Days: {seconds / ((float)60 * 60 * 24)}");
Console.WriteLine($"Years: {seconds / ((float)60 * 60 * 24 * 365)}");
Console.WriteLine("\n");


// Question 6
int timeInSeconds = 45678;
TimeSpan interval = TimeSpan.FromSeconds(timeInSeconds);

Console.WriteLine("With the use of .Net Library TimeSpan");
Console.WriteLine("The 45678 seconds are in:");
Console.WriteLine($"Minutes: {interval.TotalMinutes}");
Console.WriteLine($"Hours: {interval.TotalHours}");
Console.WriteLine($"Days: {interval.TotalDays}");
Console.WriteLine($"Years: {interval.TotalDays / (float)365}");
Console.WriteLine("\n");

// Question 7
float temperatureInCelsius = 23;

Console.WriteLine(
    $"The temperature in Kelvin is: {temperatureInCelsius + 273.15}."
    );
Console.WriteLine(
    $"The temperature in Fahrenheit is: {temperatureInCelsius * (9 / (float)5) + 32}."
    );