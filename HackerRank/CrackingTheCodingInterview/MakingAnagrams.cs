using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.CrackingTheCodingInterview
{
    public class MakingAnagrams
    {
        // https://www.hackerrank.com/challenges/ctci-making-anagrams/problem
        public void Main(String[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.Write(FindAnagrams(a, b));
        }

        public int FindAnagrams(string a, string b)
        {
            // Get the number of occurances of each character in each string.
            var aCharacterOccurances = a.GroupBy(c => c)
                .ToDictionary(grp => grp.Key, grp => grp.Count());

            var bCharacterOccurances = b.GroupBy(c => c)
                .ToDictionary(grp => grp.Key, grp => grp.Count());

            return DifferencesBetween(aCharacterOccurances, bCharacterOccurances);
        }

        private int DifferencesBetween(Dictionary<char, int> a, Dictionary<char, int> b)
        {
            var combinedDict = a.Concat(b)
                .GroupBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Select(y => y.Value));

            var result = combinedDict.Where(x => x.Value.Count() == 1)
                .SelectMany(x => x.Value)
                .Sum();

            result += combinedDict.Where(x => x.Value.Count() > 1)
                .Select(item => item.Value.ToArray())
                .Select(array => Math.Abs(array[0] - array[1]))
                .Sum();
            return result;
        }
    }

}
