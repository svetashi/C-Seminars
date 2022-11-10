// // Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Для решения задания использование цикла for является обязательным условием. Не использовать встроенный метод возведения в степень.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число А: ");
int Anum = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число Б: ");
int Bnum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат возведения числа {Anum} в степень {Bnum} равен: {GetSF(Bnum)}");

int GetSF(int Bnum)
{
int temp=Anum;

for (int x = 1; x < Bnum; x++)
{
    temp =  temp * Anum; 
    Console.WriteLine($"Промежуточный результат: {temp}");
}
return temp;
}
