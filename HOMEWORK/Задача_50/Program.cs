// Задача 50. Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива и возвращать значение элемента,
//  стоящего в этой позиции. Если такой позиции в массиве нет, то сообщить об этом пользователю. 
// Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
// Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.

int sizeX = 5;
int sizeY = 6;
int[,] array = new int[sizeX, sizeY];

int[,] GetFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 50);
            // Console.Write("{0,8}" , array[i, j] + " ");   для вывода заполненного массива , для проверки
        }
        // Console.WriteLine();
    }
    return array;
}

void CheckPosition(int[,] array, int m, int n)
{
    if (m > sizeX || n > sizeY || m < 1 || n < 1)
    {
        Console.WriteLine("В массиве отсутствует элемент в такой позиции.");
    }
    else
    {
        Console.WriteLine($"Данный элемент присутствует на этой позиции. Равен = {array[m - 1, n - 1]}");
    }
}

Console.WriteLine("Введите желаемую первую (М) позицию для вывода числа: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите желаемую первую (N) позицию для вывода числа: ");
int n = Convert.ToInt32(Console.ReadLine());

GetFillArray(array);
CheckPosition(array, m, n);