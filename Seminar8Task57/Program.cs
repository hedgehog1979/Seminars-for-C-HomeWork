// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[,] matrix = new int[3, 3];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 5);
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
}
for (int a = 0; a < matrix.GetLength(0); a++)
{
    int temp = matrix[0, 0];
    int count = 0;
    int sum = 0;
    for (int b = 0; b < matrix.GetLength(1); b++)
    {
        
        temp = matrix[a, b];
        if (matrix[a, b] == temp) sum = sum+count;
        count++;
        Console.WriteLine($"{temp} встречается {sum} раз");
    }

}

Console.WriteLine();

