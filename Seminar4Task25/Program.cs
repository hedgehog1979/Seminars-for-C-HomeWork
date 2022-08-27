// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Использование Math.Pow и аналогов = незачёт

int Upscale(int arg1, int arg2)
{
    int result = arg1;
    for (int i = 1; i < arg2; i++)
    {
        result = result * arg1;
    }
    return result;
}
Console.WriteLine("Введите число-основание - ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число-экспоненту - ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат возведения в степень   " + Upscale(A, B));
