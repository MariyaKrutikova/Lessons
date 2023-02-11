/*адача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7*/

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

(int, int) FindMinimum(int[,] matrix)
{    
    int minimum = matrix[0,0];
    int minRow = 0;
    int minColumn = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minimum) 
            {
                minimum = matrix[i, j];
                minRow = i;
                minColumn = j;
            }    
        }
    }    
    return (minRow, minColumn);
}

int[,] NewMatrix(int[,] matrix, int minRow, int minColumn)
{
    int[,] newmatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == minRow) continue;
            n = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
                {    
                    if (j == minColumn) continue;
                    else
                    {
                        newmatrix[m,n] = matrix[i,j];
                        n++;
                    }   
                }
                m++;     
        }       
    return newmatrix;
}

int rows = GetNumber("Задайте количество строк: ");
int columns = GetNumber("Задайте количество столбцов: ");

int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();

(int minRow, int minColumn) = FindMinimum(matrix);
Console.WriteLine($"{minRow}, {minColumn}");
Console.WriteLine();

int[,] newmatrix = NewMatrix(matrix, minRow, minColumn);
PrintMatrix(newmatrix);

