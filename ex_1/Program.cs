//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число ");
int numB = int.Parse(Console.ReadLine());
if (numA > numB) 
{
    Console.Write(numA);
    Console.Write(" больше чем ") ;
    Console.WriteLine(numB) ;
}
if (numA < numB) 
{
    Console.Write(numA);
    Console.Write(" меньше чем ") ;
    Console.WriteLine(numB) ;
}
if (numA == numB) 
{
    Console.Write(numA);
    Console.Write(" равно ") ;
    Console.WriteLine(numB) ;
}