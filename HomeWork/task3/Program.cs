// Программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int Akk(int m, int n)
{
    int res = 0;
    if (m == 0)
    {
        res = n + 1;
    }
    if (m > 0 & n == 0)
    {
        res = Akk(m - 1, 1);
    }
    if (m > 0 & n > 0)
    {
        res = Akk(m - 1, Akk(m, n - 1));
    }
    return res;
}

Console.WriteLine (n < 0 || m < 0 ? "Одно из чисел, либо оба — отрицательные" : Akk(m, n));