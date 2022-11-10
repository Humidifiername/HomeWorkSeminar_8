// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[5, 6];

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

void ArrangeArray(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                        {
                            if (array[i, k] < array[i, k + 1])
                                {
                                    int temp = array[i, k + 1];
                                    array[i, k + 1] = array[i, k];
                                    array[i, k] = temp;
                                }
                        }
                }
        }
}

FillArray(array);
PrintArray(array);
ArrangeArray(array);
Console.WriteLine();
PrintArray(array);