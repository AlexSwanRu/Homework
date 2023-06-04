// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//Создание глобального цикла для организация диалога с пользователем
while(true)
  {
      Console.Write("Введите количество элементов массива: ");
      int a = Convert.ToInt32(Console.ReadLine());
      int[] randomArray = new int[a];
      mas(a);
      Console.WriteLine($"\nCумма элементов, стоящих на нечётных позициях (нумерация элементов начинается с нуля): {kol(randomArray)}");
      Console.WriteLine("Будем развлекаться ещё? (Да-ввод любого числа/Нет-ввод 0)");
   int d=Convert.ToInt32(Console.ReadLine());
   if (d==0)
     {
       Console.Clear();
       Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 3);
       Console.WriteLine("До встречи на занятиях GeekBrains!");
       break;
     }
  // Создание метода нахождения суммы элементов массива стоящих на нечётных местах, начиная с нуля! 
 int kol(int[] randomArray)
 {
  int sum = 0;
  int i = 1;
  while (i < randomArray.Length)
   {
     sum = sum + randomArray[i];
     i = i + 2;
   }
  return sum;
 }
 // Создания метода генерации случайных элементов массива из чисел диапазона от -99 до 100   
void mas(int a)
{
 for (int i = 0; i < a; i++)
  {
   randomArray[i] = new Random().Next(-99,100);
   Console.Write(randomArray[i] + " ");
  }
 }
}

