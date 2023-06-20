// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[, ,] GetArray3d()
{
    int m = Prompt("Введите значение m");
    int n = Prompt("Введите значение n");
    int k = Prompt("Введите значение k");
    int[, ,] array = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for(int l = 0; l < k; l++)
            {
                array[i, j, l] = new Random().Next(10, 101);
            }
        }
    }
    return array;
}

void PrintArray3d(int[, ,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for(int l = 0; l < array3d.GetLength(2); l++)
            {
                Console.Write(array3d[i, j, l] + $"({i},{j},{l})" + " ");
            }
        Console.WriteLine();
        }
    }
}



int[, ,] array3d = GetArray3d();
PrintArray3d(array3d);
Console.WriteLine();