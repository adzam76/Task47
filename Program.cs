// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Console.WriteLine("Введите количество строк массива ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] table = new double[m, n];

void FillArray(double[,] tab)
{
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
        for (int columns = 0; columns < tab.GetLength(1); columns++)
        {
            tab[rows, columns] = new Random().Next(-9,10) + new Random().NextDouble();
            // слишком длинные числа получаются
            System.Console.Write($"{tab[rows, columns]}");
        }
        
        Console.WriteLine();
    }
}
 FillArray(table);