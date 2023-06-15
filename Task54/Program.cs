// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int Promt (string text)
 {
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
 } 
int [,] GetArray2s () 
 {
    int m = Promt("Введите количество строк массива - m = ");
    int n = Promt("Введите количество столбцов массива - n = "); 
    int [,] array = new int [m, n];
    for (int i = 0; i < m; i ++) 
      {         
        for (int j = 0; j < n; j++)
           { 
              array [i, j] = new Random(). Next (1, 10);
            }
      }
    return array;
  } 
void PrindArray2d (int [,] array2d)
 {
  for (int i = 0; i < array2d.GetLength(0); i++)
     {
       for (int j = 0; j < array2d.GetLength(1); j++)
         {
           Console.Write(array2d[i, j] + " ");
        }
           Console.WriteLine();
      }
 }
void InOrder(int[,] arrayIn)
{
 for (int i = 0; i < arrayIn.GetLength(0); i++)
  {
   for (int j = 0; j < arrayIn.GetLength(1); j++)
     {
        for (int k = 0; k < arrayIn.GetLength(1)-1; k++)
           {
             if (arrayIn[i, k] < arrayIn[i, k + 1])
               {
                  int temp = arrayIn[i, k + 1];
                  arrayIn[i, k + 1] = arrayIn[i, k];
                  arrayIn[i, k] = temp;
               }
           }
      }
   }
}
int[,] array2d = GetArray2s();
PrindArray2d(array2d); 
Console.WriteLine();
InOrder(array2d);
PrindArray2d(array2d); 