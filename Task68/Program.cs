// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
while (true)
{
Console.WriteLine("Данная программа вычисляет значения функции Аккермана для двух неотрицательных чисел M и N ");
int m  = Prompt("Введите, пожалуйста, число М = ");
int n  = Prompt("Введите, пожалуйста, число N = ");
Console.WriteLine("Получите то, что хотели!");
Console.WriteLine($"Функция Аккермана для введённых значений {m} и {n} равна {FuncAkker(m,n)}");
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

int FuncAkker (int one, int too)
{
    if (one==0) return too+1;
    else if (too==0) return FuncAkker(one-1,1);
         else return FuncAkker(one-1, FuncAkker(one, too-1));
}
}

