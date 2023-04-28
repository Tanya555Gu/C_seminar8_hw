// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
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

bool Validate(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        return true;
    }
    else return false;
}

int[,] MultArray(int[,] array1, int[,] array2, bool Validate = true)
{
    int[,] multAr = new int[array1.GetLength(0), array2.GetLength(1)];
    if (!Validate)
    {
        System.Console.WriteLine();
    }
    else
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                int sum = 0;
                for (int m = 0; m < array1.GetLength(1); m++)
                {
                    sum = sum + array1[i, m] * array2[m, j];
                }
                multAr[i, j] = sum;
            }
        }
    }
    return multAr;
}


int rows1 = ReadInt("Введите количество строк для 1-ой матрицы");
int columns1 = ReadInt("Введите количество столбцов для 1-ой матрицы");
int rows2 = ReadInt("Введите количество строк для 2-ой матрицы");
int columns2 = ReadInt("Введите количество столбцов для 2-ой матрицы");
int[,] arr = Generate2DArray(rows1, columns1);
int[,] arr2 = Generate2DArray(rows2, columns2);
Print2DArray(arr);
System.Console.WriteLine();
Print2DArray(arr2);
System.Console.WriteLine();
int[,] mult = MultArray(arr, arr2, Validate(arr, arr2));
if (!Validate(arr, arr2))
{
    System.Console.WriteLine("Данные матрицы невозможно перемножить");
}
else
{
    Print2DArray(mult);
}