/* Task 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string inputData)
{
    Console.Write(inputData);
    int userNum = Convert.ToInt32(Console.ReadLine());
    return userNum;
}
int Pow(int number, int degree)
{
    if (degree == 1)
    {
        return number;
    }
    else
    {
        int result = 1;
        for (int i = 0; i < degree; i++)
        {
            result *= number;
        }
        return result;
    }
}

int a = Prompt("Input number: ");
int b = Prompt("Input degree of number: ");

int power = Pow(a, b);

Console.Write($"{a} to the {b} power equals {power}");
*/

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string inputData)
{
    Console.Write(inputData);
    int userNum = Convert.ToInt32(Console.ReadLine());
    return userNum;
}
int SumNumberDigit(int number)
{
    int result = 0;

    for (int i = 0; i <= number; i++)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int num = Prompt("Input a number: ");
int sum = SumNumberDigit(num);

Console.Write($"Sum of the number {num} equals {sum}");
*/

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int Prompt(string inputData)
{
    Console.Write(inputData);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 1000);
    }
    return arr;
}

int sizeOfArray = Prompt("Input a size of array: ");
int[] array = FillArray(sizeOfArray);

Console.Write($"Your array: [{string.Join(", ", array)}]");
*/
