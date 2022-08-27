// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Задайте количество чисел");
int M = Convert.ToInt32(Console.ReadLine());
int j = 0;
for (int i = 0; i < M; i++)
{
    Console.WriteLine("Введите целое число");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N > 0)
    {
       j++;
    }
}
Console.WriteLine($"Количество положительных чисел - {j}");

