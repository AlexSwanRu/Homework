// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
while (true)
{
    
int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
Console.WriteLine("Ровно через 5 секунды под этим пояснением Вы увидите, полученный магическим способом 3D массив с его индексами!");
int milliseconds = 2000;
Thread.Sleep(milliseconds);
Console.WriteLine("Крибле!");
Thread.Sleep(milliseconds);
Console.WriteLine("Крабле!");
Thread.Sleep(milliseconds);
Console.WriteLine("Бумс!");
PrintIndex(array3D);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Ещё не пропало желание созерцать это? (Любое число-Не пропало!, 0-Просто достало!)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
 {
     Console.Clear();
     Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
     Console.WriteLine("До новых встреч среди кодов С#!");
         break;
}



// Создание метода вывода рядом с элементом индекса его в 3D массиве
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Создание метода заполнения 3D массива не повторяющимеся числами оригинальным методом)
void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}
}