/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbers(int N)
{

    if (N == 0) return;

    ShowNumbers(N - 1);
    Console.Write($"{N} ");

}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);
*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int SumElInInterval(int M, int N)
{
    if (M == N) return M;
    else return N + SumElInInterval(M, N - 1);
}

Console.Write("Input the beginning of the interval: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the end of the interval: ");
int end = Convert.ToInt32(Console.ReadLine());
int result = SumElInInterval(start, end);

Console.Write($"Sum of elements in interval {start}, {end} = {result}");
*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

int Accerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Accerman(m - 1, 1);
    else if (m > 0 && n > 0) return Accerman(m - 1, Accerman(m, n - 1));
    else return 0;
}

Console.Write("Input number 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Accerman(m, n);

Console.Write($"{result}");
*/