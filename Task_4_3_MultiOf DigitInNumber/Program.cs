/*адача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

int GetNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;        
        }
        else
        {
            Console.WriteLine("Введены некорректные данные. Повторите ввод!");
        }
    }   
    return Math.Abs(result);
}

int MultiplyNumber(int number)
{
    int Multiply = 1;
    for (int i = 1; i <= number; i++)
    {
        Multiply = Multiply*i;
    }
    return Multiply;
}
    
int number = GetNumber("Введите число: ");
int Multiply = MultiplyNumber(number);
Console.WriteLine(Multiply);


