// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Для решения задания использование цикла for является обязательным условием.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите любое число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 0) {
    Console.WriteLine("Неверный ввод. Введите натуральное число.");
} else {
    int result = 0;
    for(; userNumber>0;userNumber=userNumber/10)
    {
        result= result + userNumber % 10;
    }

    Console.WriteLine($"{result}");
}

