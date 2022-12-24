// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что
//  такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int begin, int end)
{
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();

    }
    return array;
}

void FindPositionInArray(int[,] array, int i, int j)
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
    {
        Console.WriteLine("В указанной позиции число: " + array[i - 1, j - 1]);
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

int EnterData(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
int[,] matrix = FillArray(rows, columns, 0, 10);
int i = EnterData($"Введите номер строки массива: ");
int j = EnterData($"Введите номер столбца массива: ");
FindPositionInArray(matrix, i, j);





