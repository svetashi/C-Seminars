// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = 2;
int n = 3;
int result = 0;

int GetAkkerman(int m, int n)
{
    if (m == 0)
    {
        result = n + 1;
    }
    if (m != 0 && n == 0)
    {
        result = GetAkkerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        result = GetAkkerman(m - 1, GetAkkerman(m, n - 1));
    }
    return result;
}
GetAkkerman(m, n);
Console.WriteLine(result);
