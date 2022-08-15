// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число - ");
string num = Console.ReadLine();
Console.WriteLine($"Количество знаков в числе - {num.Length} ");

// Console.WriteLine("Введите число - ");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// string number = Convert.ToString(num);
// Console.WriteLine($"Количество знаков в числе - {number.Length} "); 


// Console.WriteLine("Введите число - ");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int count = 0;
// while (num>0)
// {
//     num = num / 10;
//     count++;
// }
// if (num == 0);
// {
//     count++;
// }
// Console.Write(count);