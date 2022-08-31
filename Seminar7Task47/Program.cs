﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте двухмерный массив m * n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().NextDouble();
        matrix[i, j] = Math.Round(matrix[i, j] * 10, 2); // Костыль, т.к. в варианте Math.Round(rand.NextDouble() * 10, 2) утверждает, что rand не существует в контексте.
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
}
