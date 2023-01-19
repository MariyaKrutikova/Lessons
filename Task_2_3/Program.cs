// Напишите программу, которая на вход принмимает два числа и выводить, является ли второе число кратным первому.
// Если нет, то выводить остаток от деления

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int FirstNumber = GetNumber();
int SecondNumber = GetNumber();

if (SecondNumber % FirstNumber == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток - " + (SecondNumber % FirstNumber));
}
