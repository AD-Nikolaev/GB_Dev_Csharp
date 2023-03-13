/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] GetRandomArray(int length, int leftRange, int rightRange)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Random.Shared.Next(leftRange, rightRange);
        }

        return arr;
    }

double GetRandomNumber(double minimum, double maximum)
{
    Random random = new Random();
    return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 3);
}

double[] GetRandomDoubleArray(int length, int leftRange, int rightRange)
    {
        double[] arr = new double[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = GetRandomNumber(leftRange, rightRange);
        }

        return arr;
    }

void PrintArray(int[] array)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }

int GetCountEvenNumbers(int[] array)
{
    int counter = 0;

    foreach (int i in array)
    {
        if (i % 2 == 0) counter++;
    }

    return counter;
}

int GetSumOddPosNum(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

// <----------------------------------------------------------------------------------------------------------------------------->

/*
int[] array = GetRandomArray(10, 100, 1000);
Console.Write("Сгенирированный массив: ");
PrintArray(array);
Console.WriteLine($"Количество положительных чисел в массиве: {GetCountEvenNumbers(array)}");

Console.WriteLine($"Сумма элементов стоящих в массиве на нечётных позициях: {GetSumOddPosNum(array)}");
*/

double[] array = GetRandomDoubleArray(10, 1, 100);
Console.Write("Сгенирированный массив: ");
Console.WriteLine($"[{String.Join(", ", array)}]");

Console.WriteLine($"Минимальный элемент массива: {array.Max()}; Максимальный: {array.Min()}; Разница между ними: {array.Max() - array.Min()}");