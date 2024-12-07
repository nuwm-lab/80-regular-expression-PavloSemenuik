using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    // Константа для зберігання тексту
    private const string InputText = @"
        Інформатика - це наука про інформацію.
        Інформатика важлива для розвитку технологій.
        Математика і інформатика взаємопов'язані.
        Фізика також пов'язана з технологіями.
        Інформатика як предмет викладається у школах.
    ";

    static void Main()
    {
        // Визначаємо кількість рядків та їх вміст
        var results = FindLinesStartingWithWord(InputText, "Інформатика");

        // Виводимо кількість рядків
        Console.WriteLine($"Кiлькiсть рядкiв, якi починаються зi слова 'iнформатика': {results.Count}");

        // Виводимо рядки
        Console.WriteLine("Рядки:");
        foreach (var line in results)
        {
            Console.WriteLine(line);
        }
    }

    /// <summary>
    /// Знаходить рядки, які починаються з певного слова.
    /// </summary>
    /// <param name="text">Вхідний текст.</param>
    /// <param name="word">Слово, з якого мають починатися рядки.</param>
    /// <returns>Список рядків, які відповідають критерію.</returns>
    private static List<string> FindLinesStartingWithWord(string text, string word)
    {
        // Регулярний вираз для пошуку рядків, що починаються зі слова
        string pattern = @$"^\s*{Regex.Escape(word)}\b";

        // Результати зберігаємо у список
        var matchedLines = new List<string>();

        // Розділяємо текст на рядки
        var lines = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var line in lines)
        {
            if (Regex.IsMatch(line, pattern))
            {
                matchedLines.Add(line.Trim());
            }
        }

        return matchedLines;
    }
}
