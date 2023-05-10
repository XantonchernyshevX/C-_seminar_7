// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет


Console.Clear();
Console.Write("Ведите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateTwoDimensionArray(row, column));
int[,] array = CreateTwoDimensionArray(row, column);

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
    Console.WriteLine("Задан массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.Write("Введите i: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите j: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > row && b > column)
    {
        Console.Write("Заданные i и j больше размера массива. Такого значения нет");
    }
    else
    {
        Console.Write($"Значение ячейки по заданным координатам: {array[a, b]}");
    }
    Console.WriteLine();
}

// void HW02(int[,] array)    // метод некорректно работает. Почему?
// {
// Console.Write("Введите i: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите j: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > row && b > column)
// {
//     Console.Write("Такого значения нет");
// }
// else
// {
//     Console.Write($"{array[a, b]}");
// }
// Console.WriteLine();
// }
// HW02(array);