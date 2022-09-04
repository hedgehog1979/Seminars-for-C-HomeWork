// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int m = Convert.ToInt32(Console.ReadLine());
int fact(int N, double M)
{
    if (M == 0 ) 
    {
        return 0;
    }
    fact (N/10);
    {
        return sum = sum + (N%10);
    }
}
Console.WriteLine(fact(n));