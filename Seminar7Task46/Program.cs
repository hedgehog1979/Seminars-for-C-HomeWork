Console.WriteLine("Задайте двухмерный массив m * n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [m,n];

for (int i = 0; i < m; i++)
{
    for (int j=0; j < n; j++)
    {
        matrix[i,j] = new Random.Next();
        Console.WriteLine(matrix);
    }
}