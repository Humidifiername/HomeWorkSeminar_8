// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] array1 = new int[2, 3];
int[,] array2 = new int[3, 2];
int[,] resultArray = new int[2, 2];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 50);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void ProductArray(int[,] array1, int[,] array2, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < resultArray.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}

FillArray(array1);
FillArray(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
ProductArray(array1, array2, resultArray);
Console.WriteLine();
PrintArray(resultArray);