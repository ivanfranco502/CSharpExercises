using System;

namespace _7.Iteration
{
    public class Solution
    {

        public int solution(string N){
            string valorBinario = N;
            int valorMaximoCeros = 0;
            int contador = 0;

            for(int indice = 0; indice < valorBinario.Length; indice++){
                if(valorBinario[indice] == '0'){
                    contador++;
                }
                else{
                    if(contador > valorMaximoCeros){
                        valorMaximoCeros = contador;
                    }
                    contador = 0;
                }
            }

            return valorMaximoCeros;
        }
    }
    
}