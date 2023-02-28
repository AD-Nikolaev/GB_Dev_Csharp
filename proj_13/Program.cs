// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int n = Math.Abs(int.Parse(Console.ReadLine()));

if (n > 99)
{
    int result = n;
    while (result > 999)
    {
        result /= 10;
    }

    Console.WriteLine($"Третья цифра: {result % 10}");
}
else
{
    Console.WriteLine("Число должно иметь 3 и более цифры.");
}
