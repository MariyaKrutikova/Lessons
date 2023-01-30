/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] GetNewArray(int dimention)
{
    int[] array = new int[dimention];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 16);
    }
    return array;
}

int[] Multarray(int[] array)
{
    int[] newArray = null;
    bool chetniy = true;
    if (array.Length % 2 == 0)
    {
        newArray = new int[array.Length/2];
    }
    else
    {
        newArray = new int[array.Length/2 + 1];
        chetniy = false;
    }
    for (int i = 0; i < newArray.Length; i++)
    {
        if (!chetniy && i == newArray.Length - 1)
            newArray[i] = array[i];
        else
            newArray[i] = array[i] * array[array.Length - i - 1];
    }
        return newArray;
}

int [] array = GetNewArray(6);
Console.WriteLine(string.Join(", ", array));
int [] newArray = Multarray(array);
Console.WriteLine(string.Join(", ", newArray));