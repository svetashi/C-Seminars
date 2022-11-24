// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] array1 = new int [2, 3];
int [,] array2 = new int [3, 2];
int[,] array3 =  new int[array1.GetLength(0), array2.GetLength(1)];

void GetFillArray1(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1 [i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write(array[i,j] + " ");  
        }
        Console.WriteLine();
    }
}

void MultiplicationArray(int [,] array1, int [,] array2, int[,] array3)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int n = 0; n < array2.GetLength(1); n++)
        {
            int count = 0;
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                count = count + (array1[i,j] * array2[j,n]);
            }
            array3[i, n] = count;
        }
    }
}

GetFillArray1(array1);
PrintArray(array1);
Console.WriteLine();
GetFillArray1(array2);
PrintArray(array2);
Console.WriteLine();
MultiplicationArray(array1, array2, array3);
PrintArray(array3);
Console.WriteLine();