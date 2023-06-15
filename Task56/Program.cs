// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int SumLine(int[,] arrayIn, int i)
{
       int sum = arrayIn[i,0];
       for (int j = 0; j < arrayIn.GetLength(1); j++)
         {
          sum+=arrayIn[i,j];
         }
       return sum;  
}
int smalSum=1;
int[,] arrayOut = GetArray2s();
int sum = SumLine(arrayOut, 0);
for (int i = 1; i < arrayOut.GetLength(0); i++)
{
if (sum > SumLine(arrayOut, i))
{
sum = SumLine(arrayOut, i);
smalSum = i+1;
}
}
PrindArray2d(arrayOut);
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {smalSum}");

 
 
 


