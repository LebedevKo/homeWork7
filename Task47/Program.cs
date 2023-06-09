// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array2D = new double[m, n];
Random random = new Random();

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        double randomNumber = random.NextDouble() * 20 - 10; 
        array2D[i, j] = Math.Round(randomNumber, 1); 
        Console.Write(array2D[i, j] + " ");
    }
    Console.WriteLine();
}
