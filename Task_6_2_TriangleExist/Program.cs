/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.*/

int GetNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result) & result > 0) break;
        else Console.WriteLine("Данные введены некорректно. Повторите ввод: ");
    }
    return result;
}
bool ExistTriangle(int number1, int number2, int number3)
{
    bool a = false;
    if (number1 < number2 + number3 & number2 < number1 + number3 & number3 < number2 + number1) a = true;
    return a;
}

int number1 = GetNumber("Введите первое число: ");
int number2 = GetNumber("Введите второе число: ");
int number3 = GetNumber("Введите третье число: ");

bool a = ExistTriangle(number1, number2, number3);
if (a) Console.WriteLine("Треугольник с такими сторонами существует");
else Console.WriteLine("Треугольник с такими сторонами не существует");
