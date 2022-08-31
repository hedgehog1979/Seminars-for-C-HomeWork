// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] matrix = new double [6,3];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j=0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-10, 10);
        Console.Write($" [ {matrix[i,j]} ] ");
        
    }
Console.WriteLine();
}
Console.WriteLine();

for (int col = 0; col < matrix.GetLength(1); col++)
{
    double sum = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)    
    {
        sum = sum + matrix[row, col];
    }
    // Console.WriteLine($"Сумма по столбцу {col+1} равно {sum}");
    Console.WriteLine($"Среднее по столбцу {col+1} равно {sum/matrix.GetLength(0)}");
}
// double N = ((matrix[0,0] + matrix[1,0]+matrix[2,0])/3);
// Console.WriteLine($"Среднее столбец 1 {N}");
// double M = (matrix[0,1] + matrix[1,1]+matrix[2,1])/3;
// Console.WriteLine($"Среднее столбец 2 {M}");
// double O = (matrix[0,2] + matrix[1,2]+matrix[2,2])/3;
// Console.WriteLine($"Среднее столбец 3 {O}");