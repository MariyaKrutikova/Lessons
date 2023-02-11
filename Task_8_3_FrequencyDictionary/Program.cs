/*Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
Илья Василевский: { 1, 9, 9, 0, 2, 8, 0, 9 }
Илья Василевский: 0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза*/

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

int rows = GetNumber("Задайте колличество строк: ");
int columns = GetNumber("Задайте колличество столбцов: ");

int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);

Console.WriteLine();

Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (frequencyDictionary.ContainsKey(matrix[i,j]))
            frequencyDictionary[matrix[i,j]] = frequencyDictionary[matrix[i,j]] + 1;
        else
            frequencyDictionary.Add(matrix[i,j], 1);    
    }
}

foreach (var item in frequencyDictionary.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{item.Key} встречается раз: {item.Value}");
}
