//Лекция по рекурсиям

// string[,] table = new string [2,5];
// String.Empty
//table[0,0] table [0,1]...
//table[1,0] [1,1]

// table[1,2]= "name";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows,colums]}-");
//     }
// }

//пример заполенения таблицы

// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// int [,] matrix = new int [3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


//Факториал и рекурсия

// double Fact(int n)
// {
//     if (n ==1) return 1;
//     else return n * Fact(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Fact(i)}");
// }


// FIBONACHI NUMBERS

// f(1) = 1
// f(2)= 1
// f(n)= f(n-1)+f(n-2)

// double Fib(int n)
// {
//     if (n==1 || n==2) return 1;
//     else return Fib(n-1) + Fib(n-2);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"f({i}) = {Fib(i)}");
// }


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());

// int [] fibo= new int [value];

// fibo[0] =0;
// fibo[1] =1;
// Console.Write($"{fibo[0]} ");
// Console.Write($"{fibo[1]} ");

// for (int i = 2; i < fibo.Length; i++)
// {
//     fibo[i] = fibo[i-1] + fibo[i-2];
//     Console.Write($"{fibo[i]} ");
// }
 
