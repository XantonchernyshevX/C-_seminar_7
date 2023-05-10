// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (0,0), (1,1) и тд.

int[,] array = CreateTwoDimensionArray(4, 4);
System.Console.WriteLine("Задан двумерный массив: ");
PrintArray(array);
Console.WriteLine($"Сумма элементов на главной диагонали: {Task04(array)}");

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
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int Task04(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i, j];
            }

        }
    }
    return sum;
}