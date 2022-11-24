// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void GetFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
}

void ChangeArrayHighToLow(int[,] array)
{
    for (int k = 0; k < array.GetLength(1) - 1; k++)
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,8}", array[i, j] + " ");
        }
        Console.WriteLine();
    }

}




Console.WriteLine("Введите размер M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

GetFillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
ChangeArrayHighToLow(array);
Console.WriteLine();
PrintArray(array);