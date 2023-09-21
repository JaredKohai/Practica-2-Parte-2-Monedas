using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_Parte_2
{
    abstract class Moneda
    {
        public decimal Valor { get; }
        public int Cantidad { get; set; }

        protected Moneda(decimal valor)
        {
            Valor = valor;
        }

        public abstract string ObtenerNombre();
    }

    class MonedaConNombre : Moneda
    {
        private string nombre;

        public MonedaConNombre(decimal valor, string nombre) : base(valor)
        {
            this.nombre = nombre;
        }

        public override string ObtenerNombre()
        {
            return nombre;
        }
    }
}
