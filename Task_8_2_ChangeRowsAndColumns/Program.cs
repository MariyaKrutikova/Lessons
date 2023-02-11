/*Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result > 0)
            break;
        else
        {
            Console.WriteLine("Некорректные данные. Повторите ввод.");
        }    
    }
    return result;
}

int [,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(0,10);
        }
    }
    return matrix;
}  

int[,] PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]}  ");
            }
            Console.WriteLine();
        }
    return matrix;
}

int[,] ChangeMatrix(int[,] matrix)
{    
    int[,] changematrix = new int [matrix.GetLength(1), matrix.GetLength(0)];
    {
        for (int i = 0; i < changematrix.GetLength(0); i++)
        {
            for (int j =0; j < changematrix.GetLength(1); j++)
            {
                changematrix[i, j] = matrix[j, i];
            }
        }
    } 
    return changematrix;
}

int rows = GetNumber("Задайте количество строк: ");
int columns = GetNumber("Задайте количество столбцов: ");

int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);

Console.WriteLine();

int[,] changematrix = ChangeMatrix(matrix);
PrintMatrix(changematrix);

