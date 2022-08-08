// Задача 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(-999,999);
Console.WriteLine($"Наше случайное число: {number}");
if (number < 0) number = number*-1; 
int digit1 = number/100;
// Console.WriteLine(digit1);
int digit3 = number%10;
// Console.WriteLine(digit3);
int result = ((digit1*10)+digit3);
Console.WriteLine(result);
