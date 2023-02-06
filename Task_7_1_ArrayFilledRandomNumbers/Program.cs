/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод данных. Повторите ввод!");
        }
    }
    return result;
}

int [,] GetMatrix(int rows, int columns)
{
    int[,] matrix =  new int [rows, columns];
    Random number = new Random();
    for (int i = 0; i < rows; i++)
        {
                for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = number.Next(0,11);
            }
        }   
    return matrix;
}

int[,] PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        {
                for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]}  ");
            }
            Console.WriteLine();  
        }
     return matrix;
}

int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);