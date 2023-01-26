/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result > 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректные данные. Повторите ввод");
        }
    }
    return result;
}


int GetSum(int number)
{
    int i = 0;
    int Sum = 0;
    for (i = 0; i <= number; i++)
    {
        Sum = Sum + i;
    }
   return Sum;
 
}

int number = GetNumber("Введите число: ");
int Sum = GetSum(number);
Console.WriteLine(Sum);
