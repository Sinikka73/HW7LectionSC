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
Console.WriteLine();
Console.Write("Введите целое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber > (userHeight * userWidth -1))
{
    Console.WriteLine();
    Console.Write($"Элемент с номером {userNumber} не существует "); 
}

for (int i = 0; i < generateArray.GetLength(0); i++)
    {
        for (int j = 0; j < generateArray.GetLength(1); j++)
        {
            int k = i * 4 + j;
            if(userNumber == k)
            {
              Console.Write($"Элемент с номером {userNumber} : {generateArray[i, j]} ");  
            }
        }
       
    }


