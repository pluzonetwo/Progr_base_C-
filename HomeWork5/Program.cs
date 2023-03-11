/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве

int Prompt(string userMessage)
{
    Console.Write(userMessage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] FillArray(int sizeArr)
{
    int[] arr = new int[sizeArr];
    Random rnd = new Random();

    for (int i = 0; i < sizeArr; i++)
    {
        arr[i] = rnd.Next(100, 1001);
    }

    return arr;
}

int GetEvenNumber(int[] someArr)
{
    int count = 0;

    for (int i = 0; i < someArr.Length; i++)
    {
        if (someArr[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int size = Prompt("Input a size of arr: ");
int[] newArray = FillArray(size);
int evenNumbers = GetEvenNumber(newArray);

Console.WriteLine($"Your array: [{string.Join(", ", newArray)}]");
Console.WriteLine($"Even numbers in array: {evenNumbers}");
*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

int Prompt(string userMessage)
{
    Console.Write(userMessage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] FillArray(int sizeArr)
{
    int[] arr = new int[sizeArr];
    Random rnd = new Random();

    for (int i = 0; i < sizeArr; i++)
    {
        arr[i] = rnd.Next(-11, 11);
    }

    return arr;
}

int SumOddElements(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

int size = Prompt("Input a size of arr: ");
int[] newArray = FillArray(size);
int sumOddEl = SumOddElements(newArray);

Console.WriteLine($"Your array: [{string.Join(", ", newArray)}]");
Console.WriteLine($"Sum odd elements in array: {sumOddEl}");
*/

/* Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.
 [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

int Prompt(string userMessage)
{
    Console.Write(userMessage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] FillArray(int sizeArr)
{
    double[] arr = new double[sizeArr];
    Random rnd = new Random();

    for (int i = 0; i < sizeArr; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble()) * 100, 1);
    }

    return arr;
}

double Differense(double[] someArr)
{
    double min = someArr[0];
    double max = 0;
    double dif = 0;

    for (int i = 0; i < someArr.Length; i++)
    {
        if (someArr[i] <= min)
        {
            min = someArr[i];
        }

        if (someArr[i] > max)
        {
            max = someArr[i];
        }
    }

    dif = Math.Round((max - min), 1);

    return dif;
}

int size = Prompt("Input a size of arr: ");
double[] newArray = FillArray(size);
double difMinAndMax = Differense(newArray);

Console.WriteLine($"Your array: [{string.Join("; ", newArray)}]");
Console.WriteLine($"Difference between min and max elements: {difMinAndMax}");
*/
