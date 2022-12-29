int target = 3;

// 1) через goto и метку HERE 
int[,] array = new int[,] { {1,2,3},
                            {1,0,9}};

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == target)
        {
            goto HERE; /// выйти из внешнего цикла FOR 
        }
    }
}
HERE:
Console.WriteLine();

// 2) посредством флаговым переменных
bool IsFound = false; // найден/не найден
int[,] array = new int[,] { {1,2,3},
                            {1,0,9}};

for (int i = 0; i < array.GetLength(0) && IsFound == false; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.WriteLine(array[i, j]);
        if (array[i, j] == target)
        {
            IsFound = true;
            break;
        }
    }
}
Console.WriteLine("нашли");

// 3) создание метода 

