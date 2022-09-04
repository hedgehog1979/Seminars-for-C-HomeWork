

void Sequence (int n, int m)
{
    if (n == m)
    {
        return;
    }
    Sequence(n-1, m);
    Console.Write($"{n} ");
}

Console.WriteLine("Введите откуда считаем ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите до куда считаем ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Последовательность:");
if (N < M) Console.WriteLine("Неверно задана последовательность");
else Sequence(N,M);