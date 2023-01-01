//  Задайте значения M и N
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

int SumfromNtoM(int n, int m)
{
    if (n > m)
    {
        return (n == m ? n : n + SumfromNtoM(n - 1, m));
    }
    else
    {
        return (n == m ? m : m + SumfromNtoM(n, m - 1));
    }
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

if (N < 0 || M < 0)
{
    Console.WriteLine("Одно из чисел, либо оба — не натуральное");
}
else
{
    Console.WriteLine((M == N) ? "Числа совпадают" : SumfromNtoM(N, M));
}
