// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// // 45 -> 9

// void Count(string number)
// {
//     int sum = 0;
//     int[] array = new int[number.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = int.Parse(number[i].ToString());
//         sum = sum + array[i];
        
//     }
//     Console.WriteLine($"Сумма цифр в введенном числе составляет = {sum}");
//     return;
// }

// Console.WriteLine("Введите число");
// Count(Console.ReadLine());

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int fact(int N)
{
    if (N % 10 == 0) 
    {
        return 0;
    }
    fact (N/10);
    {
        return sum = sum + (N%10);
    }
}
Console.WriteLine(fact(n));