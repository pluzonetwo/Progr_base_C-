/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2


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
            array[i, j] = (rnd.Next(1, 10));
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
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            int pos = j;
            int temp;

            for (int k = j + 1; k < someMatrix.GetLength(1); k++)
            {
                if (someMatrix[i, k] > someMatrix[i, pos])
                {
                    pos = k;
                }
            }

            temp = someMatrix[i, j];
            someMatrix[i, j] = someMatrix[i, pos];
            someMatrix[i, pos] = temp;

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
*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            array[i, j] = (rnd.Next(1, 10));
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

int ShowLargerstSumOfStr(int[,] someMatrix)
{
    int[] array = new int[someMatrix.GetLength(0)];
    int sumElInStr = 0;
    int result = 0;

    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            sumElInStr += someMatrix[i, j];
        }

        array[i] = sumElInStr;

        if (i == 0) result = array[0];
        else if (array[i] < result) result = array[i];

        sumElInStr = 0;
    }

    return result;
}

int rows = Prompt("Input quantity of rows: ");
int cols = Prompt("Input quantity of cols: ");

int[,] matrix = FillMatrixWithRandom(rows, cols);
PrintMatrix(matrix);
Console.WriteLine();
int result = ShowLargerstSumOfStr(matrix);

Console.Write($"Min number: {result}");
*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,,] FillMatrixWithRandom(int row, int col, int zol)
{
    int[,,] array = new int[row, col, zol];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = (rnd.Next(10, 100));
            }
        }
    }
    return array;
}

void PrintMatrix(int[,,] someMatrix)
{
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < someMatrix.GetLength(2); k++)
            {
                Console.Write($"{someMatrix[i, j, k]} ");
            }
            Console.WriteLine();
        }
    }
}

int rows = Prompt("Input quantity of rows: ");
int cols = Prompt("Input quantity of cols: ");
int zols = Prompt("Input quantity of zols: ");

int[,,] matrix = FillMatrixWithRandom(rows, cols, zols);
PrintMatrix(matrix);
*/