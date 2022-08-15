// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число и мы посмотрим, является ли оно палиндромом");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
if (num >= 10000 & num <= 99999) 
{
    string number = num.ToString();
    for (int i = 1; i < number.Length/2; i++)
    {
        if(number[i] != number[number.Length - 1 -i]) Console.WriteLine("Не палиндром");
        else Console.WriteLine("Палиндром!");
        break;
    }  
}
else 
{
    Console.WriteLine("Пожалуйста, введите число из пяти цифр");
}