// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void GetFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetMinSum(int[,] array)
{
    int min = int.MaxValue;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
       for (int j = 0; j < array.GetLength(1); j++) 
        {
            count = count + array[i, j];
        }
        if (count < min)
        { 
            min = count;
            minRow = i; 
        } 
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов:  {minRow+1} ");
}




Console.WriteLine("Введите размер M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер N: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m,n];

GetFillArray(array);
Console.WriteLine();
GetMinSum(array);
