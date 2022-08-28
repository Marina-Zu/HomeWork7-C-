// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива по формуле
{
    int[,] matrix = new int[numLine, numColumns];   // Создание нового массива
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = new Random().Next(-10, 10);      // Формула для заполнения массива
        }
    }
    return matrix;      // Возвращаем результат
}

void PrintArray(int[,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]}\t");     // Вывод значений очередной строки 
        }
        Console.WriteLine();    // Переход на следующую строку
    }
}


void FindElement(int[,] array, int line, int column)
{
       for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (line - 1 == i && column - 1 == j)
            {
                System.Console.WriteLine($"Элемент {array[i, j]}");
                return;
            }
        }
    }
    System.Console.WriteLine("Такого элемента нет");
}
int[,] massiv = FillArray(5, 5);
PrintArray(massiv);
System.Console.WriteLine();
int line = Prompt("Введите номер строки > ");
int colum = Prompt("Введите номер столбца > ");
FindElement(massiv, line, colum);




