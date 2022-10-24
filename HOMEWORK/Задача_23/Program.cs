// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


int SquarNum(int Num)                 // метод
{
    int number = 0;
    number = Num * Num * Num;         // формула вычисления куба a3 = a · a · a
 
    if (Num - 1 > 0)                     // цикл для вывода кубов до введеной пользователем цифры
    {
        int others = SquarNum(Num-1);
        Console.WriteLine($"{others}");
    }
   return number;
}


Console.WriteLine("Чтобы вывести таблицу кубов от одного, до заданного числа N, введите значение N : ");
int Num = Convert.ToInt32(Console.ReadLine());

int result = SquarNum(Num);
Console.WriteLine($"Результат от введеного числа N: {result}");


