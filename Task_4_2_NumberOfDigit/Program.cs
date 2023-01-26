/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int GetNumber(string message)
{
    int result = 0;
     Console.WriteLine(message);
    while(true)
   
    if (int.TryParse(Console.ReadLine(), out result))
    {
        break;
    }
    else
    {
        Console.WriteLine("Нкорректные данные. Повторите ввод: ");
    }
    return Math.Abs(result);
}

void GetLong(int GetNumber)
{
    string GetText = GetNumber.ToString();
    int length = GetText.Length;
    Console.WriteLine($"В веденном числе количество цифр - {length} ");
}

int number = GetNumber("Введите число: ");
GetLong(number);
