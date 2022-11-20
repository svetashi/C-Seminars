// Задача 52. Запросите от пользователя размерности двумерного массива.
//  Напишите метод для заполнения массива случайными числами. 
// Напишите метод для поиска ср. арифметического значения каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



void GetFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
            Console.Write("{0,8}", array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetAverageNumbers(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        float count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            count = count + array[i, j];
        }
        Console.WriteLine(Math.Round(count / array.GetLength(1), 2));
    }
}


Console.WriteLine("Введите размер M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
GetFillArray(array);
GetAverageNumbers(array);