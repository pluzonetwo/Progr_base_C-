/* Task 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int ShowTens(int inputNumber)
{
    return inputNumber % 100 / 10;
}

Console.Write("Input three digit number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 99 && userNumber < 1000)
{
    Console.Write($"Second digit is {ShowTens(userNumber)}");
}
else Console.Write("Input three digit number!");
*/

/* Task 2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int currentNumber = 949164;

void thirdNum(int number)
{
    if (number < 100) Console.Write("Третьей цифры нет");
    else
    {
        while (number > 1000)
        {
            number = number / 10;
        }

        number = number % 10;

        Console.Write($"Третья цифра {number}");
    }

}

thirdNum(currentNumber);
*/

/* Task 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool isWeekend(int numOfDay)
{
    if (numOfDay == 6 || numOfDay == 7) return true;
    else return false;
}

int dayOfWeek = 7;

if (isWeekend(dayOfWeek)) Console.Write("Да");
else Console.Write("Нет");
*/