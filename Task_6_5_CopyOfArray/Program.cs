/*Задача 45: Напишите программу, 
которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

int[] GetArray(int dimention)
{
    int[] array = new int[dimention];
    Random rnd  = new Random();
    for (int i = 0; i < dimention; i++)
    {
        array[i] = rnd.Next(0, 21);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] copyarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyarray[i] = array[i];
    }
    return copyarray;    
}

int[] array = GetArray(5);
Console.WriteLine(string.Join(", ", array));

int[] copyarray = CopyArray(array);
Console.WriteLine(string.Join(", ", copyarray));
