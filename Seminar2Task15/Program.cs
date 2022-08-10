// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели, чтобы понять, случился ли выходной: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("суровые будни");
        break;
    
    case 2:
        Console.WriteLine("суровые будни");
        break;
    
    case 3:
        Console.WriteLine("на полпути");
        break;
   
    case 4:
        Console.WriteLine("суровые будни");
        break;
    
    case 5:
        Console.WriteLine("TGIF");
        break;
   
    case 6:
        Console.WriteLine("Выходной");
        break;
   
    case 7:
        Console.WriteLine("Выходной");
        break;
   
    default:
        Console.WriteLine("Введите существующий номер дня недели");
        break;
}