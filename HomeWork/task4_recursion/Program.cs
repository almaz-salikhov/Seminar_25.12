
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
void FillArraySpiral(int[,] arr, int row, int column)
{
    int N = 01;
    for (int i = 0; i < row; i++) // пока не дошел сначала строки до конца
    {
        for (int j = 0; j < column; j++)
        {
            while (arr[i, j] == 0)
            {
                arr[i, j] = N;
                N++;
            }
        }
    }
    for (int j = 0; j < column; j++) // пока не дошел от верхнего столбца к нижнему
    {
        for (int i = 0; i < row; i++)
        {
            while (arr[i, j] == 0)
            {
                arr[i, j] = N;
                N++;
            }
        }
    }
    for (int i = row - 1; i < 0; i--)
    {
        for (int j = column - 1; j < 0; j--)
        {
            while (arr[i, j] == 0)
            {
                arr[i, j] = N;
                N++;
            }
        }
    }
    for (int j = column - 1; j < 0; j--)
    {
        for (int i = row - 1; i < 0; i--)
        {
            while (arr[i, j] == 0)
            {
                arr[i, j] = N;
                N++;
            }
        }
    }
    while (arr.GetLength(0) >= 0 & arr.GetLength(1) >= 0)
    {
        FillArraySpiral(arr, arr.GetLength(0) - 1, arr.GetLength(1) - 1);
    }
}

int[,] arr = new int[4, 4];
int i = 0, j = 0; 
while (arr[i, j] == 0)
{
    FillArraySpiral(arr, arr.GetLength(0), arr.GetLength(1));
}

ShowArray(arr);

