// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте размер массива: ");
double[] arr = new double [Convert.ToInt32(Console.ReadLine())];
for(int i = 0; i < arr.Length; i++) 
{
    // arr[i] = new Random().NextDouble();
    Console.WriteLine("Введите дробное число");
    arr[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine('[' + string.Join(" ], [ ", arr) + ']');

double min = arr[0];
double max = arr[0];
for (int j = 1; j < arr.Length; j++)
{
    if(min > arr[j]) 
    { 
        min = arr[j];
    }
        if(max < arr[j]) 
    { 
        max = arr[j];
    }
}
Console.WriteLine($"Diff =  {max} - {min} = {max - min}");