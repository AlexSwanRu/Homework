// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
while (true)
{
Console.WriteLine("Введите число для отображения всех чётных чисел меньших его");
int n=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
Console.Write(i + ", ");
}
Console.WriteLine();
Console.WriteLine("Будем находить чётные числа ещё? (1-Да, 0-Нет)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
{
    Console.Clear();
    Console.WriteLine("Если Вам понравилась эта программа, пополните мой бонусный счёт на 10000 руб.");
        break;
}
};