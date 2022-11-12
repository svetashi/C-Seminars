//10 for 99 

// int number = new Random().Next(10,100); //запомнить 
// int a1 = number / 10;
// int a2 = number % 10;

// if (a1 > a2) 
// {
//    Console.WriteLine($"наибольшая цифра : {a1}"); 
// }
// if (a2 < a1)
// {
//    Console.WriteLine($"наименьшая цифра : {a2}"); 
// }
// if (a1 ==a2)
// {
//    Console.WriteLine("равны :"); 
// }
// Console.WriteLine(number);
// Console.ReadKey(); 


// bool isPalindrome(int number)
// {
//   string strNumber = number.ToString();

//   if (strNumber[0] == strNumber[4] && strNumber[1] ==
//   strNumber[3])
//   {
//    return true;
//   }
// return false;
// }

// Console.WriteLine("Введите пятизначное число: ");
// int number= Convert.ToInt32(Console.ReadLine());

// if (number <= 9999 || number >= 100000)
// {
//    Console.WriteLine("Вы ввели неправильное число!");
//    return;
// }

// bool isPalindromevar = isPalindrome(number);
// Console.WriteLine(isPalindromevar);


// int GetSum(int number)
// {
//    int sum = 0;
//    /*int tempValue=1;
//    while (tempValue <= number)
//    {
//      sum = sum + tempValue;
//      tempValue = tempValue +1;
//    }*/

//    for(int i = 1; i <= number; i++)
//    {
//       sum= sum + i;
//    }

//    return sum;
// }

// Console.WriteLine("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sum= GetSum(number);
// Console.WriteLine(sum);

// int NumLengt(int number)
// {
//    string strNumber = Math.Abs(number).ToString();
//    int length = strNumber.Length;
//    return length;
// }
// Console.WriteLine("Enter number");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(NumLengt(number));

// int GetSFact(int number)
// {
//    int res=1;
// for(int i = 1; i <= number; i++)
//    {
//       res= res * i;
//       Console.WriteLine($"Результат итерации {i} равен {res}");
//    }
//    return res;
// }

// Console.WriteLine("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($" Result is: {GetSFact(number)}");


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

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//не доделана


int[] array1 = { 1, 2, 3, 4, 5 };
int[] array2 = new int[5];
int last = array1.Length - 1;

for (int i = 0; i <= last / 2; i++)
{
    array2[i] = array1[i] * array1[last - i];
    if (i == last / 2)
    {
        array2[i] = array1[i];
    }
    Console.Write($"{array2[i]}   ");
}