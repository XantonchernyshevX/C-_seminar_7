// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

Console.Clear();
Console.Write("Ведите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задан массив:");
int[,] array = CreateTwoDimensionArray(row, column);
PrintArray(array);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");

int[,] CreateTwoDimensionArray(int row, int column)
{
    int[,] array = new int[row, column];
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
            Console.Write($"{array[i, j]}      ");
        }
        Console.WriteLine();
    }
}

for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average += array[i, j];
    }
    average /= row;
    Console.Write($"{average:F2}  ");
}