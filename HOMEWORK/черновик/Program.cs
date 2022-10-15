// Задача 6
/*Если остаток числа N после деления на 2 равен 0,
 то число четное, иначе не четное
*/


Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    if ((i % 2) == 0)
    {
        Console.Write(i + " ");
    }
}