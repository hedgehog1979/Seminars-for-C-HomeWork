


void Sequence (int n)
{
    if (n == 0)
    {
        return;
    }
    Sequence(n-1);
    Console.Write($"{n} ");
}

Console.WriteLine("Введите целое число и мы покажем все числа от 1 до введенного числа");
int N = Convert.ToInt32(Console.ReadLine());
Sequence(N);