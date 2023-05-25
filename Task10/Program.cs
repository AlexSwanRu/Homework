// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
while (true)
{
while (true)
{
    Console.Write("Введите трёхзначное число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        if(number>99&&number<1000)
        {int average=(number%100-number%10)/10;
        Console.WriteLine($"Вторая цифра числа {number} является {average}");   
            break;}
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
Console.WriteLine("Будем получать среднюю цифру числа ещё? (1-Да, 0-Нет)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
{
    Console.Clear();
    Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
    Console.WriteLine("Если Вам не понравилась эта программа или она недостойна оплаты, хотя бы похвалите меня!");
        break;
};
}

   