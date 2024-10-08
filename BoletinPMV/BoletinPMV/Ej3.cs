using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BoletinPMV
{
    internal class Ej3
    {
        // 1. Cree un Dictionary donde la clave sea el nombre de un producto(cadena) y el valor sea la cantidad disponible(entero).
        // 2. Añade al diccionario los siguientes productos y cantidades:

        //      ○ "Manzanas" - 50
        //      ○ "Naranjas" - 30
        //      ○ "Peras" - 20

        // 3. Imprime todos los productos y sus cantidades por consola.
        // 4. Actualiza la cantidad de "Naranjas" a 40.
        // 5. Añade un nuevo producto "Plátanos" con una cantidad de 25.
        // 6. Elimina el producto "Peras".
        // 7. Imprime el inventario final.

        private Dictionary<string, int> productos = new Dictionary<string, int>();

        public Ej3(Dictionary<string, int> productos)
        {
            this.productos = productos;
        }

        public Dictionary<string, int> Productos
        {
            get { return productos; }
            set { productos = value; }
        }

        public void ActualizarProducto(string producto, int nuevoValor)
        {
            if (!productos.ContainsKey(producto)) 
            {
                Console.WriteLine("El producto especificado no pudo ser encontrado.\n" +
                    "No se han realizado cambios.");
            }
            else
            {
                productos[producto] = nuevoValor;
                Console.WriteLine($"La cantidad para el producto [{producto}] es ahora: {nuevoValor}.");
            }
        }

        public void AgregarProducto(string producto, int cantidad)
        {
            productos.Add(producto, cantidad);
            Console.WriteLine($"Producto [{producto}] agregado correctamente. " +
                $"Cantidad: {cantidad}");
        }

        public void EliminarProducto(string producto)
        {
            if (!productos.ContainsKey(producto))
            {
                Console.WriteLine("El producto especificado no pudo ser encontrado.\n" +
                    "No se han realizado cambios.");
            }
            else
            {
                productos.Remove(producto);
            }
        }

        public override string ToString()
        {
            string output = "";
            foreach (var producto in productos)
            {
                output += producto.Key + " -> " + producto.Value + "\n";
            }
            return output;
        }
    }
}
