// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] array = new int[8];
// for(int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next();
//     Console.Write('[' + string.Join(" ", array[i]) + ']');
// }

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
Console.WriteLine(str);