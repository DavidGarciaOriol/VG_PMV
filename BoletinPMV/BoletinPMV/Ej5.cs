using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinPMV
{
    internal class Ej5
    {
        // 1. Crea un enum llamado Monedas que tenga los siguientes valores asociados a cada tipo de moneda:

        //    ○ Moneda50 = 50
        //    ○ Moneda20 = 20
        //    ○ Moneda10 = 10
        //    ○ Moneda5 = 5
        //    ○ Moneda2 = 2
        //    ○ Moneda1 = 1

        // 2. Implementa un método que reciba una cantidad en céntimos y utilice el enum para
        //calcular el número mínimo de monedas necesarias para obtener ese valor.

        // 3. El programa debe solicitar al usuario que ingrese una cantidad de dinero en
        //céntimos y luego mostrar el número mínimo de monedas de cada tipo necesarias.

        private enum Monedas{
            Moneda50 = 50,
            Moneda20 = 20,
            Moneda10 = 10,
            Moneda5 = 5,
            Moneda2 = 2,
            Moneda1 = 1
        }
        public Ej5() { }

        private int PedirCentimos()
        {
            string centimosStr = "";
            int centimos = 0;

            do
            {
                Console.WriteLine("Ingresa una cantidad en céntimos (solo números mayor que cero): ");
                centimosStr = Console.ReadLine();

            } while (centimosStr == null || !int.TryParse(centimosStr, out centimos) || int.Parse(centimosStr) < 0);

            centimos = int.Parse(centimosStr);

            return centimos;
        }

        public void CalcularMonedasCambio()
        {
            int centimos = PedirCentimos();

            Dictionary<Monedas, int> cantidadMonedas = new Dictionary<Monedas, int>();

            foreach (Monedas moneda in Enum.GetValues(typeof(Monedas)))
            {
                int valorMoneda = (int)moneda;

                int numMonedas = centimos / valorMoneda;

                if (numMonedas > 0)
                {
                    cantidadMonedas[moneda] = numMonedas;
                    centimos -= numMonedas * valorMoneda;
                }
            }

            Console.WriteLine("Número mínimo de monedas necesarias:");
            foreach (var item in cantidadMonedas)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
