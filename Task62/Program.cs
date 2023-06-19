// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] array = new int[4, 4];
int firstNumber = 1;
for (int i = 0; i < 4; i++)
{
    array[i, 0] = firstNumber;
    firstNumber++;

    for (int j = 0; j < 4; j++)
    {
        array[0, j+1] = firstNumber;
        firstNumber++;
    }
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

PrintArray2d(array);