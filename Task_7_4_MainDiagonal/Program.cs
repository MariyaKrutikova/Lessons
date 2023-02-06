/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

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

int GetSumOfNumbersOnMaunDiagonal(int[,] matrix)
{
    int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
                for (int j = 0; j < matrix.GetLength(1); j++)
            {
              if ( i == j) sum = sum + matrix[i, j];
            }
        }   
    return sum;
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

int sum = GetSumOfNumbersOnMaunDiagonal(matrix);
Console.WriteLine($"Сумма элементов на главной диагонали составляет: {sum}");
