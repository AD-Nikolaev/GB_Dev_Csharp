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



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

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
