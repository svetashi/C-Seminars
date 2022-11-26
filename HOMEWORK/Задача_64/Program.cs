// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int ShowNumbers(int number)
{
    if (number == 1)
    {
        return 1;
    }
        Console.WriteLine(number);
        return ShowNumbers(number - 1);
}

int number = 8;
int j = ShowNumbers(number);
Console.WriteLine(j);                                              


