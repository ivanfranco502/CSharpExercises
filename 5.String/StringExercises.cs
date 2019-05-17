using System;

namespace CSharpExercises{
    public class StringExercises {
        
        public void HandleString(){
            string cadena = "hola " + "mundo";
            string cadena1 = "hola mun" + "do";

            for(int i = 0; i < cadena.Length; i ++){
                Console.WriteLine(cadena[i]);
            }
        }
    }
}