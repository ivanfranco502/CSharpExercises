using System;

namespace _9.CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            // int[] array = new[]{3, 8, 9, 7, 6};
            // Console.WriteLine($"Result: {sol.solution(array, 3)}");

            int[] array = new[]{9,5,4};
            Console.WriteLine($"Inicio:{DateTime.Now.ToString("ss.fff")}");
            int[] result = sol.solution(array, 4);
            for(int i=0; i < array.Length; i++){
                Console.Write($"{result[i]}, ");
            }
            Console.WriteLine($"Fin:{DateTime.Now.ToString("ss.fff")}");
            Console.ReadLine();
        }
    }
}
