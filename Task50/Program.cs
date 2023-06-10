// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет
Console.Write("Введите вертикальную размерность массива(количество строк): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите горизонтальную размерность массива(количество столбцов): ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];
Console.Write("Введите позицию строки искомого элемента: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца искомого элемента: ");
int n2 = Convert.ToInt32(Console.ReadLine());
void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.NextDouble();
Console.Write($"{randomArray[i,j]:F2} ");
}
Console.WriteLine();
}
}
mas(m,n);
if (m2 <= m+1 && n2 <= n+1)
Console.Write($"Значение искомого элемента при заданных условиях c учётом нумерации с нуля равно {randomArray[m2,n2]:F2} ");
else Console.Write("Элемент запрашиваемыми условиями не может быть найден в полученном массиве!");
