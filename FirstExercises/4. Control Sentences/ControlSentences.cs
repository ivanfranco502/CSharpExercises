using System;

namespace CSharpExercises
{
    public class ControlSentencesExercises
    {
        public void If(){
            // Plantea una condición booleana (puede ser formada por varias condiciones pero siempre el resultado tiene que ser un bool),
            // en caso verdadero ejecuta lo que está dentro
            string[] alumnos = new string[]{ "Nahuel", "Emiliano", "Federico", "Lorena", "Gino", "Florencia L", "Abel", "Florencia M", "Cesar", "Facundo", "Leandro" };

            if(alumnos[0] == "Nahuel"){
                //Es verdadero
            }
        }

        public void IfElse() {
            //Plantea una condición booleana, en el caso que sea verdadera se ejecuta lo que está dentro del bloque if.
            // Aparece un nuevo bloque que se ejecutará en el caso que la condición sea falsa
            string[] alumnos = new string[]{ "Nahuel", "Emiliano", "Federico", "Lorena", "Gino", "Florencia L", "Abel", "Florencia M", "Cesar", "Facundo", "Leandro" };

            if(alumnos[1] == "Nahuel"){
                //Es verdadero
            }else{
                //NO ES NAHUEL
            }
        }

        public void IfElseIf(){
            //Plantea una condición booleana, en el caso que sea verdadera se ejecuta lo que está dentro del bloque if.
            // Aparece un nuevo bloque que se ejecutará en el caso que la condición se cumpla (por tantos else if existan)
            // Y en el caso que ninguna condición se cumpla puede caer en un else
            string[,] alumnos = new string [,] { 
                {"Nahuel", "35"},
                {"Emiliano", "37"},
                {"Federico", "45"},
                {"Lorena", "21"},
                {"Gino", "24"},
                {"Florencia L", "18"},
                {"Abel", "20"},
                {"Florencia M", "27"},
                {"Cesar", "25"},
                {"Facundo", "24"},
                {"Leandro", "26"}
            };
            int edadAlumnoNahuel = Int32.Parse(alumnos[0, 1]);
            if(edadAlumnoNahuel < 25){
                //ENTRA EN EL GRUPO 1
            }else if(edadAlumnoNahuel < 35){
                //Entra en el grupo 2
            }else{
                //Entra en el grupo 3
            }
        }

        public void Switch(){
            // Es una forma más prolija (if elseif) de estructurar lógica para condiciones que permitan más de dos valores posibles
            // Tiene un valor por defecto
            // y se pueden agrupar condiciones
            string[,] alumnos = new string [,] { 
                {"Nahuel", "30"},
                {"Emiliano", "37"},
                {"Federico", "45"},
                {"Lorena", "21"},
                {"Gino", "24"},
                {"Florencia L", "18"},
                {"Abel", "20"},
                {"Florencia M", "27"},
                {"Cesar", "25"},
                {"Facundo", "24"},
                {"Leandro", "26"}
            };
            int edadAlumnoNahuel = Int32.Parse(alumnos[0,1]);
            
            switch(edadAlumnoNahuel){
                case int val when val < 25: 
                    Console.WriteLine("Primer grupo");
                    break;
                case int val when val < 35:
                    Console.WriteLine("Segundo grupo");
                    break;
                default:
                    Console.WriteLine("Tercer grupo");
                    break;
            }
        }

        public void For(){
            //se ejecuta un bloque de instrucciones N veces sin necesidad de repetir código.
            //tiene manejo de índice y se puede decidir cuánto modifica el índice por cada ciclo. Finaliza cuando ya no se cumple la condición
            string[,] alumnos = new string [,] { 
                {"Nahuel", "35"},
                {"Emiliano", "37"},
                {"Federico", "45"},
                {"Lorena", "21"},
                {"Gino", "24"},
                {"Florencia L", "18"},
                {"Abel", "20"},
                {"Florencia M", "27"},
                {"Cesar", "25"},
                {"Facundo", "24"},
                {"Leandro", "26"}
            };

            // for(int index = 0; index < alumnos.GetLength(0); index++){
            //     int edadAlumno = Int32.Parse(alumnos[index, 1]);
            //     if(edadAlumno < 25){
            //         Console.WriteLine("El Alumno {0} entra en el grupo 1", alumnos[index,0]);
            //     }else if(edadAlumno < 35){
            //         Console.WriteLine("El Alumno {0} entra en el grupo 2", alumnos[index,0]);
            //     }else{
            //         Console.WriteLine("El Alumno {0} entra en el grupo 3", alumnos[index,0]);
            //     }
            // }

            for(int index = alumnos.GetLength(0)-1; index >= 0; index--){
                int edadAlumno = Int32.Parse(alumnos[index, 1]);
                if(edadAlumno < 25){
                    Console.WriteLine("El Alumno {0} entra en el grupo 1", alumnos[index,0]);
                }else if(edadAlumno < 35){
                    Console.WriteLine("El Alumno {0} entra en el grupo 2", alumnos[index,0]);
                }else{
                    Console.WriteLine("El Alumno {0} entra en el grupo 3", alumnos[index,0]);
                }
            }
            
        }

