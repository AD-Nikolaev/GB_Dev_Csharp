/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями

y = k1 * x + b1,
y = k2 * x + b2;

y = 5x + 2
y = 9x + 4

x = (b2 - b1) / (k1 - k2)

значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void CountPositive (int m)
{
    Console.WriteLine($"Введите {m} чисел.");

    int counter = 0;
    int number = 0;
    for (int i = 0; i < m; i++)
    {
        number = int.Parse(Console.ReadLine());
        if (number > 0) counter++;
    }

    Console.WriteLine($"Чисел больше 0: {counter}");
}

void IntersectionPoint (double b1, double k1, double b2, double k2)
{
    double resultX = 0;
    double resultY = 0;
    resultX = Math.Round((b2 - b1) / (k1 - k2), 2);
    resultY = Math.Round(k1 * resultX + b1, 2);

    Console.WriteLine($"Точка пересечения заданных прямых: ({resultX}; {resultY})");
}

// <------------------------------------------------------------------------->

CountPositive(5);

Console.WriteLine("Введите коэффициенты для 2-х прямых:");
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);