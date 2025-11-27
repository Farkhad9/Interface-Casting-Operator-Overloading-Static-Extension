
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace Interface_Casting_Operator_Overloading_Static_Extension
{
    static class ExtentionMethods
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool IsContainsDigit(string text)
        {
            return text.Any(char.IsDigit);
        }
        public static string ToCapitalize(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }
            else
            {
                return char.ToUpper(text[0]) + text.Substring(1);
            }
        }
        public static int[] GetValueIndexes(string text, char a)
        {
            if (string.IsNullOrEmpty(text))
                return new int[0];

            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == a)
                    count++;
            }

            if (count == 0)
                return new int[0];

            int[] indexes = new int[count];
            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == a)
                    indexes[index++] = i;
            }

            return indexes;
        }

        public static string GetFirstSentence(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }
            char[] sentenceEndings = { '.', '!', '?' };
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == '!' || text[i] == '?')
                {
                    return text.Substring(0, i + 1).Trim();
                }
            }
            return text.Trim();
        }
        public static string GetSecondWord(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return "";
            }
            char bosluq = ' ';
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == bosluq)
                {
                    return sentence.Split(bosluq)[1];
                }
            }
            return "";
        }

    }
}