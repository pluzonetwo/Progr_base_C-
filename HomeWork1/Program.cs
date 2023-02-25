/* Task 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number 1: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
    Console.Write($"More number {firstNum}, Less number {secondNum}");
}
else
{
    Console.Write($"More number {secondNum}, Less number {firstNum}");
}
*/

/* Task 2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int maxNumber = 0;

Console.Write("Input number 1: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 3: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > maxNumber) maxNumber = firstNumber;
if (secondNumber > maxNumber) maxNumber = secondNumber;
if (thirdNumber > maxNumber) maxNumber = thirdNumber;

Console.Write($"Max number: {maxNumber}");
*/

/* Task 3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.Write($"Number {num} is even number");
else Console.Write($"Number {num} is odd number");
*/