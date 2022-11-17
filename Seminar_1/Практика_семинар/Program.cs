// / семинар 2

// задача 14 из презентации
// Console.Write("enter A: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("enter B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a % b == 0)
// {Console.WriteLine("кратное красивое число");
// }
// else
// {
//     int ost = a % b;
//     Console.WriteLine($"Остаток от деления равен {ost}");
// }

// Console.WriteLine( "Введите номер четверти от 1 до 4: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string Range(int num)
// {
//     string a = "0";

//     if (num == 1)
//     {
//       a = "x > 0; y > 0";
//     }
//     if (num ==2)
//     {
//       a= "x < 0; y > 0;"; 
//     }
//     if (num ==3)
//     {
//     a= "x < 0; y < 0;"; 
//     }
//       if (num ==4)
//     {
//       a="x > 0; y < 0;";
//     }
//     return (a);
// }

// string pos = Range(num);
// Console.WriteLine(pos);

// double GetDinst(int x1, int y1, int x2, int y2)
// {
// double distance = 0;
// distance = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2));
// return distance;
// }
// Console.WriteLine( "Введите X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( "Введите Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( "Введите X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( "Введите Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double dist= GetDinst(x1,y1,x2,y2);
// Console.Write($"Distance : {dist}");

// СЕМИНАР 14.11.2022


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string GetConvert(int value)
{
    string result = null;

    while (value != 0)
    {
        result = Convert.ToString(value % 2) + result;
        value = value / 2;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetConvert(value));