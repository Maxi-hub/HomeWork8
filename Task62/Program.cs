// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] SpiralArray()
{
    int[,] array = new int[4, 4];
    int firstNumber = 1;
    int row = 0; 
    int col = 0; 
    int direction = 0; 
    for (int i = 0; i < 16; i++)
    {
    array[row, col] = firstNumber++;
    switch (direction)
        {
            case 0: 
            if (col == 3 || array[row, col + 1] != 0)
            {
                direction = 1; 
                row++;
            }
            else
            {
                col++;
            }
            break;
                
            case 1: 
            if (row == 3 || array[row + 1, col] != 0)
            {
                direction = 2; 
                col--;
            }
            else
            {
                row++;
            }
            break;

            case 2: 
            if (col == 0 || array[row, col-1] != 0)
            {
                direction = 3; 
                row--;
            }
            else
            {
                col--;
            }
            break;

            case 3: 
            if (row == 0 || array[row-1, col] != 0)
            {
                direction = 0; 
                col++;
            }
            else
            {
                row--;
            }
            break;
        }
    }
    return array;
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


int[,] array = SpiralArray();
PrintArray2d(array);


