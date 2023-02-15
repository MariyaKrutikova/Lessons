/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result > 0)
            break;
        else
        {
            Console.WriteLine("Некорректные данные. Повторите ввод.");
        }    
    }
    return result;
}

int DigitSumRecurtion(int number)
{
    // if (number == 0)
    //     return number;
    // else     
    //     return number % 10 + DigitSumRecurtion(number / 10);

    if (number != 0 )
    {
        int sum = number % 10 + DigitSumRecurtion(number);
        number = number / 10;
    }
    return sum;
}

int number = GetNumber("Введите число");
int sum = DigitSumRecurtion(number);
Console.WriteLine(sum);