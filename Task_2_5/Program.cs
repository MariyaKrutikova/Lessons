/* Напишиите программу, которая на вход принимает два числа и проверяет, 
является ли одно число, квадратом второго */

int GetNewNumber()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int FirstNumber = GetNewNumber();
int SecondNumber = GetNewNumber();

if (FirstNumber*FirstNumber == SecondNumber | SecondNumber*SecondNumber == FirstNumber)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}