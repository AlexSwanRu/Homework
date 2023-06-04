// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
while(true)
  {
      Console.Write("Введите количество элементов массива: ");
      int a = Convert.ToInt32(Console.ReadLine());
      int[] RandomArray = new int[a];
      Console.WriteLine("Ниже представлен сгенерированыый массив");
      Mas(a);
      //Console.WriteLine("Это массив полученный непостижимым магическим образом!");
      Console.WriteLine();
      Console.WriteLine("Будем развлекаться ещё? (Да-ввод любого числа/Нет-ввод 0)");
   int d=Convert.ToInt32(Console.ReadLine());
   if (d==0)
     {
       Console.Clear();
       Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 3);
       Console.WriteLine("До встречи на занятиях GeekBrains!");
       break;
     }
  
 // Создания метода генерации случайных элементов массива из чисел диапазона от 1 до 100   
int[] Mas(int Length)
{
 //Console.WriteLine("Это массив полученный непостижимым магическим образом!");
 for (int i = 0; i < Length; i++)
  {
   RandomArray[i] = new Random().Next(1,100);
   Console.Write(RandomArray[i] + " ");
  }
    int j=0;
    int[] OutArray = new int[(1+Length/2)];
    Console.WriteLine();
    Console.WriteLine("Это массив полученный непостижимым магическим образом!");
    while (((Length+1)/2-j)!=0)
     {
        if ((Length/2-j)!=0)
          OutArray[j]=RandomArray[j]*RandomArray[Length-j-1];
        else 
         OutArray[j]=RandomArray[j];
        Console.Write(OutArray[j] + " ");
        j++;
        
      }
      Console.WriteLine();   
       return OutArray;
 }
}


