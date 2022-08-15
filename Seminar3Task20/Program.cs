// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] A = new double[3];
double[] B = new double[3];
double[] C = new double[3];
Console.WriteLine("Введите точку x1: ");
A[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку y1: ");
B[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку z1: ");
C[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку x2: ");
A[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку Y2: ");
B[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку z2: ");
C[1] = Convert.ToDouble(Console.ReadLine());

double Length = Math.Sqrt(Math.Pow(A[1]-A[0], 2) +Math.Pow(B[1]-B[0], 2) +Math.Pow(C[1]-C[0], 2));
Console.WriteLine(Length);
