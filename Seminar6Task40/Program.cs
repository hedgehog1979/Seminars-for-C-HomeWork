// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.WriteLine("Введите длину первой стороны треугольника");
double ac = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны треугольника");
double ab = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны треугольника");
double bc = Convert.ToDouble(Console.ReadLine());

if (ac < ab+bc || bc < ab+ac || ab < ac+bc) Console.WriteLine("возможно");
else Console.WriteLine ("невозможно");