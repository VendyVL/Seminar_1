// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Введите первое число ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число ");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите третье число ");
int numC = int.Parse(Console.ReadLine());
int max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;
Console.Write("Наибольшее число ") ;
Console.WriteLine(max) ;