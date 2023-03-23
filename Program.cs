/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double GetRandomNumber(double minimum, double maximum)
{
    Random random = new Random();
    return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 3);
}

double[,] GetRandomDoubleMatrix(int length_m, int length_n, int leftRange, int rightRange)
{
    double[,] arr = new double[length_m, length_n];
    for (int i = 0; i < length_m; i++)
    {
        for (int j = 0; j < length_n; j++)
        {
            arr[i, j] = GetRandomNumber(leftRange, rightRange);
        }
    }
    return arr;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine("]");
    }
}

string FindElMatrix(double[,] array, int row, int column)
{
    if (row > array.GetLength(0) || column > array.GetLength(1))
    {
        return "Указанного элемента нет в таблице.";
    }
    else
    {
        return $"Значение искомого элемента: {array[row, column]}";
    }
}

int[,] GetRandomTableArray(int length_m, int length_n, int leftRange, int rightRange)
{
    int[,] arr = new int[length_m, length_n];
    for (int i = 0; i < length_m; i++)
    {
        for (int j = 0; j < length_n; j++)
        {
            arr[i, j] = Random.Shared.Next(leftRange, rightRange);
        }
    }
    return arr;
}

void PrintTableArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine("]");
    }
}

void PrintAverageInColumn(int[,] array)
{
    string average = "";
    double tmpNum = 0;
    for (int column = 0; column < array.GetLength(1); column++)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            tmpNum += array[row, column];
        }
        average += $"{tmpNum / array.GetLength(0)}; ";
        tmpNum = 0;
    }
    System.Console.WriteLine($"Среднее арифметическое каждого столбца: {average}");
}

// <-------------------------------------------------------------------------->

/*
Console.Write("Введите количество строк (m) массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n) массива: ");
int n = int.Parse(Console.ReadLine());

double[,] array = GetRandomDoubleMatrix(m, n, -10, 10);
Console.WriteLine("Сгенирированный массив: ");
PrintMatrix(array);
System.Console.WriteLine();
*/

/*
Console.Write("Введите номер строки для поиска: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца для поиска: ");
int column = int.Parse(Console.ReadLine());

string find = FindElMatrix(array, row, column);
Console.WriteLine(find);
*/

Console.Write("Введите количество строк (m) массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n) массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = GetRandomTableArray(m, n, 0, 50);
Console.WriteLine("Сгенирированный массив: ");
PrintTableArray(array);
System.Console.WriteLine();

PrintAverageInColumn(array);