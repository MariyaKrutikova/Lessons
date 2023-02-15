/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

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

int FindPower(int A, int B)
{
    if (B == 0)
        return A;
    else
    {
        return A * FindPower(A, B-1);
    }
}


int A = GetNumber("Введите первое число");
int B = GetNumber("Введите второе число");

int result = FindPower(A, B);
Console.WriteLine(result);