// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.


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
Console.WriteLine("Введите интересующее вас число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool found = false;

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        if (array2d[i,j] == number)
        {
            found = true;
            Console.WriteLine($"Элемент {number} найден в строчке {i+1},столбец {j+1}");
        }
        
    }
}

if (!found)
{
    Console.WriteLine("Элемент не найден");
}