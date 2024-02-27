/*
Задача:
Задайте двумерный массив символов (тип char [,]).
Создать строку из символов этого массива.
*/

void Main()
{
    Console.Write("Введите количество строк: ");
    int Rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int Columns = Convert.ToInt32(Console.ReadLine());

    char[,] matrix = CreateCharArray(Rows, Columns);
    PrintArray(matrix);

    string ElementsMatrix = "";
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            ElementsMatrix += matrix[i,j]; 
        }

    }
    
    Console.WriteLine($"Строка значений массива: {ElementsMatrix}");

    char[,] CreateCharArray(int Rows, int Columns)
    {
        char[,] charMatrix = new char[Rows, Columns];
        Random rnd = new Random();

        for (int i = 0; i < charMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < charMatrix.GetLength(1); j++)
            {
                charMatrix[i, j] = (char)rnd.Next('a', 'z' + 1);
            }

        }
        return charMatrix;
    }

    void PrintArray(char[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
Main();