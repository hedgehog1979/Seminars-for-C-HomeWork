﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] arr = new int[123];
for(int i = 0; i < arr.Length; i++) 
{
    arr[i] = new Random().Next(0,1000);
}
Console.WriteLine('[' + string.Join(" |  ", arr) + ']');

int count = 0;
for(int j=0; j < arr.Length; j++)
{
        if (arr[j] >= 10 && arr[j] <=99) count++;
}
Console.WriteLine($"Количество чисел в отрезке от 10 до 99 составвляет   {count}");