// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Задайте целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 0) Console.WriteLine("0");
if (N == 1) Console.WriteLine("0 , 1");

else
{
    int i = 0;
    double first = 0;
    double second = 1;
    Console.Write($"{first}, {second}, ");
    while (i < N - 2)
    {
        double fib = first + second;
        Console.Write($"{fib}, ");
        first = second;
        second = fib;
        i++;
    }
}
