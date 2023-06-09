// задача 46. задайте двумерный массив размером m*n, заполненный случайными числами
// m = 3, n = 4.

// int[,] array2d = new int[3, 4];

// for (int i = 0; i < array2d.GetLength(0); i++)
// {
//     for (int j = 0; j < array2d.GetLength(1); j++)
//     {
//         array2d[i, j] = new Random().Next(1, 10);

//         Console.Write(array2d[i, j] + " ");
//     }
//     Console.WriteLine();
// }


// задайте двумерный массив m*n, каждый эл-т в массиве находится по формуле A=m+n.
// выведите полученный массив на экран 
/*
Console.WriteLine("введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        array2d[i, j] = i + j;

        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}
*/

// задача 49. задайте двумерный массив. найдите эл-ты у к-ых оба индекса четные и замените 
// эти эл-ты на их квадраты

/*
Console.WriteLine("введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        array2d[i, j] = new Random().Next(4, 10);

        Console.Write(array2d[i, j] + " "); 
          
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        
        if (i % 2 == 1 && j % 2 == 1)
            {
            array2d[i, j] *= array2d[i, j];
            }
        Console.Write(array2d[i, j] + " ");  
    }
    Console.WriteLine();
}
*/


// задача 51. задайте двумерный массив. найдите сумму эл-тов, находящиеся на главной диагонали
//(т.е. эл-ты с (0,0); (1,1) и т.д.)



Console.WriteLine("введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
int sum = 0;

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        array2d[i, j] = new Random().Next(1, 10);

        Console.Write(array2d[i, j] + " "); 

        if (i==j)
        {
            sum += array2d[i, j];
        }
    }
    Console.WriteLine();
}

Console.WriteLine($"Сумма чисел на главной диагонали равна {sum}");