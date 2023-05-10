// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] TDArray(int row, int column)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 20 - 10;     //интервал от -10 до 10
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F1}");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Ведите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задан двумерный массив:");
PrintArray(TDArray(row, column));
