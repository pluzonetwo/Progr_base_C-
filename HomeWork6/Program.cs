// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

double Prompt(string userMessage)
{
    Console.Write(userMessage);
    double result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool QuestionToUser()
{
    Console.WriteLine("Do you want input another number?");
    string question = Console.ReadLine();

    if (question == "yes".ToLower() || question == "y".ToLower())
    {
        return true;
    }
    else
    {
        return false;
    }
}

double[] FillArray(double number)
{
    int quantityArrEl = 1;
    double[] numbers = new double[quantityArrEl];

    numbers[0] = number;

    if (QuestionToUser())
    {
        quantityArrEl++;
        number = Prompt("Input a number: ");
        numbers[quantityArrEl + 1] = number;
        QuestionToUser();
    }

    return numbers;
}

int greaterThanZero(double[] someArr)
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

double number = Prompt("Input a number: ");

double[] numbers = FillArray(number);
int result = greaterThanZero(numbers);

Console.WriteLine($"Input numbers: [{string.Join(", ", numbers)}]");
Console.Write($"Quantity numbers greater than zero: {result}");

