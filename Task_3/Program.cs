/*
Задача:
Задайте произвольную строку.
Выясните, является ли она палиндромом.
*/
void Main()
{
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
Console.InputEncoding = System.Text.Encoding.GetEncoding(1251);

Console.Write("Введите слово: ");
string? input = Console.ReadLine();
string temp = input!;

int polindromFalse = 0;
int a = input!.Length - 1;

for (int i = 0; i < input.Length / 2; i++)
{
    if (input[i] == temp[a])
        a--;
    else
    {
        polindromFalse += 1;
        a--;
    }
}
if (polindromFalse > 0)
    Console.WriteLine("Слово не является палиндромом");
else
    Console.WriteLine("Это палиндром");
}
Main();