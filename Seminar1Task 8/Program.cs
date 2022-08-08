// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число от 2 и выше: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (N >= 1)
    Console.WriteLine("Четные числа менее введенного числа: ");
{
    while (count <= N)
    {
        Console.WriteLine(count);
        count = count + 2;
    }
}
