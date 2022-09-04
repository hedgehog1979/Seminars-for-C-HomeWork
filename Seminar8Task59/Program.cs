// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] Search(int[,] array, int[,] position)
{
  int temp = array[0, 0];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] <= temp)
      {
        position[0, 0] = i;
        position[0, 1] = j;
        temp = array[i, j];
      }
    }
  }
  Console.WriteLine($"\nMинимальный элемент: {temp}");
  return position;
}

void Modify(int[,] array, int[,] MinElement, int[,] arrayWithoutLines)
{
  int k = 0, l = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (MinElement[0, 0] != i && MinElement[0, 1] != j)
      {
        arrayWithoutLines[k, l] = array[i, j];
        l++;
      }
    }
    l = 0;
    if (MinElement[0, 0] != i)
    {
      k++;
    }
  }
}
int[,] matrix = new int[5, 5];

int[,] MinElement = new int[1, 2];
MinElement = Search(matrix, MinElement);
Console.Write($"Позиция элемента: \n");
WriteArray(MinElement);

int[,] NewArray = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
Modify(matrix, MinElement, NewArray);
Console.WriteLine($"\nПолучившийся массив:");
WriteArray(NewArray);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write($" [ {matrix[i, j]} ] ");

    }
    Console.WriteLine();
}
Console.WriteLine();
