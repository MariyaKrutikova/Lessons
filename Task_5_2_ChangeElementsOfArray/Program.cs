/*Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

int[] GetNewArray(int demention)
{
    int[] array = new int [demention];
    Random rnd = new Random();
    for (int i = 0 ; i < demention; i++)
    {
        array[i] = rnd.Next(-1,2);  
    }
    return array;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}  ");
    }
    Console.WriteLine();
}

int[] changeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

int[] myArray = GetNewArray(4);
PrintArray(myArray);
int[] newArray = changeArray(myArray);
PrintArray(newArray);
