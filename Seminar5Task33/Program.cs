// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for(int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(0,10);
}
Console.Write('[' + string.Join(" ", array) + ']');
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int j = 0;
for(int i = 0; i < array.Length; i++) 
{
    if(N == array[i]) j++;
}
if (j>0) Console.WriteLine ("да");
else  Console.WriteLine ("нет");