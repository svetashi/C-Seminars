//ДЗ (задача номер 2)

Console.WriteLine("Введите число 1: ");
string first = Console.ReadLine();
Console.WriteLine("Введите число 2: ");
string second = Console.ReadLine();

int a = Convert.ToInt32(first);
int b = Convert.ToInt32(second);

if (a > b)
{
    Console.WriteLine($"Max : {a}");
    Console.WriteLine($"Min : {b}");
}
else if (a < b)
{
    Console.WriteLine($"Max : {b}");
    Console.WriteLine($"Min : {a}");
}
else {
    Console.WriteLine($"Число {a} равно {b}");
}