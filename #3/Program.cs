// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateAndFillArray(int rows, int columns, int lower, int hightest)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(lower, hightest);
    }
    return array;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int[,] ProductOfMatrices(int[,] array, int[,] array2)
{
    if (array.GetLength(0) == array2.GetLength(0) && array.GetLength(1) == array2.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] *= array2[i,j];
            }
        }
    } else Console.WriteLine("Размерность массивов не совпадает!");
return array;
}

Console.Clear();
int rows = ReadInt("Enter the number of rows: ");
int columns = ReadInt("Enter the number of columns: ");
int lowest = 1;
int hightest = 10;

int[,] array = CreateAndFillArray(rows, columns, lowest, hightest);
int[,] array2 = CreateAndFillArray(rows, columns, lowest, hightest);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(ProductOfMatrices(array, array2));