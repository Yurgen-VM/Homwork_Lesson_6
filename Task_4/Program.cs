/*
Задача:
Задайте строку, состоящую из слов, разделенных пробелами.
Сформировать строку, в которой слова расположены в обратном порядке.
В полученной строке слова должны быть также разделены пробелами.
*/

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
Console.InputEncoding = System.Text.Encoding.GetEncoding(1251);

Console.WriteLine("Напишите предложение, состоящее из нескольких слов, и мы его развернем:");
string? str = Console.ReadLine();
int countSpace = 0;

for (int i = 0; i < str!.Length; i++) // Счтаем количество пробелов предложении
{
    if (str[i] == ' ')
        countSpace++;
}

if (countSpace == 0)
    Console.WriteLine("Ваше предложение не содержит пробелов. Попробуйте заново!");

else
{
    string[] arrayWords = new string[countSpace + 1]; // Создаем массив из слов входящих в предложение
    string newStr = "";
    int arrayIndex = 0;

    for (int j = 0; j < str.Length; j++)
    {
        if (str[j] != ' ')
            newStr += str[j];
        else
        {
            arrayWords[arrayIndex] = newStr;
            arrayIndex++;
            newStr = "";
        }
    }
    if (!string.IsNullOrEmpty(newStr))
        arrayWords[arrayIndex] = newStr;
    
    string[] ReversArrayWords = new string[arrayWords.Length]; // Разворачиваем массив из слов
    for (int i = 0; i < arrayWords.Length; i++)
        ReversArrayWords[i] = arrayWords[arrayWords.Length - 1 - i];

    char sep = ' ';
    string ReversStr = string.Join(sep, ReversArrayWords); // Преобразовываем массив в строку
    Console.WriteLine("Ваше предложение развернутое в обратную сторону:");
    Console.WriteLine(ReversStr);
}