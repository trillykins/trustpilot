using System;
using System.Linq;

namespace Trustpilot
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashes = new[] { "e4820b45d2277f3844eac66c903e84be", "23170acc097c24edb98fc5488ab033fe", "665e5bcb0c20062fe8abaaf4628bb154" };
            var anagram = "poultry outwits ants";
            var anagramLength = anagram.Replace(" ", "").Length;
            var words = Filter.Words(anagram, "wordlist");

            var numbers = Combinations.Numbers(anagramLength, words.Keys.Max());
            foreach (var (i, j, k) in numbers)
            {
                if (!words.TryGetValue(i, out var first)) continue;
                if (!words.TryGetValue(j, out var second)) continue;
                if (!words.TryGetValue(k, out var third)) continue;
                if (Permutations.Words(hashes, first, second, third)) break;
            }
        }
    }
}
