// Задайте двумерный массив. Напишите программу, 
// которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int cntRows, int cntColumns, int minLimit, int maxLimit)
{
    int[,] array = new int[cntRows, cntColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minLimit, maxLimit + 1);
        }
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

void ChangeRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPositionJ = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPositionJ]) maxPositionJ = k;
            }
            int temporary = array[i, j];
            array[i, j] = array[i, maxPositionJ];
            array[i, maxPositionJ] = temporary;
        }
    }
}


int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");
int minLimit = ReadInt("Минимальное случайное значение");
int maxLimit = ReadInt("Максимальное случайное значение");
int[,] arr = Generate2DArray(rows, columns, minLimit, maxLimit);
Print2DArray(arr);
System.Console.WriteLine();
ChangeRow(arr);
Print2DArray(arr);