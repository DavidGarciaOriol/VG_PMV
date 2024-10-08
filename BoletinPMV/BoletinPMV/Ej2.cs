using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinPMV
{
    internal class Ej2
    {
        // 1. Cree un array bidimensional (matriz) de 3x3 que almacene temperaturas en grados Celsius.
        // 2. Inicializa la matriz con los siguientes valores:

        // [10, 12, 14]
        // [15, 18, 20]
        // [22, 24, 26]

        // 3. Imprime la matriz por consola en formato de tabla.
        // 4. Calcula la temperatura media de la matriz e imprímela por consola.

        private int[,] matrizTemperaturas;

        public Ej2(int[,] matrizTemperaturas)
        {
            this.matrizTemperaturas = matrizTemperaturas;
        }

        public int[,] MatrizTemperaturas
        {
            get { return matrizTemperaturas; }
            set { matrizTemperaturas = value; }
        }

        public double ObtenerMediaTemperaturas()
        {
            double suma = 0;
            int numeroElementos = 0;
            double media = 0;

            numeroElementos = matrizTemperaturas.GetLength(0) * matrizTemperaturas.GetLength(1);

            for (int i = 0; i < matrizTemperaturas.GetLength(0); i++) 
            {
                for (int j = 0; j < matrizTemperaturas.GetLength(1); j++) 
                {
                    suma += matrizTemperaturas[i, j];
                }
            }

            media = suma / numeroElementos;

            return media;
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < matrizTemperaturas.GetLength(0); i++)
            {
                output += "|";

                for (int j = 0; j < matrizTemperaturas.GetLength(1); j++)
                {
                    output += matrizTemperaturas[i, j].ToString();

                    if (j < matrizTemperaturas.GetLength(1) - 1)
                    {
                        output += "\t";
                    }
                    
                }
                output += "|\n";
            }
            return output;
        }
    }
}
