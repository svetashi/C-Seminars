// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void GetCross(double b1, double b2, double k1, double k2)
{
    double Xa = 0;
    double Ya = 0;
    Xa = (b2 - b1) / (k1 - k2);
    Ya = (k2 * Xa) + b2;

    Console.WriteLine($"Значенние пересечения первой координаты: {Xa}");
    Console.WriteLine($"Значенние пересечения второй координаты: {Ya}");
}


Console.WriteLine("Введите первое значение для длины b :");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение для длины b :");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое значение для длины k :");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение для длины k :");
int k2 = Convert.ToInt32(Console.ReadLine());

GetCross(b1, b2, k1, k2);