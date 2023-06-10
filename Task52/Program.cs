// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите вертикальную размерность массива (количество строк): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите горизонтальную размерность массива(количество столбцов): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];
mas(m,n);
arif(m,n);
void mas(int m, int n)
   {
      int i,j;
      Random rand = new Random();
      for (i = 0; i < m; i++)
         {
            Console.WriteLine();
            for (j = 0; j < n; j++)
               {
                  randomArray[i,j] = rand.Next(-99,100);
                  Console.Write($"{randomArray[i,j]} ");
               }
         }
      Console.WriteLine();   
    }
void arif(int m, int n)
   {
      //Console.Write("Среднее арифметическое каждого столбца полученного массива: ");
      int i,j;
      Random rand = new Random();
      for (j = 0; j < n; j++)
         {
            double sum = 0;
            for (i = 0; i < m; i++)
               {
                  sum = sum + randomArray[i,j];
               }
            Console.WriteLine($"Среднее арифметическое {j} столбца {sum/(i):F1}; ");
         }
   }


