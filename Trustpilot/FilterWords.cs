using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Trustpilot
{
    public static class Filter
    {
        public static Dictionary<int, List<string>> Words(string anagram, string fileLocation)
        {
            if (!File.Exists(fileLocation)) throw new FileNotFoundException($"File '{fileLocation}' not found!");

            var result = new Dictionary<int, List<string>>();
            var anagramCharCounts = anagram.Replace(" ", "").GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            foreach (var word in File.ReadAllLines(fileLocation))
            {
                if (!word.All(x => anagram.Contains(x))) continue;
                if (anagramCharCounts.Any(x => word.Count(y => y == x.Key) > x.Value)) continue;
                if (result.TryGetValue(word.Length, out var value))
                {
                    value.Add(word);
                }
                else
                {
                    result.Add(word.Length, new List<string> { word });
                }
            }
            return result;
        }
    }
}
