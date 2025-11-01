
using System.ComponentModel.Design;

namespace Interface_Casting_Operator_Overloading_Static_Extension
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int a)
        {
            if (a % 2 != 0)
            {
                return false;
            }
            return true;
        }
    }
}
