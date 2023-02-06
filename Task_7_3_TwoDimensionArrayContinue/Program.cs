/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4*/

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
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
        {
                for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = rnd.Next(0, 10);
            }
        }   
    return matrix;
}

int [,] GetNewMatrix(int[,] matrix)
{
    // int[,] newmatrix == matrix;
    for (int i = 0; i < matrix.GetLength(0); i = i +2)
        {
                for (int j = 0; j < matrix.GetLength(1); j =  j + 2)
            {
              matrix[i, j] = matrix[i, j] * matrix[i, j];
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

 Console.WriteLine();

int[,] newmatrix = GetNewMatrix(matrix);
PrintMatrix(newmatrix);