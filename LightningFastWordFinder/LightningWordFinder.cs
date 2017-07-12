using System;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        string longestWord;
        public string GetLongestWord(string text)
        {
            int NumberOfCharactersOfYetLongestWord = 0;
            string[] stringArray = text.Split(new string[] { " ", ".", "?", "!" }, StringSplitOptions.None);
            foreach (string word in stringArray)
            {
                for(int j = 0; j <= word.Length; j++)
                {
                    if (NumberOfCharactersOfYetLongestWord < j)
                    {
                        NumberOfCharactersOfYetLongestWord = word.Length;
                        longestWord = word;
                        break;
                    }
                }
            }
            return longestWord;
        }
    }
}
