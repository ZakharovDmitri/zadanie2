using System;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Целое число, количество слов в наборе S
            int m = int.Parse(Console.ReadLine());
            // Заполнение массива словами из набора S
            string[] words = new string[m];
            for (int i = 0; i < m; i++)
            {
                words[i] = Console.ReadLine();
            }
            int maxLength = 0;
            int countPrefixes = 0;
            for (int i = 1; i < m; i++)
            {
                // Разбиваем на символы текущее слово
                char[] word = words[i].ToCharArray();
                for (int j = 0; j < i; j++)
                {
                    // Разбиваем на символы одно из предыдущих слов
                    char[] preWord = words[j].ToCharArray();
                    if (preWord.Length <= word.Length)
                    {
                        bool prefix = true;
                        for (int k = 0; k < preWord.Length; k++)
                        {
                            if (preWord[k] == word[k])
                            {
                                // Слово может являться префиксом
                            }
                            else
                            {
                                // Буква не совпадает, слово не является префиксомprefix = false;
                                prefix = false;
                                countPrefixes = 1;
                                k = preWord.Length;
                            }
                        }
                        if (prefix == true)
                        {
                            countPrefixes++;
                        }
                    }
                    else
                    {
                        // Если предыдущее слово длиннее текущего, оно не может быть собственным префиксом текущего слова
                        countPrefixes = 1;
                    }
                    // Сюда изменение максимума если считать префиксы даже если они идут не подряд
                    
                }
                // Сюда изменение максимума если считать префиксы только если они идут подряд
                if (countPrefixes > maxLength) maxLength = countPrefixes;
                countPrefixes = 1;
            }
            Console.WriteLine(maxLength);
        }
    }
}
