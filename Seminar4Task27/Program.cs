// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
long num = Convert.ToInt64(Console.ReadLine());
long sum = 0;
while (num > 0)
{
    long digit = num % 10;
    sum = sum + digit;
    num = num / 10;
}
Console.WriteLine($"Сумма цифр в введенном числе равна " + sum);