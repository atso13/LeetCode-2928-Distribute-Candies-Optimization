using System;

/* * Solution by: Yarin Bekhor
 * Problem: LeetCode 2928 - Distribute Candies Among Children I
 * * Strategy: Inclusion-Exclusion Principle with Stars and Bars.
 * Complexity: O(1) Time - Constant time regardless of n.
 * O(1) Space - No extra memory used.
 */

namespace LeetCode_2928
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // דוגמאות הרצה לבדיקה
            Console.WriteLine("n=5, limit=2: " + Result(5, 2)); // פלט צפוי: 3
            Console.WriteLine("n=3, limit=3: " + Result(3, 3)); // פלט צפוי: 10
        }

        /// <summary>
        /// Calculates combinations "n choose 2" directly in O(1).
        /// Using long to prevent Integer Overflow during multiplication.
        /// </summary>
        public static long CombinationChoose2(long n)
        {
       
            if (n < 2) return 0;

            return (n * (n - 1)) / 2;
        }

        /// <summary>
        /// Solves the distribution problem using the Inclusion-Exclusion Principle.
        /// </summary>
        public static int Result(int n, int limit)
        {
            
            long total = CombinationChoose2(n + 2);

          
            long oneExceeds = 3 * CombinationChoose2(n - (limit + 1) + 2);

           
            long twoExceed = 3 * CombinationChoose2(n - 2 * (limit + 1) + 2);

            
            long threeExceed = CombinationChoose2(n - 3 * (limit + 1) + 2);

            // התוצאה הסופית לפי עקרון ההכלה וההפרדה
            long finalResult = total - oneExceeds + twoExceed - threeExceed;

            return (int)finalResult;
        }
    }
}