// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());
// // string[] array = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x >0, y < 0"}

// switch (quarter)
// {
//     case 1:
//         Console.WriteLine("x > 0, y > 0");
//         break;
    
//     case 2:
//         Console.WriteLine("x < 0, y > 0");
//         break;
    
//     case 3:
//         Console.WriteLine("x < 0, y < 0");
//         break;
   
//     case 4:
//         Console.WriteLine("x > 0, y < 0");
//         break;
    
// }

Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string[] array = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x >0, y < 0"};
if (quarter >= 1 && quarter <= 4)
{
    Console.WriteLine(array[quarter-1]);
}
else 
{ 
    Console.WriteLine("Нет четверти с таким номером");
}