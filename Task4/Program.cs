// Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их. 
// Затем найдите минимальное значение по каждой колонке, тоже ссумируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

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

double TotalMax(int[,] matrix)
{
    double sumMax = 0;
    double maxString = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         maxString = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (maxString < matrix[i, j])
            {
                maxString = matrix[i, j];
            }
        }
        System.Console.WriteLine($"Максимально число в {i+1} строке > {maxString}"); // Вывод максимума для проверки
        sumMax = sumMax + maxString;
    }
    System.Console.WriteLine($"Сумма максимумов по строкам > {sumMax}");
    return sumMax;
}

double TotalMin(int[,] matrix)
{
    double sumMin = 0;
    double minColumn = matrix[0, 0];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            minColumn = matrix[0, j];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (minColumn > matrix[i, j])
            {
                minColumn = matrix[i, j];
            }
        }
        System.Console.WriteLine($"Минимальное число в {j+1} столбце > {minColumn}");
        sumMin = sumMin + minColumn;
    }
    System.Console.WriteLine($"Сумма минимумов по столбцам > {sumMin}");
    return sumMin;
}

int[,] array = FillArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array);
double answer = TotalMax(array) - TotalMin(array);
System.Console.WriteLine($"Ответ: {answer}");





