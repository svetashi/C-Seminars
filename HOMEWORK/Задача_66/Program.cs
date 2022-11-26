// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int count = 0;
int GetSum(int M, int N)
{
    if (M != N)
    {
        count = count + M;
        return GetSum(M + 1, N);
    }
    else
    {
        count = count + N;
        return count;
    }
}

int M = 1;
int N = 15;
int j = GetSum(M, N);
Console.WriteLine(j);