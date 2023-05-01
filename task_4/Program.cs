// Напишите программу, которая заполнит спирально квадратный массив.

int[,] Generate2DArray()
{
    int[,] array = new int[5, 5];
    return array;
}

int[,] GetFill(int[,] array)
{
    int begI = 0, endI = 0, begJ = 0, endJ = 0;
    int k = 1;
    int i = 0;
    int j = 0;
    while (k <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = k;
        if (i == begI && j < array.GetLength(1) - 1 - endJ)
        {
            j++;
        }
        else if (j == array.GetLength(1) - 1 - endJ && i < array.GetLength(0) - 1 - endI)
        {
            i++;
        }
        else if (i == array.GetLength(0) - 1 - endI && j > begJ)
        {
            j--;
        }
        else
        {
            i--;
        }
        if (i == begI + 1 && j == begJ && begJ != array.GetLength(1) - 1 - endJ)
        {
            begI++;
            endI++;
            begJ++;
            endJ++;
        }
        k++;
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


int[,] arr = Generate2DArray();
Print2DArray(GetFill(arr));
