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

// for(int i=0; i<=array.Length; i++)
// {
//    array[i] = new Random().Next(0,2);
// }
// for (int i=0; i<=7; i++)
// {
//    Console.WriteLine(array[i] + " ,");
// }