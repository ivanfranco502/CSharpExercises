using System;

namespace CSharpExercises
{
    public class VariableExercises {

        public void Concatenate(){
            Console.WriteLine("Ingrese el nombre: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido:");
            string lastname = Console.ReadLine();

            Console.WriteLine("El nombre ingresado antes de llamar a la función que muestra el nombre con exclamación: {0}", firstname);
            // ShowNameWithExclamationByRef(ref firstname);
            ShowNameWithExclamationByVal(firstname);
            Console.WriteLine("El nombre ingresado después de llamar a la función que muestra el nombre exclamación: {0}", firstname);
        }
        private void ShowNameWithExclamationByRef(ref string firstText)
        {
            firstText = firstText + "!!!";
            Console.WriteLine("El nombre ingresado es: {0}", firstText);
        }

        private void ShowNameWithExclamationByVal(string firstText)
        {
            firstText = firstText + "!!!";
            Console.WriteLine("El nombre ingresado es: {0}", firstText);
        }
    }
}