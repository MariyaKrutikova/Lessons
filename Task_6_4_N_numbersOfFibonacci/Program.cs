/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

int GetNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result) & result > 1) break;
        else Console.WriteLine("Некорректные данные. Повторите ввод");
    }
    return result;
}

int[] Febonacci(int number)
{
    int[] Feb = new int[number];
    if (number == 0) 
    return new int[1] {0};
    if (number == 1) 
    return new int[2] {0, 1};

    Feb[0] = 0;
    Feb[1] = 1;
    for (int i = 2; i < number; i++)
    {
        Feb[i] = Feb[i-1] + Feb[i-2];
    }
    return Feb;
}

int number = GetNumber("Введите число: ");
int[] Feb = Febonacci(number);
int[] reversFeb = Feb.Reverse().ToArray();
Console.WriteLine(string.Join(", ", Feb));
Console.WriteLine(string.Join(", ", reversFeb));
