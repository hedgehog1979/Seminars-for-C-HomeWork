// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число и мы покажем Вам значения куба всех чисел до заданного- ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) Math.Abs(num);
int count = 1;
while (count <= num)
{
    Console.WriteLine(Math.Pow(count, 3));
    count++;
}