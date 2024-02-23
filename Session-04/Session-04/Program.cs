using Session_04;


// Question 1
var reversedString = new Class1();
string name = "Achilleas Blekos";

string reversedStringIter = reversedString.ReverseStringIteration(name);
string reversedStringLib = reversedString.ReverseStringLibrary(name);

Console.WriteLine($"The reversed of string '{name}' is");
Console.WriteLine("Using iterations: ");
Console.WriteLine(reversedStringIter);
Console.WriteLine("Using the library LINQ of .NET");
Console.WriteLine(reversedStringLib);
Console.Write("\n");


// Question 2
Console.Write("Please insert an integer: ");
string userInputQ2 = Console.ReadLine();
int numberQ2 = Convert.ToInt32(userInputQ2);
var mathComputations = new Class2();

int sum = mathComputations.GetSum(numberQ2);
int product = mathComputations.GetProduct(numberQ2);

Console.WriteLine($"The sum and product of numbers 1 to {numberQ2} are:");
Console.WriteLine(sum);
Console.WriteLine(product);
Console.Write("\n");


// Question 3
Console.Write("Please insert an integer: ");
string userInputQ3 = Console.ReadLine();
int numberQ3 = Convert.ToInt32(userInputQ3);
var primeNumbers = new Class3();

Console.WriteLine($"The prime numbers between 1 and {numberQ3} are:");
primeNumbers.GetPrimeNumbers(numberQ3);
Console.Write("\n");


// Question 4
int[] array1 = new int[] { 2, 4, 9, 12 };
int[] array2 = new int[] { 1, 3, 7, 10 };
var mathMultiplication = new Class4();

int[] multipliedArray = mathMultiplication.ArrayMultiplication(array1, array2);
Console.WriteLine($"The array with the multiplied elements of the two arrays is:");
for (int i = 0; i < multipliedArray.Length; i++)
{
    Console.Write($"{multipliedArray[i]} ");
}
Console.Write("\n");


// Question 5
int[] array = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
var sortArray = new Class5();

int[] myArray = sortArray.Sort(array);
Console.WriteLine("The sorted array is: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"{myArray[i]} ");
}
Console.Write("\n");