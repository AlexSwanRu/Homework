// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Создание глобального цикла для организация диалога с пользователем
while(true)
  {
      Console.Write("Введите число элементов массива, для поиска в нём количества чётных чисел-");
      int len = Convert.ToInt32(Console.ReadLine());
      int[] array = GetArray(len);
      string arrayToStr = String.Join(", ", array); 
      Console.WriteLine($"Ниже Вы видете сгенирированный случайным образом массив длины {len}");
      Console.WriteLine(arrayToStr); 
      Console.WriteLine($"Количество чётных чисел в привёдённом выше массиве - { EvenNum(array) }");
      Console.WriteLine("Будем развлекаться ещё? (Да-ввод любого числа/Нет-ввод 0)");
   int d=Convert.ToInt32(Console.ReadLine());
   if (d==0)
     {
       Console.Clear();
       Console.WriteLine("До встречи на занятиях GeekBrains!");
       break;
     }
   }
   
   // Описание метода заполнения массива произвольной длины случайными трёхзначными числами
    int[] GetArray(int Length)
      {
        
        int[] array = new int[Length];
        int i=0;
        while (i<Length)
         {
           array[i]=new Random().Next(100, 1000);
           i++;
         }
         return array;
      }  

   // Описание метода поиска количества чётных чисел в полученном в качестве параметра массива
    
   int EvenNum (int[] EntrArray)
    {
        int SumPositive = 0;
        foreach (int number in EntrArray)
          {
            //int CheckPositive = number
            if (number%2 == 0)
             {
                SumPositive += 1;
             }
           }
       return SumPositive; 
    }

