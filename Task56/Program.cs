// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] array = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array [i, j] = new Random(). Next (1, 10);
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

int[] NewArray(int[,] array)
{
    int[] summ = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {       
            sum += array[i, j];
        }
        summ[i] = sum;       
    }
    return summ;
        
}

int[] newarray = NewArray(array);

void MinSumRow(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    Console.WriteLine("Строка, где наименьшая сумма чисел: " + (minIndex+1) + " строка");
}


NewArray(array);
PrintArray2d(array);
MinSumRow(newarray);
  

