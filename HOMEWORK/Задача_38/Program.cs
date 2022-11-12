// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


int GetMinMax(int[] array)
{
    int count = 0;
    int maximum = array[0];
    int minimum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    }
    count = maximum + minimum;
    return count;
}



int [] array = new int [5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,20);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Result: {GetMinMax(array)} ");
