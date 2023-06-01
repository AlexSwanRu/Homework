while (true)
{
int[] randomArray = new int[8];
Console.Write("[");
for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,99);
Console.Write(String.Join(",",randomArray[i]," "));
}
Console.WriteLine("]");
Console.WriteLine("Будем генерировать массив ещё раз ? (любая цифра-Да, 0-Нет)");
int d=Convert.ToInt32(Console.ReadLine());
if (d==0)
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 10, Console.WindowHeight / 2);
        Console.WriteLine("Если Вам не понравилась эта программа - предложите мне работу!");
        break;
    };
}
