using minutoseguro.cli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace minutoseguro.cli.Code
{
    public static class WordsCounter
    {
        public static SummaryViewModel GetSummary(string topic)
        {
            string[] exclusions = {
                "o", "a", "à", "ao", "os", "as", "às", "aos",
                "e", "é", "ou",
                "da", "de", "do", "das", "dos",
                "com", "no", "nos", "na", "nas",
                "em", "um", "uma", "uns", "umas",
                "esse", "este", "aquele", "isso", "isto", "aquilo",
                "ante", "após", "até", "contra", "desde",
                "entre", "para", "perante", "por",
                "sem", "sob", "sobre", "trás",
                "que", "qual", "quão",
                "seu", "seus", "sua", "suas", "como", "mais", "ser"
            };

            var result = new SummaryViewModel();
            topic = topic.Replace("\n", string.Empty);
            topic = Regex.Replace(topic, "<.*?>", String.Empty);
            topic = new string(topic.Where(c => !char.IsPunctuation(c)).ToArray());

            foreach (string word in topic.Split(' ').Where(w => !exclusions.Contains(w.ToLower()) && !string.IsNullOrEmpty(w)))
            {
                var currentWord = result.Words.Find(w => w.Value.Contains(word, StringComparison.InvariantCultureIgnoreCase));

                if (currentWord != null)
                {
                    currentWord.Occurrences++;
                } else
                {
                    result.Words.Add(new WordViewModel() {
                        Value = word.ToLower(),
                        Occurrences = 1
                    });
                }

                result.QtdWords++;
            }

            if (result.Words.Count > 0)
            {
                result.Words = result.Words.OrderByDescending(w => w.Occurrences).Take(10).ToList();
            }

            return result;
        }


    }
}
