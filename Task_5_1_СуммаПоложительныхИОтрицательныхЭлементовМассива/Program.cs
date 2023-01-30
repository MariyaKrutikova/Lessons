/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.*/

int GetDemention(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while (true)
    {
       if (int.TryParse(Console.ReadLine(), out result))
       {
            break;
       }
       else
       {
            Console.WriteLine("Некорректный ввод данных. Повторите ввод: ");
       }
    }

    
    return result;
}

int[] GetNewArray(int demention)
{
    int[] newArray = new int [demention];
    Random rnd = new Random();
    for (int i = 0; i < demention; i++)
    {
        newArray[i] = rnd.Next(-9,9);
       // Console.Write($"{newArray[i]}  ");
    }
    return newArray;
}    

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}  ");
    }
    Console.WriteLine();
}
/*
int GetPositivSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int GetNegativSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}*/

(int, int) GetvSumFromArray(int[] array)
{
    int possum = 0;
    int negsum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            possum += array[i];
        }
        else
        {
            negsum += array[i];
        }

    }
    return (possum, negsum);
}

int demention = GetDemention("Задайте размерность массива: ");
int[] myArray = GetNewArray(demention);
PrintArray(myArray);

//int NegSum = GetNegativSum(myArray);
//int PosSum = GetPositivSum(myArray);
//Console.WriteLine($"Сумма положительных элементов масства составляет: {PosSum}");
//Console.WriteLine($"Сумма отлицательных элементов массива составляет: {NegSum}");
(int possum, int negsum) = GetvSumFromArray(myArray);
Console.WriteLine($"Сумма положительных = {possum}");
Console.WriteLine($"Сумма отрицательных = {negsum}");