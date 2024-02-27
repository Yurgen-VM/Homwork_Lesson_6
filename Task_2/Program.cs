/*
Задача:
Задайте строку, содержащую латинские буквы в обоих регистрах.
Сформируйте строку, в которой все заглавные буквы заменены на строчные.
*/

using System.IO.Compression;

void Main()
{
    Console.Write("Введите длину строки: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string input = GenerateString(size);
    Console.WriteLine($"Случайная сгенерированная строка: {input}");

    string newStr = "";
    for (int i = 0; i < input.Length; i++)
    {
        if (char.IsLower(input[i]))
            newStr += input[i];
        else
            newStr += char.ToLower(input[i]);        
    }
    Console.WriteLine($"Преобразование в нижний регистр:  {newStr}");


    // Функции:

    string GenerateString(int size) // Генерация случайной строки из латинских строчных и заглавных букв
    {
        Random random = new();
        string str = "";

        for (int i = 0; i < size; i++)
        {
            char rndChar = random.Next(0, 2) == 0 ? GenerateRndSmallSimbol() : GenerateRndBigSimbol();
            str += rndChar;
        }
        return str;
    }

    char GenerateRndSmallSimbol() // Генерация случайной строчной латинской буквы
    {
        Random random = new();
        char smallSymbol = (char)random.Next('a', 'z' + 1);
        return smallSymbol;
    }

    char GenerateRndBigSimbol() // Генерация случайной заглавной латинской буквы
    {
        Random random = new();
        char bigSymbol = (char)random.Next('A', 'Z' + 1);
        return bigSymbol;
    }

}
Main();
