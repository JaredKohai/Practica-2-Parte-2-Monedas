using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_Parte_2
{
    class Cambio
    {
        private List<Moneda> monedas = new List<Moneda>();

        public void AgregarMoneda(Moneda moneda)
        {
            monedas.Add(moneda);
        }

        public void MostrarCambio()
        {
            foreach (var moneda in monedas)
            {
                Console.WriteLine($"{moneda.Cantidad} {(moneda.Cantidad == 1 ? "Moneda" : "Monedas")} de {moneda.Valor:C} pesos");
            }
        }
    }
}
