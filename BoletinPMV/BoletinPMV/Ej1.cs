using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinPMV
{
    internal class Ej1
    {
        // 1. Crea un array de enteros con 5 posiciones.
        // 2. Rellena el array con los valores 10, 20, 30, 40, 50.
        // 3. Imprime por consola el contenido del array.
        // 4. Modifica el valor de la tercera posición para que sea 35.
        // 5. Vuelve a imprimir el array.
        // 6. Calcula e imprime la suma de todos los valores del array

        private int[] listaEnteros = [];

        public Ej1(int[] listaEnteros)
        {
            this.listaEnteros = listaEnteros;
        }

        public int[] ListaEnteros
        {
            get { return listaEnteros; }
            set { listaEnteros = value; }
        }

        public string ObtenerNumeros()
        {
            return string.Join(", ", listaEnteros);
        }

        public void SustituirNumero(int indice, int nuevoNumero)
        {
            if (indice >= 0 && indice < listaEnteros.Length)
            {
                listaEnteros[indice] = nuevoNumero;
            }
            else
            {
                Console.WriteLine("Índice fuera de rango.");
            }
        }

        public int SumarNumerosLista()
        {
            int resultado = 0;
            foreach (int numero in listaEnteros) 
            { 
                resultado += numero;
            }

            return resultado;
        }

    }
}
