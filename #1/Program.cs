// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortArray(int[,] array){
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int k = 0; k < array.GetLength(1); k++){ // Так, как нижняя инструкция двигает только один элемент, то всю инструкцию нужно повторить array.GetLength(1)-1 раз.
             for (int j = array.GetLength(1)-1; j > 0; j--){ //Строка читается с конца и каждый элемент сравнивается с предыдущим. Если он больше предыдущего, они меняются местами.
                if (array[i,j]>array[i,j-1]){
                temp = array[i,j-1];
                array[i,j-1] = array[i,j];
                array[i,j] = temp;
                }
            }
        }
    }
    return array;
}

Console.Clear();
int rows = ReadInt("Enter the number of rows: ");
int columns = ReadInt("Enter the number of columns: ");
int lowest = 1;
int hightest = 10;

int[,] array = CreateAndFillArray(rows, columns, lowest, hightest);
PrintArray(array);
Console.WriteLine();
PrintArray(SortArray(array));