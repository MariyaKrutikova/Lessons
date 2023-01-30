/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

int[] GetNewArray(int demention)
{
    int[] array = new int[demention];
    Random rnd = new Random();
    for (int i = 0; i < demention; i++)
    {
        array[i] = rnd.Next(0,10);
    }
    return array;
}

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}  ");
//     }
// }

    
bool FindNumber(int find, int[] array)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
       if (find == array[i])
       {
            result = true;
            break;
       } 
    } 
    return result;
}

int[] myArray = GetNewArray(15);
Console.WriteLine("Что ищем?");
int find = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Join(", ", myArray));
bool a = FindNumber(find, myArray);
if (a) Console.WriteLine("Число есть в массиве");
else Console.WriteLine("Числа нет в массиве");