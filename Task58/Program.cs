﻿// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

while(true)
{
Console.WriteLine("Введите размеры перемножаемых матриц и диапазон случайных значений для их заполнения:");
int m = GetNumbers("Введите число строк 1-й матрицы: ");
int n = GetNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// Матрицы A и B МОГУТ быть перемножены, если они СОВМЕСТИМЫ в том смысле, 
//что число столбцов матрицы A РАВНО ЧИСЛУ СТРОК матрицы B !!!
int q = GetNumbers("Введите число строк 2-й матрицы: ");
int p = GetNumbers("Введите число столбцов 2-й матрицы: ");
if (n!=q)
  {
   Console.Write("Матрицы A и B МОГУТ быть перемножены, если только они СОВМЕСТИМЫ в том смысле,");
   Console.Write("что число столбцов матрицы A РАВНО ЧИСЛУ СТРОК матрицы B !!!");
   Console.WriteLine("Введите корректные размеры перемножаемых матриц !!!");
   break;
   }

int range = GetNumbers("Введите диапазон случайных чисел: от 1 до - ");
int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);


void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int GetNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
Console.WriteLine("Ещё не пропало желание умножать матрицы? (Любое число-Не пропало!, 0-Просто достало!)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
 {
     Console.Clear();
     Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
     Console.WriteLine("До новых встреч среди кодов С#!");
         break;
}
}