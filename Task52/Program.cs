// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2d = new int[m, n];

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        array2d[i, j] = new Random().Next(1, 10);

        Console.Write(array2d[i, j] + " ");

    }
    Console.WriteLine();
}

int rows = array2d.GetLength(0);
int cols = array2d.GetLength(1);

double[] result = new double[cols];

for (int j = 0; j < cols; j++)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array2d[i, j];
    }
    result[j] = (double)sum / rows;
}

for (int j = 0; j < cols; j++)
{
    Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {result[j]}");
}


