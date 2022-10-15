// Задача 6
Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

if ((a % 2) ==0)
{    
Console.WriteLine($"Число {a} четное и делиться без остатка.");
}
else 
{
  Console.WriteLine($"Число {a} нечетное.");
}

