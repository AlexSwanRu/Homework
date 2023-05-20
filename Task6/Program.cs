// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
while (true)
{
Console.WriteLine("Введите число для проверки на чётность");
int a=Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
Console.WriteLine("Число: " + a + " четное");
else System.Console.WriteLine($"Число: {a} нечетное");
Console.WriteLine("Будем проверять на чётность ещё? (1-Да, 0-Нет)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
{
    Console.Clear();
    Console.WriteLine("Если Вам понравилась эта программа, пополните мой бонусный счёт на 10000 руб.");
        break;
}
};



