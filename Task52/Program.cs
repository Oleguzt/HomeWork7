// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

int EnterData(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void AvrForColumns(int[,] array, int i, int j)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        double avr = Math.Round(sum / array.GetLength(0),1);
        Console.Write(avr + "; ");
    }   
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
int[,] matrix = FillArray(rows, columns, 0, 10);
AvrForColumns(matrix, rows, columns);


