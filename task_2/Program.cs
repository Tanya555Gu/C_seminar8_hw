// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] SumRow(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        result[i] = sum;
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine($"Сумма элементов на {i + 1} строке равна {array[i]}\t");
    }
}

int FindMin(int[] array)
{
    int min = array[0];
    int iMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            iMin = i;
        }
    }
    return iMin + 1;
}


int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");
int minLimit = ReadInt("Минимальное случайное значение");
int maxLimit = ReadInt("Максимальное случайное значение");
int[,] arr = Generate2DArray(rows, columns, minLimit, maxLimit);
Print2DArray(arr);
PrintArray(SumRow(arr));
System.Console.WriteLine(FindMin(SumRow(arr)));
// System.Console.WriteLine($"Наименьшая сумма элементов в строке {FindMin(SumRow(arr))}");
