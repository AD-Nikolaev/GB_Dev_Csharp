﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int n = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированное число: {n}");

int result = ((n / 10) % 10);
Console.WriteLine($"Вторая цифра: {result}");