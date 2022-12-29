// 3) посредством Метода и Return

bool Contains(int[,] arr, int elem) // Содержит ли массив нужный элемент 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == elem)
            {
                return true; // выйдет из метода, как только мы найдем то, что нужно
            }
        }
    }
    return false; // перебрали все элементы, но не нашли; выдаем -- false / не нашли 
}

int target = 0;
int[,] array = new int[,] { {1,2,3},
                            {1,0,9}};

Console.WriteLine(Contains(array, target));


