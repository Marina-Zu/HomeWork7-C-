//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

double [,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива по формуле
{
    double [,] matrix = new double [numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = new Random().Next(-10,10) + new Random().NextDouble();    
        }
    }
    return matrix;
}

void PrintArray(double [,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]:f1}\t");
        }
        Console.WriteLine();
    }
}


double [,] array = FillArray(Prompt("Введите число строк > "),Prompt("Введите число столбцов > "));
PrintArray(array);



