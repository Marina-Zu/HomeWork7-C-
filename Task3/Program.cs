// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива по формуле
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void AverageRow(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        double summ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ = summ + matrix[i, j];
        }
        average = summ / matrix.GetLength(0);
        System.Console.WriteLine($"Среднее арифметическое {j + 1} столбца > {average:f2}");
    }
}

int[,] array = FillArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array);
AverageRow(array);


