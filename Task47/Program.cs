// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


void fill2DArray(double[,] collection)
{
    int height = collection.GetLength(0);
    int width = collection.GetLength(1);
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            //collection[i, j] = Math.Round(((new Random().NextDouble()) + new Random().Next(-10, 10)), 1);
            collection[i, j] = new Random().Next(-100, 100) / 10.0;
        }
    }
}

void printColorData(string data)//доб цвета
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(double[,] arrayToPrint)
{
    Console.WriteLine();
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)//идентификатор
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");// табуляция
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write (arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.Write("Введите количество строк массива: ");
int userHeight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов массива: ");
int userWidth = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[userHeight, userWidth];
fill2DArray(array);
print2DArray(array);