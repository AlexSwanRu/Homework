// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите вертикальную размерность массива (количество строк): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите горизонтальныю размерность массива(количество столбцов): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];
mas(m,n);
// Создание метода заполненич двумерного ипссива
void mas(int m, int n)
   {
      int i,j;
      Random rand = new Random();
      for (i = 0; i < m; i++)
      {
         Console.WriteLine();
         for (j = 0; j < n; j++)
            {  
               randomArray[i,j] = rand.Next(minVal, maxVal) + rand.NextDouble();
               Console.Write($"{randomArray[i,j]:F2} ");
            }

      }

   }


