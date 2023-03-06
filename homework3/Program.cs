/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;

}
int CountOfNumber(int number)
{
    int length = 0;

    while (number % 10 != 0)
    {
        number /= 10;
        length++;
    }

    return length;
}
bool IsFiveNumber(int numberLength)
{
    if (numberLength == 5) return true;
    else
    {
        Console.Write("Input five-digit number!");
        return false;
    }
}
bool IsPal(int number)
{
    int numberLength = CountOfNumber(number);

    if (IsFiveNumber(numberLength))
    {
        int[] arrWithNumber = { number / 10000,
                            number / 1000 % 10,
                            number / 100 % 10,
                            number / 10 % 10,
                            number % 10,
                        };

        if (
            arrWithNumber[0] == arrWithNumber[arrWithNumber.Length - 1] &&
            arrWithNumber[1] == arrWithNumber[arrWithNumber.Length - 2]
            )
        {
            Console.Write("Number is palindrome");
            return true;
        }
        else
        {
            Console.Write("Number is not palindrome");
            return false;
        }
    }
    else
    {
        return false;
    }
}

int number = Prompt("Input five-digit number: ");
IsPal(number);

По-другому можно решить не преобразовывая входные данные в числовой тип и не добавляя их в массив, проверяя на равенство символы строки
*/

/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.Write(result);
*/

/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < N)
{
    Console.Write($"{count * count * count} ");
    count++;
}
*/

