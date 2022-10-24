// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите любое пятизначное число: ");

string number = Console.ReadLine();
bool polindrom = false;

int number2 = Convert.ToInt32(number);
if (number2 < 10000 || number2 > 100000) {
    Console.WriteLine("Введенное число не пятизначное");
} else {
    for (int i = 0; i < number.Length; i++) {
        if (number[i] == number[number.Length - 1 - i]) {
            polindrom = true;
        } else {
            polindrom = false;
            break;
        }
    }
}
if (polindrom) {
    Console.WriteLine($"{number} число является полиндромом");
} else {
    Console.WriteLine($"{number} число НЕ является полиндромом");
}
