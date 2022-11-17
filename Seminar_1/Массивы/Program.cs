//Задача 30 (синтаксис создания массива)
// int[] array; // создали массив аррай
// int[] array = new int[5] {1,3,4}; //массив из пяти элементов нулей

// array[0] = 5;
// array[3] = 5 + 2;
// array[1] = array[0] + array[3];

// Console.WriteLine(array);

// int[] array = new int [8];
// array[0] = 1;

// for(int i=0; i< array.Length; i++)
// {
//    array[i] = new Random().Next(0,2);
// }
// for (int i=0; i<=7; i++)
// {
//    Console.WriteLine(array[i] + " ,");
// }





// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] array = new int [12];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9,10);
//     Console.WriteLine(array[i] + "");
// }

// int sumPositive=0;
// int sumNegative=0;

// for (int i = 1; i < array.Length; i++)
// {
//    if (array[i] > 0)
//    {
//       sumPositive = sumPositive+array[i];
//    }
//    if (array[i] < 0)
//    {
//       sumNegative = sumNegative+array[i];
//    }
// }
// Console.WriteLine($"Sum positive = {sumPositive}, sun negative {sumNegative}");



//Задача 32: Напишите программу замена элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

//  int [] array = new int [10] {2,-5,6,9,-2,0,11,44,-66,3};

// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = array[i] * -1;
//    Console.WriteLine($"Результат работы:  {array[i]} ");
// }



// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное 
// число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// bool Search(int [] array, int value)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//    if(array[i] == value)
//  {
//    return true;
//  }
// }
// return false; 
// }

// int [] array = new int [4] {2,-5,6,9,};

// Console.WriteLine("Задайте число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Search(array,number));



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// int[] array1 = { 1, 2, 3, 4, 5 };
// int[] array2 = new int[5];
// int last = array1.Length - 1;

// for (int i = 0; i <= last / 2; i++)
// {
//     array2[i] = array1[i] * array1[last - i];
//     if (i == last / 2)
//     {
//         array2[i] = array1[i];
//     }
//     Console.Write($"{array2[i]}   ");
// }


// Задача 39: Напишите программу, которая перевернёт 
//одномерный массив (последний элемент будет на первом 
//месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int [] array = new int [11] {1,2,3,4,5,6,7,8,9,10,11};


// for (int i = 0; i < array.Length/2; i++)
// {
//     int temp = array[i];
//     array [i]= array[(array.Length-1)-i];
//     array[(array.Length-1)-i] = temp;
//     }
//     Console.ReadLine();

// Задача 40: Напишите программу, которая принимает 
// на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

// bool GetTri(int[] sides)
// {
// if (sides[0]+sides[1] > sides[2] && sides[1]+sides[2] > sides[0] && sides[0]+sides[2] > sides[1]) 
// {
//     return true;
// }
//  return false;
// }

// int [] value = new int [3];

// Console.WriteLine("Введите длину стороны 1: ");
// value[0] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину стороны 2: ");
// value[1] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину стороны 3: ");
// value[2] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(GetTri(value));

