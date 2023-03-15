/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string userMessage)
{
    Console.Write(userMessage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] FillArray(int sizeOfArray)
{
    int[] array = new int[sizeOfArray];

    for (int i = 0; i < array.Length; i++)
    {
        int num = Prompt($"Input a number {i + 1}: ");
        array[i] = num;
    }

    return array;
}

int GreaterThanZero(int[] someArr)
{
    int count = 0;

    for (int i = 0; i < someArr.Length; i++)
    {
        if (someArr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int sizeOfArray = Prompt("Input a quantity of number: ");

int[] numbers = FillArray(sizeOfArray);
int result = GreaterThanZero(numbers);

Console.WriteLine($"Input numbers: [{string.Join(", ", numbers)}]");
Console.Write($"Quantity numbers greater than zero: {result}");
*/

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string userMessage)
{
    Console.Write(userMessage);
    double result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double GetPointX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);

    return x;
}

double GetPointY(double b1, double k1, double b2, double k2, double x)
{
    double y = (k1 * x + b1);

    return y;
}

double b1 = Prompt("Input b1: ");
double k1 = Prompt("Input k1: ");
double b2 = Prompt("Input b2: ");
double k2 = Prompt("Input k2: ");
double pointX = GetPointX(b1, k1, b2, k2);

double pointY = GetPointY(b1, k1, b2, k2, pointX);

Console.Write($"{pointX}; {pointY}");
*/