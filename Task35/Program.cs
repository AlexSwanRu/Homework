// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
while(true)
  {
int N=123;
int[] mas=new int[N];
Random random=new Random();
for(int i=0;i<mas.Length;i++)
    mas[i]=random.Next(0, 1000);
for(int i=0;i<mas.Length;i++)
    Console.Write($"{mas[i]},");
int count=0;
for(var i=0; i<mas.Length;i++)
    {
        if(mas[i]>10 && mas[i]<99)
        count++;
    }
Console.WriteLine();
Console.WriteLine(count);
   Console.WriteLine("Будем развлекаться ещё? (Да-ввод любого числа/Нет-ввод 0)");
   int d=Convert.ToInt32(Console.ReadLine());
   if (d==0)
     {
       Console.Clear();
       Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 3);
       Console.WriteLine("До встречи на занятиях GeekBrains!");
       break;

     }
  }