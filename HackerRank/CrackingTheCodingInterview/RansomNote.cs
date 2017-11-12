using System;
using System.Linq;

namespace HackerRank.CrackingTheCodingInterview
{
    public class RansomNote
    {
        public void Main(String[] args)
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            Console.WriteLine(CanRansomBeMadeFromMagazine(magazine, ransom) ? "Yes" : "No");
        }

        public bool CanRansomBeMadeFromMagazine(string[] magazine, string[] ransom)
        {
            var magazineWords = magazine.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            var ransomWords = ransom.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            return ransomWords.All(x => magazineWords.ContainsKey(x.Key)
                                                     && magazineWords[x.Key] >= x.Value);

            // More readable - maybe more performant.
            /*foreach (var ransomWord in ransomWords)
            {
                var isRansomWordInMagazine = magazineWords.ContainsKey(ransomWord.Key);
                if (!isRansomWordInMagazine)
                {
                    return false;
                }
                if(magazineWords[ransomWord.Key] < ransomWord.Value)
                {
                    return false;
                }
            }
            return true;*/
        }
    }
}