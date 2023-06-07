//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите свободный коэффициент первой прямой b1: ");
double b1= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент первой прямой k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициент второй прямой b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент второй прямой k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1!=k2 && b1!=b2)
 {
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"\n Точка пересечения двух прямых имеет координаты: [{x},{y}]");
 }
else
    if (k1==k2 && b1==b2)
      Console.Write("Точек перечения - бесконечность, т.к. прямые совпадают");
    else 
       Console.Write("Прямые параллельны, т.е. не имееют точек перечения");
   