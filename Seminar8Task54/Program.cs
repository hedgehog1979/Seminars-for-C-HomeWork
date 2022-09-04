// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" [ {array[i, j]} ] ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = new double[5, 5];
Console.WriteLine("Исходный массив");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 9);
        Console.Write($" [ {matrix[i, j]} ] ");

    }
    Console.WriteLine();
}

for (int a = 0; a < matrix.GetLength(0); a++)
{
    for (int b = 0; b < matrix.GetLength(1) - 1; b++)
    {
        for (int c = 0; c < matrix.GetLength(1) - 1; c++)
        {
            if (matrix[a, c] < matrix[a, c + 1])
            {
                double temp = 0;
                temp = matrix[a, c];
                matrix[a, c] = matrix[a, c + 1];
                matrix[a, c + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Отсортированный массив");
PrintArray(matrix);
