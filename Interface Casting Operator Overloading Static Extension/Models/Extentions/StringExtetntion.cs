namespace Interface_Casting_Operator_Overloading_Static_Extension.Models.Extentions
{
    internal static class StringExtetntion
    {
        public static int MatchCount(this string sentence, string word)
        {
            if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(word))
            { 
            return 0;
            }

            int count = 0;
            int index = 0;
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var tekrar in words)
            {
                if (tekrar == word)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
