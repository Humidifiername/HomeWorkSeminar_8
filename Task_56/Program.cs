// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int[3, 4];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 50);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void MinSumRows(int[,] arr)
{
    int RowMin = 0;
    int RowMinSum = 0;
    int RowSum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        RowMin += array[0, i];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) RowSum += array[i, j];
        if (RowSum < RowMin)
        {
            RowMin = RowSum;
            RowMinSum = i;
        }
        RowSum = 0;
    }
    Console.Write($"{RowMinSum + 1} строка");
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
MinSumRows(array);