using System;

namespace _9.CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] array = new[]{3, 8, 9, 7, 6};
            Console.WriteLine($"Result: {sol.solution(array, 3)}");
        }
    }
}
