namespace BoletinPMV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // EJERCICIO 1
            Console.WriteLine("\n============= EJERCICIO 1 =============\n");

            Ej1 ej1 = new Ej1([10, 20, 30, 40, 50]);
            int resultado = 0;

            Console.WriteLine(ej1.ObtenerNumeros());

            ej1.SustituirNumero(3, 35);

            Console.WriteLine(ej1.ObtenerNumeros());

            resultado = ej1.SumarNumerosLista();

            Console.WriteLine($"Resultado de la suma de los números del array: {resultado}.\n");

            // EJERCICIO 2
            Console.WriteLine("\n============= EJERCICIO 2 =============\n");

            Ej2 ej2 = new Ej2(new int[3, 3]
            {
                {10, 12, 14},
                {15, 18, 20},
                {22, 24, 26}
            });

            double mediaTemperaturas;

            Console.WriteLine(ej2.ToString());

            mediaTemperaturas = ej2.ObtenerMediaTemperaturas();

            Console.WriteLine($"Media de temperaturas: {mediaTemperaturas}.");

            // EJERCICIO 3
            Console.WriteLine("\n============= EJERCICIO 3 =============\n");

            Ej3 ej3 = new Ej3(new Dictionary<string, int>());

            ej3.AgregarProducto("Manzanas", 50);
            ej3.AgregarProducto("Naranjas", 30);
            ej3.AgregarProducto("Peras", 20);

            Console.WriteLine("Lista de productos.\n" + ej3.ToString());

            ej3.ActualizarProducto("Naranjas", 40);
            ej3.AgregarProducto("Plátanos", 25);
            ej3.EliminarProducto("Peras");

            Console.WriteLine("Lista de productos.\n" + ej3.ToString());


        }
    }
}
