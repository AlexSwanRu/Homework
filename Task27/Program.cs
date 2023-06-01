while (true)
{
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int len = Length(a);
Console.WriteLine($"Сумма цифр в числе {a} равно: {Sum(a,len)}");
Console.WriteLine("Будем считать сумму цифр числа ещё раз? (любая цифра-Да, 0-Нет)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
        Console.WriteLine("Если Вам не понравилась эта программа - предложите мне работу!");
        break;
    };
}


// Подсчет количества символов в числе
int Length(int a)
{
int index = 0;
while (a > 0)
{
a /= 10;
index++;
}
return index;
}

int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += a % 10;
a /= 10;
}
return sum;
}