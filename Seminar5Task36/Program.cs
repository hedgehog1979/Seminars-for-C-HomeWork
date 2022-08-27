// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[6];
for(int i = 0; i < arr.Length; i++) 
{
    arr[i] = new Random().Next(-99,100);
}
Console.WriteLine('[' + string.Join(" ], [ ", arr) + ']');

int sum = 0;
for(int j=1; j < arr.Length; j+=2)
{
        sum = sum + arr[j];
}
Console.WriteLine($"Сумма нечетных по индексу элементов массива составвляет   {sum}");
