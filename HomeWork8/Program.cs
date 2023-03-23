// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
            array[i, j] = (rnd.Next(1, 11));
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

int[,] SortElementsOnDecrease(int[,] someMatrix)
{
    int min = someMatrix[0, 0];
    int temp;

    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            if (min > someMatrix[i, j])
            {
                min = someMatrix[i, j];
                temp = someMatrix[i, someMatrix.GetLength(1) - 1 - j];
                someMatrix[i, someMatrix.GetLength(1) - 1 - j] = min;
                someMatrix[i, someMatrix.GetLength(1) - 2 - j] = temp;
            }
        }
    }

    return someMatrix;
}

int rows = Prompt("Input quantity of rows: ");
int cols = Prompt("Input quantity of cols: ");

int[,] matrix = FillMatrixWithRandom(rows, cols);
PrintMatrix(matrix);
Console.WriteLine();
int[,] decreaseMatrix = SortElementsOnDecrease(matrix);
PrintMatrix(decreaseMatrix);