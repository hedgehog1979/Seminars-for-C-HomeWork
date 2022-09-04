// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// В условии опечатка - приведен результат для m == 3 и n == 2.

int Ackerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ackerman(m - 1, 1);
  else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.WriteLine("Введите аргумент М ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите аргумент N");
int N = Convert.ToInt32(Console.ReadLine());

int Function = Ackerman(M, N);

Console.Write($"Функция Аккермана = {Function} ");

