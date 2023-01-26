/*Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int[] CreatArray()
{
    int[] newArr = new int[8];
    Random number = new Random();
    for (int i = 0; i < 8; i++)
    {
        newArr[i] = number.Next(0,2);
    }
    return newArr;
}    

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] myArray = CreatArray();
printArray(myArray);