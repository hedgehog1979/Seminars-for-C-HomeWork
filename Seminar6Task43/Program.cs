// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1,             y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] Coordinates = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoordinates()
{
  for (int i = 0; i < Coordinates.GetLength(0); i++)
  {
    Console.WriteLine($"Введите координаты точек");
    for (int j = 0; j < Coordinates.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите координату k: ");
      else Console.Write($"Введите координату b: ");
      Coordinates[i,j] = Convert.ToDouble(Console.ReadLine());
    }
  // Console.WriteLine($"{Coordinates}");
  }
}

double[] Solution(double[,] Coordinates)
{
  crossPoint[0] = (Coordinates[1,1] - Coordinates[0,1]) / (Coordinates[0,0] - Coordinates[1,0]);
  crossPoint[1] = crossPoint[0] * Coordinates[0,0] + Coordinates[0,1];
  return crossPoint;
}

void Return(double[,] Coordinates)
{
  if (Coordinates[0,0] == Coordinates[1,0] && Coordinates[0,1] == Coordinates[1,1]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (Coordinates[0,0] == Coordinates[1,0] && Coordinates[0,1] != Coordinates[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
    Solution(Coordinates);
    Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoordinates();
Return(Coordinates);
