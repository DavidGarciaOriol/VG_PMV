using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinPMV
{
    internal class Ej4
    {

        // 1. Cree un HashSet para almacenar los nombres de estudiantes en una clase.
        // 2. Añade los siguientes estudiantes: "Ana", "Juan", "Pedro", "Lucía".
        // 3. Intenta añadir a "Ana" de nuevo al HashSet y explica qué ocurre.
        // 4. Imprime todos los nombres de estudiantes.
        // 5. Comprueba si el estudiante "Lucía" está en el conjunto.
        // 6. Elimina a "Pedro" del conjunto.
        // 7. Vuelve a imprimir el conjunto de estudiantes.

        private HashSet<string> nombres;

        public Ej4(HashSet<string> nombres) 
        {
            this.nombres = nombres;
        }

        public HashSet<string> Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public void AgregarEstudiante(string nombre)
        {
            bool agregado = nombres.Add(nombre);

            if (agregado) 
            {
                Console.WriteLine($"Estudiante \"{nombre}\" agregado correctamente");
            }
            else
            {
                Console.WriteLine($"Estudiante duplicado \"{nombre}\". No se ha realizado ninguna acción.");
            }
        }

        public void ComprobarEstudiante(string nombre)
        {
            if (nombres.Contains(nombre)) 
            {
                Console.WriteLine($"El estudiante especificado \"{nombre}\" SÍ se encuentra en la lista.");
            }
            else
            {
                Console.WriteLine($"El estudiante especificado \"{nombre}\" NO se encuentra en la lista.");
            }
        }

        public void EliminarEstudiante(string nombre)
        {
            if (nombres.Contains(nombre))
            {
                nombres.Remove(nombre);
                Console.WriteLine($"Estudiante \"{nombre}\" eliminado correctamente.");
            }
            else
            {
                Console.WriteLine($"El estudiante especificado \"{nombre}\" no se encuentra en la lista. No se ha realizado ninguna acción.");
            }
        }

        public override string ToString()
        {
            string output = "";

            output = string.Join(", ", nombres);

            return output;
        }

    }
}
