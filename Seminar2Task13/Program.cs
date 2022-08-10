// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число и мы покажем Вам третью по порядку цифру в нем!");
int num = Convert.ToInt32(Console.ReadLine());
string NumStr = Convert.ToString(num);
if (num >= 100 ^ num <= -100) 
{
    Console.WriteLine(NumStr[2]);
}
else 
{
    Console.WriteLine("Третьей цифры в числе не найдено");
}