// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число:");
string number = Console.ReadLine();

if (MathF.Abs(Convert.ToInt32(number)) < 100)
{
    Console.WriteLine("Третьей цифры нет");
} else {
    Console.WriteLine(Convert.ToString(MathF.Abs(Convert.ToInt32(number)))[2]);
}

// альтернативное математическое  решение , но не для всех чисел

// else if (number < 1000) // 10^n
// {
//     int x = number % 10; // 10^n-2
//     Console.WriteLine($"Третье число: {x}");
// }
// else if (number < 10000)
// {
//     int x = number % 100 / 10;
//     Console.WriteLine($"Третье число: {x}");
// }
// else if (number < 100000)
// {
//     int x = (number % 1000) / 100;
//     Console.WriteLine($"Третье число: {x}");
// }
//  и так далее до 100000000000......слишком длинное решение