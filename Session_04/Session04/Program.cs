using Session04;

string Name = "Antonios Vasileiadis";
var c1 = new ex_1();
string revName = c1.Reverse(Name);

//1.
Console.WriteLine(revName);
//2.

int ex2Num = 6;

var c2 = new ex_2();

Console.WriteLine("Sum is " + c2.GetSum(ex2Num));
Console.WriteLine("Product is " + c2.GetProduct(ex2Num));

////3.

int ex3Num = 10;
var c3 = new ex_3();
Console.WriteLine("Prime numbers between 1 and  {0} are ", ex3Num);
c3.GetPrimeNumbers(ex3Num);

////4.

int[] Array1 = { 2, 4, 9, 12 };
int[] Array2 = { 1, 3, 7, 10 };

var c4 = new ex_4();

Console.WriteLine("New Array is: ");
c4.MultArrays(Array1, Array2);


////5.

int[] Array5 = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

var c5a = new ex_5();
var c5b = new ex_5();
//var c5c = new ex_5();
Console.WriteLine("ex 5  1st way: ");
c5a.revarrays_1(Array5);
//c5c.printArray(Array5); 

c5b.revarrays_2(Array5);




Console.ReadLine();