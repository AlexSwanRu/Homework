// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
while (true)
{
Console.WriteLine("Данная программа выведет на экран в порядке убывания натуральные числа ");
Console.WriteLine("от введённого Вами числа N до числа 1");
int st  = Prompt("Введите, пожалуйста, N = ");
Console.WriteLine("Получите то, что хотели!");
Console.WriteLine(PrintNumbers(st));
Console.WriteLine("Достаточно? (Любое число-Ещё чуть-чуть!, 0-Да, просто достало уже!)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
 {
     Console.Clear();
     Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
     Console.WriteLine("До новых встреч среди кодов С#!");
         break;
 }
int Prompt(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

string PrintNumbers (int start)
{
    if (start==1)
     {
        return start.ToString();
     }
     return start + ", " + PrintNumbers(start - 1);
}
}
