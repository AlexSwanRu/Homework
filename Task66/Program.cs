// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
while (true)
{
Console.WriteLine("Данная программа выведет на экран сумму натуральных чисел ");
Console.WriteLine("от введённого Вами числа М до введённого Вами числа N");
int st  = Prompt("Введите, пожалуйста, число М = ");
int fn  = Prompt("Введите, пожалуйста, число N = ");
Console.WriteLine("Получите то, что хотели!");
Console.WriteLine(SummaNumbers(st,fn));
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

int SummaNumbers (int start, int finish)
{
    if (start==finish)
     {
        return start;
     }
        return start+SummaNumbers(start+1, finish);
}
}
