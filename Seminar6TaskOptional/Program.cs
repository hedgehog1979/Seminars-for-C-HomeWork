// Дополнительная задача на рекурсию
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120

double Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}

Console.WriteLine("Введите целое число и мы посчитаем произведение всеч числе от 1 до введенного числа");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение равно - {Factorial(N)}");