﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());

int a = number / 10;
int b = number % 10;

int result = a % 10;
 Console.WriteLine($"Вторая цифра от {number} : {result}");