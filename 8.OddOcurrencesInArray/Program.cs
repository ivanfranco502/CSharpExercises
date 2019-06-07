using System;

namespace _8.OddOcurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] array = new[]{9,3,9,3,9,7,9};
            Console.WriteLine($"Result: {sol.solution(array)}");
            array = new[]{9,9,7,3,3};
            Console.WriteLine($"Result: {sol.solution(array)}");
            array = new[]{9,9,9,5,7,7,3,3};
            Console.WriteLine($"Result: {sol.solution(array)}");
        }
    }
}
