// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateAndFill3Array()
{
    int[,,] array = new int[2, 2, 2];
    int[] randomNumbers = NonRepeatingNumbers(array.GetLength(0) * array.GetLength(1) * array.GetLength(2));

    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = randomNumbers[count];
                count++;
            }
        }
    }
    return array;
}

int[] NonRepeatingNumbers(int length)
{
    Random random = new Random();
    int[] randomNumbers = new int[length];
    int randomNumber = 0;
    bool flag = false;
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumber = random.Next(10, 100);
        for (int j = 0; j < randomNumbers.Length; j++)
        {
            if (randomNumber == randomNumbers[j] || flag) flag = true;
        }
        if (!flag) randomNumbers[i] = randomNumber;
        else i--;
        flag = false;
    }
    return randomNumbers;
}

void Print3Array(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Print3Array(CreateAndFill3Array());