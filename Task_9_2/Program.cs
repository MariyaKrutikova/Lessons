/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

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

// void Recursion(int M, int N)
// {
//     if (M <= N)
//     {
//         Console.Write($"{M} ");
//         M++;
//         Recursion(M, N);
//     }
// }

string NumberRec (int m, int n)
{
if (m < n) return $"{m}, " + NumberRec (m+1, n);
else return String.Empty;
}

int M = GetNumber("Введите первое число");
int N = GetNumber("Введите второе число");

if (N < M)
{
    Console.WriteLine("Введите числа снова");
}
else
    Console.WriteLine ($"{NumberRec(M, N)}{N}");


