// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
while (true)
{
Console.WriteLine("Введите первое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c=Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.WriteLine($"Максимальное из ведённых чисел {a}, {b}, {c} это {max}");
Console.WriteLine("Будем находить максимальное число ещё? (1-Да, 0-Нет)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
{
    Console.Clear();
    Console.WriteLine("Если Вам понравилась эта программа, пополните мой бонусный счёт на 10000 руб.");
        break;
}
};
