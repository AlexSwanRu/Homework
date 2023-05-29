// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int cut,summa,clice;
while (true)
{
    summa=0;
    while (true)
    {
        Console.Write("Введите пятизначное число: ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
            {
            if(number>9999&&number<100000)
                {
                    for(clice=number;number!=0;number=number/10)
                        {
                            cut=number % 10;
                            summa=summa*10+cut;
                        }
                    if(clice==summa)
                    Console.WriteLine($"{clice} является палиндромом.");
                        else
                            {
                                Console.WriteLine($"{clice} не является палиндромом.");
                            }
    break;}
            }
    Console.WriteLine("Не корректный ввод, попробуйте еще раз.");
    }
Console.WriteLine("Будем проверять числа на палиндромность ещё раз? (1-Да, 0-Нет)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
        Console.WriteLine("Если Вам не понравилась эта программа или она недостойна оплаты, хотя бы похвалите меня!");
        break;
    };
}