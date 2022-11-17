//Создание рандомного числа

// int number = new Random().Next(10,100);
// Console.WriteLine(number);

// // далее вывод сложения первого числа и последнего 

// int a1 = number / 10;
// Console.WriteLine(a1);

// int a2 = number % 10;
// Console.WriteLine(a2);

// int result = a1 + a2; 
// Console.WriteLine(result);



// Рандом в массиве

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



//    int [] array = new int [10];
//    for (int i = 0; i < 10; i++)
//    {
//       array[i] = new Random().Next(0,100);
//        Console.Write($"{array[i]}  "); // показывает все числа рандома
//    }

//  int FindCount(int[] array)
// {
//    int count=0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > 10 && array[i] < 99)
//    {
//       count++;
//    }
//    }
//    return count;
//    }
//       Console.WriteLine();
//       Console.WriteLine(FindCount(array)); //$"Чисел в диапазоне от 10 до 99 всего: " 