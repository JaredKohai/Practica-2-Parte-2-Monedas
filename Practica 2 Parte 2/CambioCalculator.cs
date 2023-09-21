using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_Parte_2
{
    class CambioCalculator
    {
        private MonedaConNombre[] monedas = {
            new MonedaConNombre(100, "Billete de 100 pesos"),
            new MonedaConNombre(50, "Billete de 50 pesos"),
            new MonedaConNombre(20, "Billete de 20 pesos"),
            new MonedaConNombre(10, "Billete de 10 pesos"),
            new MonedaConNombre(5, "Billete de 5 pesos"),
            new MonedaConNombre(1, "Moneda de 1 peso"),
            new MonedaConNombre(0.5m, "Moneda de 50 centavos"),
            new MonedaConNombre(0.25m, "Moneda de 25 centavos"),
            new MonedaConNombre(0.1m, "Moneda de 10 centavos"),
            new MonedaConNombre(0.05m, "Moneda de 5 centavos"),
            new MonedaConNombre(0.01m, "Moneda de 1 centavo")
        };

        public Cambio CalcularCambio(decimal precio, decimal cantidadPagada)
        {
            decimal cambioTotal = cantidadPagada - precio;
            Cambio cambio = new Cambio();
            CalcularCambioR(cambioTotal, cambio, 0);
            return cambio;
        }

        private void CalcularCambioR(decimal cambioTotal, Cambio cambio, int index)
        {
            if (cambioTotal == 0)
            {
                return; 
            }

            if (index >= monedas.Length)
            {
                throw new InvalidOperationException("No es posible dar cambio");
            }

            MonedaConNombre moneda = monedas[index];
            decimal valorMoneda = moneda.Valor;
            int cantidadDeMonedas = (int)(cambioTotal / valorMoneda);

            if (cantidadDeMonedas > 0)
            {
                moneda.Cantidad = cantidadDeMonedas;
                cambio.AgregarMoneda(moneda);

                cambioTotal -= cantidadDeMonedas * valorMoneda;
            }

            CalcularCambioR(cambioTotal, cambio, index + 1);
        }
    }

}
