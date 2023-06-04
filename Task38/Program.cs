// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
   //Создание глобального цикла для организация диалога с пользователем
while(true)
  {
     Console.Write("Введите число элементов массива, для поиска разности между максимальным и минимальным элементами -");
      int len = Convert.ToInt32(Console.ReadLine());
      Double[] array = GetArray(len);
      string arrayToStr = String.Join(" ", array); 
      Console.WriteLine($"Ниже Вы видете сгенирированный случайным образом массив длины {len}");
      Console.WriteLine($"{arrayToStr:F2}");  
      Console.WriteLine($"\nРазница между максимальным и минимальным элементов массива: {Diff(array):F2}");
   Console.WriteLine("Будем развлекаться ещё? (Да-ввод любого числа/Нет-ввод 0)");
   int d=Convert.ToInt32(Console.ReadLine());
   if (d==0)
     {
       Console.Clear();
       Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 3);
       Console.WriteLine("До встречи на занятиях GeekBrains!");
       break;
     }
  // Создание метода нахождения разницы между максимальным и минимальным элементами массива.
  double Diff(double[] randomArray)
    {
        double min = randomArray[0];
        double max = randomArray[0];
        int i = 1;
        while (i < randomArray.Length)
            {
                if (max<randomArray[i])
                    max = randomArray[i];
                        if (min>randomArray[i])
                            min = randomArray[i];
                  i++;
            }
        return max-min;
    }
 
 // Создание метода генерации случайных элементов массива из вещественных чисел диапазона от 0 до 100   
Double[] GetArray(int Length)
      {
        Double[] array = new Double[Length];
        int i=0;
        while (i<Length)
         {
           array[i]=Math.Round(new Random().NextDouble()*100, 2);
           i++;
         }
         return array;
      }  
}
  

 
