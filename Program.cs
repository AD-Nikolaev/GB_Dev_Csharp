/*
Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] GetRandomArray(int length, int leftRange, int rigthRange)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Random.Shared.Next(leftRange, rigthRange);
        }

        return arr;
    }

void PrintArray(int[] array)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }

double RaiseAToPowB(int[] numbers)
{
    return Math.Pow(numbers[0], numbers[1]);
}

int GetSumDigits(int n)
{
    int result = 0;

    while (n > 0)
    {
        result += n % 10;
        n /= 10;
    }

    return result;
}



// <--------------------------------------------------------------------------------------------------------------->

/*
Console.Write("Введите 2 числа через пробел: ");
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine($"Число {numbers[0]} в степени {numbers[1]} = {RaiseAToPowB(numbers)}");
*/

/*
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {n} = {GetSumDigits(n)}");
*/

/*
int[] array = GetRandomArray(8, -10, 10);
Console.Write("Сгенирированный массив: ");
PrintArray(array);
*/