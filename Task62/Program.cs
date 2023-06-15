// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
//  1  2  3 4
// 12 13 14 5
// 11 16 15 6
// 10  9  8 7
while (true)
{
    
//int[,,] array3D = new int[2, 2, 2];
//FillArray(array3D);
Console.WriteLine("Ровно через 5 секунды под этой надписью Вы увидите, полученный магическим способом массив 4х4 ");
int milliseconds = 2000;
Thread.Sleep(milliseconds);
Console.WriteLine("Крибле!");
Thread.Sleep(milliseconds);
Console.WriteLine("Крабле!");
Thread.Sleep(milliseconds);
Console.WriteLine("Бумс!");
int n = 4;
int[,] KvadratMatrix = new int[n, n];

int tmp = 1;
int i = 0;
int j = 0;

while (tmp <= KvadratMatrix.GetLength(0) * KvadratMatrix.GetLength(1))
{
  KvadratMatrix[i, j] = tmp;
  tmp++;
  if (i <= j + 1 && i + j < KvadratMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= KvadratMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > KvadratMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(KvadratMatrix);


//PrintIndex(array3D);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Ещё не пропало желание созерцать магию? (Любое число-Не пропало!, 0-Просто достало!)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
 {
     Console.Clear();
     Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
     Console.WriteLine("До новых встреч среди кодов С#!");
         break;
}


// Создание метода печати квадратной матрицы 4Х4

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
}
  