        public void While(){
            // Se ejecuta un bloque de instrucciones N veces.
            // no tiene manejo de índice y la validación corre al principio

            string[,] alumnos = new string [,] { 
                {"Nahuel", "35"},
                {"Emiliano", "37"},
                {"Federico", "45"},
                {"Lorena", "21"},
                {"Gino", "24"},
                {"Florencia L", "18"},
                {"Abel", "20"},
                {"Florencia M", "27"},
                {"Cesar", "25"},
                {"Facundo", "24"},
                {"Leandro", "26"}
            };

            int contador = 0;
            while(contador < alumnos.GetLength(0))
            {
                int edadAlumno = Int32.Parse(alumnos[contador, 1]);
                if(edadAlumno < 25){
                    Console.WriteLine("El Alumno {0} entra en el grupo 1", alumnos[contador,0]);
                }else if(edadAlumno < 35){
                    Console.WriteLine("El Alumno {0} entra en el grupo 2", alumnos[contador,0]);
                }else{
                    Console.WriteLine("El Alumno {0} entra en el grupo 3", alumnos[contador,0]);
                }
                contador++;
            }
        }

        public void DoWhile(){
            // En desuso dentro de lo que es .NET, plantea la posibilidad de ejecutar mínimamente una vez el bloque de código.
            // Para luego, evaluar la condición si la cumple y seguir o cortar la ejecución.
                        string[,] alumnos = new string [,] { 
                {"Nahuel", "35"},
                {"Emiliano", "37"},
                {"Federico", "45"},
                {"Lorena", "21"},
                {"Gino", "24"},
                {"Florencia L", "18"},
                {"Abel", "20"},
                {"Florencia M", "27"},
                {"Cesar", "25"},
                {"Facundo", "24"},
                {"Leandro", "26"}
            };

            int contador = 0;
            do
            {
                int edadAlumno = Int32.Parse(alumnos[contador, 1]);
                if(edadAlumno < 25){
                    Console.WriteLine("El Alumno {0} entra en el grupo 1", alumnos[contador,0]);
                }else if(edadAlumno < 35){
                    Console.WriteLine("El Alumno {0} entra en el grupo 2", alumnos[contador,0]);
                }else{
                    Console.WriteLine("El Alumno {0} entra en el grupo 3", alumnos[contador,0]);
                }
                contador++;
            }while(contador < alumnos.GetLength(0));
        }

        public void ForEach(){
            // Es una forma de iterar sobre una conjunto de objetos, hasta que se recorren todos.
            // Se debe indicar el conjunto de objetos y una variable auxiliar para ir asignando cada uno de los objetos por cada iteración.
            Alumno[] alumnos = new Alumno[] { 
                new Alumno {Nombre="Nahuel",      Edad=35},
                new Alumno {Nombre="Emiliano",    Edad=37},
                new Alumno {Nombre="Federico",    Edad=45},
                new Alumno {Nombre="Lorena",      Edad=21},
                new Alumno {Nombre="Gino",        Edad=24},
                new Alumno {Nombre="Florencia L", Edad=18},
                new Alumno {Nombre="Abel",        Edad=20},
                new Alumno {Nombre="Florencia M", Edad=27},
                new Alumno {Nombre="Cesar",       Edad=25},
                new Alumno {Nombre="Facundo",     Edad=24},
                new Alumno {Nombre="Leandro",     Edad=26}
            };

            foreach(var alumno in alumnos){
                 int edadAlumno = alumno.Edad;
                if(edadAlumno < 25){
                    Console.WriteLine("El Alumno {0} entra en el grupo 1", alumno.Nombre);
                }else if(edadAlumno < 35){
                    Console.WriteLine("El Alumno {0} entra en el grupo 2", alumno.Nombre);
                }else{
                    Console.WriteLine("El Alumno {0} entra en el grupo 3", alumno.Nombre);
                
                }
            }

        }
    }

    internal class Alumno
    {
        public string Nombre {get;set;}
        public int Edad {get;set;}
    }
}