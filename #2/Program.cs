// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateAndFillArray(int rows, int columns, int lower, int hightest){
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(lower, hightest);
    }
    return array;
}

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write($"{array[i,j]}\t");
        Console.WriteLine();
    }
}

int SearchMinSumRows(int[,] array){
    int tempSum = 0;
    int minSum = 0;
    int minIndex = 1;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i,j];
        }
        if (i==0) minSum = tempSum;
        if (tempSum<minSum){
            minSum = tempSum;
            minIndex = i+1;
        }
        Console.WriteLine($"Сумма строки №{i+1}: {tempSum}");
        tempSum = 0;
    }
    return minIndex;
}

Console.Clear();
int rows = ReadInt("Enter the number of rows: ");
int columns = ReadInt("Enter the number of columns: ");
int lowest = 1;
int hightest = 10;

int[,] array = CreateAndFillArray(rows, columns, lowest, hightest);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Строка: {SearchMinSumRows(array)}");