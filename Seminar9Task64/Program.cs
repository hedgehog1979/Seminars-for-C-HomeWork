// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Sequence (int n, int m)
{
    if (m > n)
    {
        return;
    }
   
    Sequence(n, m+1);
    Console.Write($"{(m)} ,");
}

Console.WriteLine("Введите целое число и мы покажем все числа от него до 1");
int N = Convert.ToInt32(Console.ReadLine());
int M = 2;
Sequence(N,M);
Console.Write(" 1.");