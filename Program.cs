using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Заданий текст
        string text = @"
            Інформатика - це наука про інформацію.
            Інформатика важлива для розвитку технологій.
            Математика і інформатика взаємопов'язані.
            Фізика також пов'язана з технологіями.
            Інформатика як предмет викладається у школах.
        ";

        // Регулярний вираз для пошуку рядків, які починаються зі слова "Інформатика"
        string pattern = @"^\s*Інформатика\b";

        // Пошук за допомогою регулярного виразу
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.Multiline);

        // Виведення результатів
        Console.WriteLine($"Кількість рядків, які починаються зі слова 'Інформатика': {matches.Count}");
        Console.WriteLine("Рядки:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.Trim());
        }
    }
}
