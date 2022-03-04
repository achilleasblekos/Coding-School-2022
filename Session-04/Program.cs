// See https://aka.ms/new-console-template for more information

//1

using Session_04;

string name = "achilleas blekos";
Class1 c1 = new Class1();

string reversedName = c1.ReverseString(name);
Console.WriteLine(reversedName);



//2

Class2 c2 =new Class2();
Console.Write("Give an integer : ");
string n =Console.ReadLine();
int i = Convert.ToInt32(n);

int getSum = c2.GetSum(i);
int getProduct = c2.GetProduct(i);
Console.WriteLine(getSum);
Console.WriteLine(getProduct);





//3

Class3 c3 = new Class3();
int x = c3.Finder(x);











//5

Class5 c5 = new Class5();
string[] ar;
int[] arr = c5.ArrSort(ar);





























Console.ReadLine();