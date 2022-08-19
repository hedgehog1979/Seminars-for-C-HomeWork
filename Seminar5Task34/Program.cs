// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i]= rand.Next(min, max + 1);
    }
    return arr;
}
int[] arr = FillArray(5, 100, 1000);
Console.WriteLine('[' + string.Join(" ", arr) + ']');
int count = 0;
for(int j=0; j < arr.Length; j++)
{
        if (arr[j] % 2 == 0) count++;
}
Console.WriteLine($"Количество четных чисел в массиве = {count}");