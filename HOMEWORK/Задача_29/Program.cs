// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Заполнение массива производит пользователь.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int [] array = new int [8];

for (int i = 0; i <= 7; i++)
{
    Console.Write($"Введите массив для элемента " + "[" + (i) + "] ");
    array[i]= Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Вывод массива:");

for (int i = 0; i <= 7; i++)
{
    if (i < 7){
        Console.Write(array[i] + " , ");
    } else {
        Console.Write(array[i] + " . ");
    }
}
