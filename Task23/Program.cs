// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
while (true)
{
    Console.Write("Введите число N: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write("Таблица кубов:\n");
    for (int i=1;i<=num;i++)
        {
            int kub = i*i*i;
            Console.Write($"{kub}, ");
        }
Console.WriteLine();     
Console.WriteLine("Будем считать кубы чисел ещё раз? (1-Да, 0-Нет)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
        Console.WriteLine("Если Вам не понравилась эта программа или она недостойна оплаты, хотя бы похвалите меня!");
        break;
    }
}
