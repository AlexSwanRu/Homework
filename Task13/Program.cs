// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
 while (true)
 {
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
 Console.WriteLine(k < 0 ? "Третьей цифры нет(((" : $"Третья цифра введённого числа {(n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString()}");
Console.WriteLine("Будем пытаться получить третью цифру числа ещё раз? (1-Да, 0-Нет)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
 {
     Console.Clear();
     Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
     Console.WriteLine("Если Вам не понравилась эта программа или она недостойна оплаты, хотя бы похвалите меня!");
         break;
};
}





   