/* 
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N. 
5 -> 2, 4 
8 -> 2, 4, 6, 8 
*/ 


using System; 
using System.Collections.Generic; 
using System.Linq; 

class Program 
{ 
static void Main(string[] args) 
{ 

int n = 1; 
Console.Write("введите число: "); 
int m = int.Parse(Console.ReadLine()!); 
for (int i = n; i <= m; i++) 
{ 
if (i % 2 == 0) 
{ 
Console.Write(i + " "); 
} 
} 
Console.Write("четные числа: "); 
Console.ReadKey(); 
} 
}
