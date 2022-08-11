// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,2

// Console.WriteLine("Введите точку x1: ");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите точку Y1: ");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите точку x2: ");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите точку Y2: ");
// double y2 = Convert.ToInt32(Console.ReadLine());

// double Length = Math.Sqrt(Math.Pow(x2-x1, 2) +Math.Pow(y2-y1, 2));
// Console.WriteLine(Length);

double[] A = new double[2];
double[] B = new double[2];
Console.WriteLine("Введите точку x1: ");
A[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку Y1: ");
B[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку x2: ");
A[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку Y2: ");
B[1] = Convert.ToDouble(Console.ReadLine());

double Length = Math.Sqrt(Math.Pow(A[2]-A[0], 2) +Math.Pow(B[1]-B[0], 2));
Console.WriteLine(Length);
