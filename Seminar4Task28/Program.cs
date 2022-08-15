// // Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число и мы покажем Вам значение произведения всех чисел до заданного- ");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// // if (num < 0) Math.Abs(num);
// for(int i = 1; i <= num; i++)
// {
//     num = i * num;
// }
// Console.WriteLine($"Произведение составит - {num}");
// // int count = 1;
// // while (count <= num)
// // {
// //     Console.WriteLine(Math.));
// //     count++;
// // }

Console.Write("Введите число N: ");

int number = Convert.ToInt32(Console.ReadLine());
int sum = number;
if(number >= 0)
{
for(int i = 1; i < number; i++)
{
    sum = i * sum;
}
Console.WriteLine(sum);
}
else 
{
   for(int i = -1; i > number; i--)
{
    sum = i * sum;
}
Console.WriteLine(sum); 
}

