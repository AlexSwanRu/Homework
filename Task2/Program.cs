// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
while (true)
{
Console.WriteLine("Введите первое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=Convert.ToInt32(Console.ReadLine());
if(a>b)
Console.WriteLine("Большее число: " + a + ", и меньшее число: " + b);
else Console.WriteLine("Большее число: " +b+ ", и меньшее число: " +a);
Console.WriteLine("Будем сравнивать ещё? (1-Да, 0-Нет)");
int c=Convert.ToInt32(Console.ReadLine());
if (c==0)
{
    Console.Clear();
    Console.WriteLine("Если Вам понравилась эта программа, пополните мой бонусный счёт на 10000 руб.");
       break;
}
};