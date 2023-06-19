// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray()
{
    int m = Prompt("Введите значение m");
    int n = Prompt("Введите значение n");
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int[,] GetArray2()
{
    int k = Prompt("Введите значение k");
    int l = Prompt("Введите значение l");
    int[,] array = new int[k, l];
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < l; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
    
}

int[,] MatrixArray(int[,] array, int[,] array2)
{
    if(array.GetLength(1) != array2.GetLength(0))
        {
            Console.WriteLine("Произведение матриц невозможно");
        }

    int[,] matrix = new int[array.GetLength(0), array2.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < array.GetLength(1); k++)
            {
                sum += array[i, k] * array2[k, j];
            }
            matrix[i, j] = sum;
        }
    }
    return matrix;
}



void PrintArray2d(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray();
int[,] array2 = GetArray2();
PrintArray2d(array);
Console.WriteLine();
PrintArray2d(array2);
Console.WriteLine();
int[,] matrix = MatrixArray(array, array2);
PrintArray2d(matrix);

