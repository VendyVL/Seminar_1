// Задача 7 - дополнительная: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine ("Введите трёхзначное число ");
int num = int.Parse(Console.ReadLine());
while (num > 9) 
{
    num = num-10;
}   

Console.WriteLine(num);