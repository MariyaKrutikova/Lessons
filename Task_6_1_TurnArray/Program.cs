/*Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

int GetDimention(string message)
{
    int result = 0;
    Console.WriteLine(message);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result) & result > 0) break;
        else Console.WriteLine("Некорректные данные. Повторите: ");

    }
    return result;
}

int[] GetArray(int dimention)
{
    int[] array = new int[dimention];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 20);
    }
    return array;
}

int[] TurnArray(int[] array)
{
    int[] turnarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        turnarray[i] = array[array.Length-1-i]; 
    }
    return turnarray;
}

int dimention = GetDimention("Укажите размерность массива: ");
int[] array = GetArray(dimention);
Console.WriteLine(string.Join(", ", array));
int [] turnarray = TurnArray(array);
Console.WriteLine(string.Join(", ", turnarray));
