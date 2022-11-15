// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int GetPositive(int[] arr)                                               //функция
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}


Console.WriteLine("Введите через запятую числа : ");                      //ввод данных
string numbers = Console.ReadLine();

string[] array = numbers.Split(',');                                      //преобразовываем строку в массив
int[] arr = new int[array.Length];                                        //создаем новый пустой числовой массив и присваиваем ему длину массива , который ввел пользователь

for (int i = 0; i < array.Length; i++)
{
    arr[i] = Convert.ToInt32(array[i]);                                   //в созданный новый(пустой) массив кладем значения массива пользователя
    Console.Write(array[i] + " ");                                        //выводим массив на экран
}

Console.WriteLine();
Console.WriteLine($"Результат: {GetPositive(arr)}");                      //призыв и вывод функции