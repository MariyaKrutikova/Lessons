// Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно и 7, и 23

int GetNumber()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine()); 
}

int number = GetNumber();

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"число " + (number) + " кратно и 7, и 23");
}
else
{
    Console.WriteLine($"число " + (number) + " не кратно ни 7, ни 23");
}