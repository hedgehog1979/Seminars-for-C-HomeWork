// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число и мы покажем Вам значения квадрата всех чисел до заданного- ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) Math.Abs(num);
int count = 1;
while (count < num)
{
    Console.WriteLine(Math.Pow(count, 2));
    count++;
}