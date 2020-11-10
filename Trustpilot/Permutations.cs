using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trustpilot
{
    public static class Permutations
    {
        public static bool Words(string[] hashes, ICollection<string> first, ICollection<string> second, ICollection<string> third)
        {
            foreach (var firstWord in first)
            {
                foreach (var secondWord in second)
                {
                    foreach (var thirdWord in third)
                    {
                        var sentence = $"{firstWord} {secondWord} {thirdWord}";
                        var md5 = MD5.Create(sentence);
                        if (hashes.Any(x => x == md5))
                        {
                            Console.WriteLine($"Solution to '{md5}' is: '{sentence}'");
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
