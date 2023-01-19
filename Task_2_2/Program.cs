/* Написать программу, которая выводи случайное трехзначное число и удаляет вторую цифру этого числа
456 -> 46
783 -> 73
918 -> 98
*/

//Метод, который вывод случайное трехзначное число
int GetNewNumber(int leftBount, int rightBount)
{
    int result = 0;
    Random rnd = new Random();
    result = rnd.Next(leftBount, rightBount);
    return result;
}

//Метод, который удаляет вторую цифру в трехзначном числе

int DelitSecondNumber(int number)
{
    return (number / 100)*10 + (number % 10);
}

int number = GetNewNumber(100, 999);
Console.WriteLine(number);

int NewNumber = DelitSecondNumber(number);
Console.WriteLine(NewNumber);
