﻿// Дополнительная задача (необязательная)
// Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо можете сами задавать массив чисел) и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
// {2, 3, 4} -> 2, 6, 24
// {5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1



Console.WriteLine("Пожалуйста, введите размер массива");
int size = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = new int[size];
int i = 0;
while (i < array.Length) 
    {
        Console.WriteLine("Введите число массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
var str = string.Join(" ", array);
Console.WriteLine("Числа массива -");
Console.WriteLine(str);
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (i = 0; i <= array.Length-1; i++)
{
        Console.WriteLine();
        int j = 1;
        for (j = 1; j <= N; j++)
        {
           Console.WriteLine("{0}", array[i] * j);         
        }
}
