/* Напишите програииу, которая выводит случайное число из отрезка (10, 99) и покажите наибольшую цифру числа.

78 -> 8
12 -> 2
85 -> 8
*/
// метод, который получает случайное число
int GetRandomNumber(int leftBount, int rightBount)
{
    int result = 0;
    Random rnd = new Random();
    result = rnd.Next(leftBount, rightBount+1);
    return result;
}

// Метод, который получает максимальную цифру числа
int GetMaxDigitOfNumber(int number)
{
    int FirstDigit = number / 10;
    int SecondDigit = number % 10;
    if (FirstDigit > SecondDigit)
        return FirstDigit;
    else
        return SecondDigit;
        }

        int number = GetRandomNumber(10,99);
        int max = GetMaxDigitOfNumber(number);

        Console.WriteLine(number);
        Console.WriteLine("Максимальная цифра в числе - " + max);