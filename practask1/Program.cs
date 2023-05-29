using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        string processedString = ProcessString(input);
        Console.WriteLine("Обработанная строка: " + processedString);
    }

    static string ProcessString(string input)
    {
        if (input.Length % 2 == 0)
        {
            // Четное количество символов
            int halfLength = input.Length / 2;
            string substring1 = input.Substring(0, halfLength);
            string substring2 = input.Substring(halfLength);
            string reversedSubstring1 = ReverseString(substring1);
            string reversedSubstring2 = ReverseString(substring2);
            return reversedSubstring1 + reversedSubstring2;
        }
        else
        {
            // Нечетное количество символов
            string reversedInput = ReverseString(input);
            return reversedInput + input;
        }
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
