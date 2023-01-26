/*Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/

int GetNumber(string message) 
{ 
    int result  = 0;
    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
            {
                        break;
                }
            else 
                {
                    Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
                }
        } 
    return resultNumber;
}

int GetSuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else 
        return 4;
}

int x = GetNumber("Введите координату Х, которая не равна 0: ");
int y = GetNumber("Введите координату Y, которая не равна 0: ");
int qarter = GetSuarter(x, y);

Console.WriteLine($"Точка с координатой ({x},{y}) лежит в {qarter} четверти");