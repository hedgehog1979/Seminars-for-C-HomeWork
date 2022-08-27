// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] Reverse(int[] n)
// {
//     int[] array = new int[n.Length];
//     int j = 0;
//     int temp = n[n.Length-1];
//     for (j = 0; j <= n.Length-1; j++)
//     {
//         array[j] = temp;
//         temp = n[n.Length - 1-j];
//         Console.Write(array[j] + " , ");
//     }
//     return array;
// }

Console.WriteLine("Задайте размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] matr = new int[N];
for (int i = 0; i < matr.Length; i++)
{
    matr[i] = new Random().Next(1, 10);
    Console.Write("[" + matr[i] + "]");
}
Console.WriteLine();
int[] array = new int[matr.Length];
    int temp = matr[matr.Length-1];
    for (int j = 0; j < matr.Length-1; j++)
    {
        array[j] = temp;
        temp = matr[matr.Length-2-j];
        Console.Write(array[j] + " , ");
    }
// Console.WriteLine();
// Console.Write(Reverse(matr));
