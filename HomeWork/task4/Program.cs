int[,] arr = new int[4, 4];
// arr.GetLength(0) = 4;
// arr.GetLength(1) = 4;
// использовать while arr[i, j] == 0
void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int N = 0;
// 1) 
for (int i = 0,                                              // стоим на 0 строке 
    j = 0; j < arr.GetLength(1); j++)                        // идем по столбцам слева направо — 0, 1, 2, 3
{
    Console.Write((arr[i, j] = N) + " ");
    N++;
}
Console.WriteLine();
// 2) 
for (int j = arr.GetLength(1) - 1,                           // стоим на 3 столбце
    i = 1; i < arr.GetLength(0); i++)                        // спускаемся по строкам сверху вниз (0) — 1, 2, 3
{
    Console.Write((arr[i, j] = N) + " ");
    N++;
}
Console.WriteLine();

// 3) 
for (int i = arr.GetLength(0) - 1,                           // стоим на 3 строке 
    j = arr.GetLength(1) - 2; j >= 0; j--)                   // двигаемся по столбцам справа налево: (3) 2, 1, 0
{
    Console.Write((arr[i, j] = N) + " ");
    N++;
}
Console.WriteLine();

// 4) 
for (int j = 0,                                              // стоим на 0 столбце
    i = arr.GetLength(0) - 2; i > 0; i--)                    // поднимаемся по строкам снизу вверх: (3) 2, 1 (0)
{
    Console.Write((arr[i, j] = N) + " ");
    N++;
}
Console.WriteLine();

// 5)
for (int i = 1,                                              // стоим на 1 строке 
    j = 1; j < arr.GetLength(1) - 1; j++)                    // идем по столбцам слева направо: (0) 1, 2 (3)
{
    Console.Write((arr[i, j] = N) + " ");
    N++;
}
Console.WriteLine();

// 6) 
for (int j = arr.GetLength(1) - 2,                           // стоим на 2 столбце
    i = 2; i < arr.GetLength(0) - 1; i++)                    // спускаемся по строкам сверху вниз (0) (1) 2 (3)
{
    Console.Write((arr[i, j] = N) + " ");
    N++;
}
Console.WriteLine();

// 7) 
for (int i = 2,                                              // стоим на 2 строке 
    j = arr.GetLength(1) - 3; j >= 1; j--)                    // двигаемся по столбцам справа налево: (3) (2) 1, 0
{
    Console.Write((arr[i, j] = N) + " ");
    N++;
}
Console.WriteLine();

ShowArray(arr);

