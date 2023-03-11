// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool IsNumberPalindrome(int number)
{
    int result = 0;

    int tmpNumber = number;
    while (tmpNumber > 0)
    {
        result = result * 10 + tmpNumber % 10;
        tmpNumber /= 10;
    }

    if (result == number) return true;
    else return false;
}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistanceBetweenPoints(int[] point1, int[] point2)
{
    double result = Math.Sqrt(Math.Pow(point2[0] - point1[0], 2) + Math.Pow(point2[1] - point1[1], 2) + Math.Pow(point2[2] - point1[2], 2));
    return Math.Round(result, 2);
}

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void GetNumberCubes(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
    }
}

// <--------------------------------------------------------------------------------------------------------------------->

/*
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (IsNumberPalindrome(number))
{
    Console.Write("Введённое число - палиндром.");
}
else
{
    Console.Write("Введённое число - не палиндром.");
}
*/

/*
Console.Write("Введите через пробел координаты (x, y, z) для 1 точки: ");
int[] point1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.Write("Введите через пробел координаты (x, y, z) для 2 точки: ");
int[] point2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.Write($"Расстояние между указанными точками в пространстве: {GetDistanceBetweenPoints(point1, point2)}");
*/

/*
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
GetNumberCubes(number);
*/
