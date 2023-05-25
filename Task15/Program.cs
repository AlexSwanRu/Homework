// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
while (true)
{
int Prompt(string msg)
{
Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число дня недели");
string ss = "Это число не является днём недели";
string check(int number)
{
if (number >= 6 && number < 8) ss = "Это выходной";
if (number >= 1 && number < 6) ss = "Это будний день";
return ss;
}
Console.WriteLine(check(number));
Console.WriteLine("Будем ждать выходные ещё? (1-Да, 0-Нет)");
int c=Convert.ToInt32(Console.ReadLine());
if (c==0)
{
    Console.Clear();
    Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
    Console.WriteLine("Если Вам понравилась эта программа, пополните мой бонусный счёт на отдых..");
       break;
}
};
