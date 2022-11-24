// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int [,] array = new int [4,4];
int number= 1;

for (int delta = 0; delta < array.GetLength(0) - 2; delta++)
{
    for (int i = 0 + delta; i < array.GetLength(0) - delta; i++)
    {
        array[0 + delta, i] = number;
        number++;
    }
    number--;
    for (int i = 0 + delta; i < array.GetLength(0) - delta; i++)
    {
        array[i, array.GetLength(1)-1 - delta] = number;
        number++;
    }
    number--;
    for (int i = array.GetLength(0) - 1 - delta; i >= 0 + delta; i--)
    {
        array[array.GetLength(1)-1 - delta, i] = number;
        number++;
    }
    number--;
    for (int i = array.GetLength(0) - 1 - delta; i >= 1 + delta; i--)
    {
    array[i, 0 + delta] = number;
    number++;
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("{0,8}" , array[i,j]);
    }
    Console.WriteLine();
}

