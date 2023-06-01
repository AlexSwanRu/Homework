while (true)
{
 int flag=0;
 Console.Write("Введите число A: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите число B: ");
 int b = Convert.ToInt32(Console.ReadLine());
 int c = 1;
 if (b<1)
    {
    Console.Write("Число B должно быть натуральным\n");
    flag=1;
    }
 else
  {
    if (flag==0)
     {
      while (b!=0)
       {
         c = c * a;
         b = b - 1;
       }
       Console.WriteLine($"Число A в натуральной степени B равно {c}");
     }
    else Console.WriteLine($"Степень числа A не может быть подсчитана");
  }
  Console.WriteLine("Будем считать степень числа ещё раз? (любое число-Да, 0-Нет)");
  int d=Convert.ToInt32(Console.ReadLine());
  if (d==0)
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
        Console.WriteLine("Если Вам не понравилась эта программа или она недостойна оплаты, хотя бы похвалите меня!");
        break;
    }
}
