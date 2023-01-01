//  Задайте значения M и N
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// сначала выясняю, какое число больше
// после этого завожу в функцию SumOfNumbersfromNtoM
// чтобы не разветвлять ее внутри

int SumOfNumbersfromNtoM(int max, int min)
{
    return (max == min ? max : max + SumOfNumbersfromNtoM(max - 1, min));
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
    int max = N; int min = M;
    if (N < M)
    {
        max = M;
        min = N;
    }
    Console.WriteLine((M == N) ? "Числа совпадают" : SumOfNumbersfromNtoM(max, min));
}
