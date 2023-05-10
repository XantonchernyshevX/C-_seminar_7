// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{array[i, j]} ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{array[i, j]} ");
            }
        Console.WriteLine();
    }
}

int[,] Task03(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        if (i % 2 == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i % 2 == 0 && j % 2 == 0)
                    array[i, j] = array[i, j] * array[i, j];
            }
            Console.WriteLine();
        }
    return array;
}

int[,] array = CreateTwoDimensionArray(3, 4);
Console.Clear();
PrintArray(array);
Task03(array);
PrintArray(array);