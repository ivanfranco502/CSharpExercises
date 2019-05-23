using System;

namespace CSharpExercises{
    public class DataTypeExercises{
        public void ValueSum(){
            Console.WriteLine("Ingrese un valor a sumar:");
            string firstValue = Console.ReadLine();

            Console.WriteLine("Ingrese otro valor a sumar:");
            string secondValue = Console.ReadLine();


            int first = 0;
            bool couldParseFirst = Int32.TryParse(firstValue, out first);
            if(couldParseFirst){
                int second = 0;
                bool couldParseSecond = Int32.TryParse(secondValue, out second);

                if(couldParseSecond){
                    Console.WriteLine("El resultado de la suma es: {0}", first + second);
                }else{
                    Console.WriteLine("El segundo parámetro está mal formateado");    
                }
            }else{
                Console.WriteLine("El primer parámetro está mal formateado");
            }
        }
    }
}