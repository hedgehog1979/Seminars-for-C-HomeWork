// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Sequence(int m, int n, int sum)
{
    if (m > n)
    {
        Console.Write($"Сумма элементов= {sum} ");
        return;
    }
    sum = sum + (m++);
    Sequence(m, n, sum);
}

Console.WriteLine("Введите откуда считаем ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите до куда считаем ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < M) Console.WriteLine("Неверно задана последовательность");
else Sequence(M, N, 0);
