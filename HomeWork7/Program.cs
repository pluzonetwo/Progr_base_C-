/* Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[,] FillMatrixWithRandom(int row, int col)
{
    double[,] array = new double[row, col];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((rnd.NextDouble()) * 10, 1);
        }
    }
    return array;
}

void PrintMatrix(double[,] someMatrix)
{
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            Console.Write($"{someMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = Prompt("Input quantity of rows: ");
int cols = Prompt("Input quantity of cols: ");

double[,] matrix = FillMatrixWithRandom(rows, cols);
PrintMatrix(matrix);
*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 11);
        }
    }
    return array;
}

bool SearchElementInMatrix(int[,] someMatrix, int number)
{
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            if (someMatrix[i, j] == number)
            {
                Console.WriteLine($"Number {number} is in the matrix");
                return true;
            }
        }
    }
    Console.WriteLine($"Number {number} is not in the matrix");
    return false;
}

void PrintMatrix(int[,] someMatrix)
{
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            Console.Write($"{someMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = Prompt("Input quantity of rows: ");
int cols = Prompt("Input quantity of cols: ");
int searchNumber = Prompt("Enter search number: ");

int[,] matrix = FillMatrixWithRandom(rows, cols);
PrintMatrix(matrix);
SearchElementInMatrix(matrix, searchNumber);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] someMatrix)
{
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            Console.Write($"{someMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] someMatrix, int rows)
{
    int result = 0;
    double average = 0;

    for (int i = 0; i < someMatrix.GetLength(1); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(0); j++)
        {
            result = result + someMatrix[i, j];
        }
        average = result / rows;
        Console.WriteLine($"Average of column {i + 1}: {average}");
        result = 0;
    }
}

int rows = Prompt("Input quantity of rows: ");
int cols = Prompt("Input quantity of cols: ");

int[,] matrix = FillMatrixWithRandom(rows, cols);
PrintMatrix(matrix);
Average(matrix, rows);