// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int GetSum(int [] array)
{
    int count=0;
    for (int i = 1; i < array.Length; i=i+2)
    {
      count = count + array[i]; 
    }
    return count;
}

int [] array = new int [10];
for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(1,10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Result: {GetSum(array)}");