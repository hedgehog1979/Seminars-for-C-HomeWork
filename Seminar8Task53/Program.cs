// // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// int Reverse (matr[])

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

// for (int b = 0; b < 4; b++)
// {
//     for (int a = 0; a < 4; a++)
//     {
//          Console.Write($"{matrix[a, b]}  ");
// int temp = matrix[0, 0];
// matrix[0, 0] = temp;
// temp = matrix[0, 0];
for (int a = 0; a < matrix.GetLength(1); a++)
{
    matrix[0]
}
Console.WriteLine("Give 2 demension array M X N");
Console.Write("Enter M zise: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N zise: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

// Заполняем массив случайными значениями
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 101);
        Console.Write(" " + matrix[i, j] + " " + '\t');
     }
    Console.WriteLine();
}
Console.WriteLine();
int temp = 0;
for (int i = 0; i < m; i++)

{
    for (int j = 0; j < n; j++)
    {
        if (i==0)
        {
          temp = matrix[i,j];
          matrix[i, j] = matrix[i+matrix.GetLength(0)-1, j];
          matrix[i+matrix.GetLength(0)-1, j] = temp;
        }
       

        // matrix[i, j] = new Random().Next(1, 101);
        Console.Write(" " + matrix[i, j] + " " + '\t');
     }
    Console.WriteLine();
}


Console.WriteLine();



// int a = 0;
// int b = 0;
// int temp = matrix[a,b];
// for [int a = 0; a < matrix.GetLength(1)] 

// for (int a = 0; a < matrix.GetLength(1); a++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         matrix[i, j] = new Random().Next(-9,9);
//         Console.Write($"{matrix[i, j]}  ");
//     }
//     Console.WriteLine();
// }