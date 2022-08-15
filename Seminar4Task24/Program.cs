// На вход число А, выдает сумму чисел от 1 до А
// Напишите программу, которая принимает на вход число A и выдаёт сумму чисел от 1 до A.


// Console.WriteLine("Введите число и мы покажем Вам сумму всех чисел до заданного- ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i=1; i<num; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine($"Сумма всех чисел равна - {sum}");


int cycle (int a)
{
    int sum = 0;
    for (int i = 1; i<=a; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine("Введите число и мы покажем Вам сумму всех чисел до заданного- ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = cycle(num);
Console.WriteLine($"Сумма всех чисел равна - {sum}");
