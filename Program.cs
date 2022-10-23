/* Задача 47.
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] Random(int m, int n)
{
    double[,] Num = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        Num [i,j] = Math.Round(new Random().NextDouble()*(10-(-10))+(-10), 1); // Случайное число double от -10 до 10
        }
    
}

return Num;
}
void Print(double [,] aaa)
{
System.Console.WriteLine();
int x = aaa.GetLength(0);
int y = aaa.GetLength(1);
for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
            System.Console.Write(aaa[i,j] + " ");
        System.Console.WriteLine("");
    }
System.Console.WriteLine();
System.Console.WriteLine();

}

Console.WriteLine();
Console.Write("Введите количество строк массива случайных вещественных чисел: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов массива случайных вещественных чисел: ");
int b = int.Parse(Console.ReadLine());

double[,] qqq = Random(a, b);
Print(qqq);
