// Задайте значение N
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// string NumbersFromNto1(int N)
// {
//     if (N == 1)
//     {
//         // Console.WriteLine("YES: " + N);
//         return "1";
//     }
//     else
//     {
//         // Console.WriteLine("NO: " + N);
//         return (N + ", ") + NumbersFromNto1(N - 1);
//     }
// }

string NumbersFromNto1(int N)
{
    return (N == 1 ? "1" : (N + ", ") + NumbersFromNto1(N - 1));
}

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("Натуральные числа от " + (num) + " до 1: " + (NumbersFromNto1(num)));
}
else
{
    Console.WriteLine("Введенное число не является натуральным");
}
