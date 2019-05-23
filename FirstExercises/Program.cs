using System;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese opción:");
            string opcion = Console.ReadLine();
            switch(opcion)
            {
                case "1":
                    //1.
                    ConsoleExercises console = new ConsoleExercises();
                    console.AskAge();
                    break;

                //Pedir nombre, apellido y documento e imprimir toda la información al final.
                case "2":
                    //2.
                    VariableExercises variable = new VariableExercises();
                    variable.Concatenate();
                    break;                
                
                case "3":
                    //3.
                    DataTypeExercises dataType = new DataTypeExercises();
                    dataType.ValueSum();
                    break;
                
                case "4":
                    //4. 
                    ControlSentencesExercises control = new ControlSentencesExercises();
                    control.Switch();
                    break;

                case "5":
                    StringExercises cadenaTexto = new StringExercises();
                    cadenaTexto.HandleString();
                    break;
                
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
        }
    }
}
