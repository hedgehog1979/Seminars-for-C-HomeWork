// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int[,] matrix = new int[2, 4];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = new Random().Next(-9, 9);
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int b = 0; b < matrix.GetLength(1); b++)
{
    for (int a = 0; a < matrix.GetLength(0); a++)
    {
        Console.Write($"{matrix[a, b]}  ");
    }    
    Console.WriteLine();
}
