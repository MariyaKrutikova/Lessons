/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

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
    for (int i = 0; i < rows; i++)
        {
                for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = i + j;
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