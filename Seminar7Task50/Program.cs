// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] matrix = new int [5,5];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j=0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-10, 10);
        // matrix[i,j] = i+j;
        Console.Write($"{matrix[i,j]} , ");
       
    }
    Console.WriteLine();
}
Console.WriteLine("Введите номер строки массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца массива");
int col = Convert.ToInt32(Console.ReadLine());
if (row <= matrix.GetLength(0) & row >= 0 &&  col <= matrix.GetLength(1) & col >= 0) 
{ 
    Console.WriteLine("Число массива");
    Console.WriteLine(matrix[row-1, col-1]);
}
else 
{
    Console.WriteLine("Такого числа в массиве нет");
}