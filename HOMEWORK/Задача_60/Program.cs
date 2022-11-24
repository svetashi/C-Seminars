// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int sizeX = 2;
int sizeY = 2;
int sizeZ = 2;
int[] existingElements = new int[sizeX*sizeY*sizeZ];
int[,,] Array = new int[sizeX, sizeY, sizeZ];

void FillArrayRandom(int[,,] Array)
{
    int existingIndex = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int n = 0; n < Array.GetLength(2); n++)
            {
                int number = new Random().Next(10, 100);
                while(existingElements.Contains(number)) 
                {
                    number = new Random().Next(10, 100);
                }
                Array[i, j, n] = number;
                existingElements[existingIndex] = number;
                existingIndex++;
            }
        }
    }
}

void PrintArray(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int n = 0; n < Array.GetLength(2); n++)
            {
                Console.Write($"{Array[i,j,n]}({i},{j},{n}) ");
            }
            Console.WriteLine();
        }
    }
}

FillArrayRandom(Array);
PrintArray(Array);