using System;

namespace CSharpExercises{
    public class ConsoleExercises {
        public void AskAge(){
            Console.WriteLine("¿Cuántos años tenes?: ");
            string age = Console.ReadLine();
            Console.WriteLine("Wow, no pareces de " + age + " años");
            Console.WriteLine("nombre");
            string firtName = Console.ReadLine();
            Console.WriteLine("Apellido");
            string lastName = Console.ReadLine();
            Console.WriteLine("Documento");
            string documentNumber = Console.ReadLine();
            Console.WriteLine("Nombre {0}", firtName);
            Console.WriteLine("Apellido {0}", lastName);
            Console.WriteLine("Documento {0}", documentNumber);
            Console.ReadLine();
        }
    }
}