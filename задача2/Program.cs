/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введи первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
{

if (num1==num2)
Console.WriteLine($"{num1} равно {num2}");
else if(num2 > num1)
Console.WriteLine($"{num2} больше");
else
Console.WriteLine($"{num1} больше");
}