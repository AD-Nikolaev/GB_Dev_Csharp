// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i = i + 2)
{
    Console.WriteLine(i);
}