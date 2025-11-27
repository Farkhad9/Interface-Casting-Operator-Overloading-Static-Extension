

namespace Interface_Casting_Operator_Overloading_Static_Extension.Models.Extentions
{
    internal static class IntExtention
    {
        public static bool Polindrome(this int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                number /= 10;
            }
            return originalNumber == reversedNumber;
        }
    }
}
