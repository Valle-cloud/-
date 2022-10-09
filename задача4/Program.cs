/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 
2, 3, 7 -> 7 
44 5 78 -> 78 
22 3 9 -> 22 
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введи второе число: ");
        int y = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введи третие число: ");
        int z = int.Parse(Console.ReadLine()!);
        int max = 0;

        if (x >= y && x >= z)
            max = x;
        else if (y >= x && y >= z)
            max = y;
        else if (z >= x && z >= y)
            max = z;

        Console.WriteLine("Максимальное число {0} ", max);
        Console.ReadLine();
    }
}