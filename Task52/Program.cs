// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)//номера столбцов
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");//номера строк
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}



Console.WriteLine();
Console.Write("Введите количество строк в массиве: ");
int userHeight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов: ");
int userWidth = Convert.ToInt32(Console.ReadLine());

int[,] generateArray = generate2DArray(userHeight,userWidth,1,10);

print2DArray(generateArray);

Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < userWidth; i++)
    {
        double sum = 0;
        for (int j = 0; j < userHeight; j++)
        {
            sum = sum + generateArray[j, i];
        }
        double result = Math.Round((sum / userHeight), 1);
        Console.Write($" {result}");
        if (i < userWidth - 1)
        {
            Console.Write("; ");
        }
        else Console.Write(". ");
    }
