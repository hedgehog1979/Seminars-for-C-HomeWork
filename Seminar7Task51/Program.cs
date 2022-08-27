// Задача 51:Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("Задайте двухмерный массив m * n");
// Console.WriteLine("Введите m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

int[,] matrix = new int [3,3];

for (int i = 0; i < 3; i++)
{
    for (int j=0; j < 3; j++)
    {
        matrix[i,j] = new Random().Next(-10, 10);
        Console.Write($"{matrix[i,j]}  ");
        Console.WriteLine();
    }
}
Console.WriteLine();
int N = matrix[0,0] + matrix[1,1]+matrix[2,2];
Console.WriteLine($"Сумма равна {N}");