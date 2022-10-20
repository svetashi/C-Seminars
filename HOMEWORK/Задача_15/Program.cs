// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

int Mon = 1;
int Tue = 2;
int Wed = 3;
int Thu = 4;
int Fri = 5; 
int Sat = 6;
int Sun = 7;

if (day == Sat || day == Sun) 
{
    Console.WriteLine("Выходной!");
}
else if (day == Mon || day == Tue || day == Wed || day == Thu || day == Fri) 
{
   Console.WriteLine("Будний день");
}
