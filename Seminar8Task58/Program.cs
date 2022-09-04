// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Multiply(int[,] matr1, int[,] matr2, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                sum += matr1[i, k] * matr2[k, j];
            }
            result[i, j] = sum;
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" [  {array[i, j]}  ] ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте размерность квадаратной матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;

int[,] matrix = new int[m, n];
Console.WriteLine("Первая матрица:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 10);
        Console.Write($" [ {matrix[i, j]} ] ");

    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] array = new int[m, n];
Console.WriteLine("Вторая матрица:");
for (int a = 0; a < array.GetLength(0); a++)
{
    for (int b = 0; b < array.GetLength(1); b++)
    {
        array[a, b] = new Random().Next(-10, 10);
        Console.Write($" [ {array[a, b]} ] ");

    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] matr = new int[m, n];
Multiply(matrix, array, matr);
Console.WriteLine($"Результат умножения:");
WriteArray(matr);