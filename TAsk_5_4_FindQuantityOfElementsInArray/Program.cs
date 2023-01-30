/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int[] GetNewArray(int dimention)
{
    int[] array = new int[dimention];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 1000);
    }
    return array;
}

int FindQuantityOfElements(int[] array)
{
        int count = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] <100)
        {count = count + 1;}
    }
    return count;
}

int[] myArray = GetNewArray(15);
Console.WriteLine(string.Join(", ", myArray));
int count = FindQuantityOfElements(myArray);
Console.WriteLine($"В массиве {count} элементов, лежащих в отрезеке [10,99]");