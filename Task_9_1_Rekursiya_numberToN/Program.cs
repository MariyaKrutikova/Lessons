/* Задача 63. Задайте N. Напишите программу, которая выведет все натуральные числа от 1 до N*/

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


void Recursion(int N, int number)
{
     if (number <= N) 
    {
        Console.Write($"{number} ");
        number++;
        Recursion(N, number);
    }

}

int N = GetNumber("Введите число");
Recursion(N, 0);


