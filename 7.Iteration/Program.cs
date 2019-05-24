using System;

namespace _7.Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int valor = 1041;
            Console.WriteLine($"Valor ingresado:{valor} - Valor Binario:{Convert.ToString(valor,2)}");
            Console.WriteLine($"Resultado mayor cantidad de ceros consecutivos: {sol.solution(valor)}");
            valor = 0;
            Console.WriteLine($"Valor ingresado:{valor} - Valor Binario:{Convert.ToString(valor,2)}");
            Console.WriteLine($"Resultado mayor cantidad de ceros consecutivos: {sol.solution(valor)}");
            valor = 1283403;
            Console.WriteLine($"Valor ingresado:{valor} - Valor Binario:{Convert.ToString(valor,2)}");
            Console.WriteLine($"Resultado mayor cantidad de ceros consecutivos: {sol.solution(valor)}");
            valor = 8;
            Console.WriteLine($"Valor ingresado:{valor} - Valor Binario:{Convert.ToString(valor,2)}");
            Console.WriteLine($"Resultado mayor cantidad de ceros consecutivos: {sol.solution(valor)}");

            Console.Read();
        }
    }
}
