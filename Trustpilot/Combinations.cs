using System;
using System.Collections.Generic;
using System.Text;

namespace Trustpilot
{
    public class Combinations
    {
        public static List<(int, int, int)> Numbers(int anagramLength, int maxWordLength)
        {
            var splat = new List<(int, int, int)>();
            for (int i = 1; i <= maxWordLength; i++)
            {
                for (int j = 1; j <= maxWordLength; j++)
                {
                    for (int k = 1; k <= maxWordLength; k++)
                    {
                        if (i + j + k == anagramLength)
                        {
                            splat.Add((i, j, k));
                        }
                    }
                }
            }
            return splat;
        }
    }
}
