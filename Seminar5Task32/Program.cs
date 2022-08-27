// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for(int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(-9,10);
}
Console.Write('[' + string.Join(" ", array) + ']');
for(int j = 0; j < array.Length; j++)
{
    array[j] = array[j]*-1;
}
Console.Write('[' + string.Join(" ", array) + ']');