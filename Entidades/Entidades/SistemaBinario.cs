using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class SistemaBinario: Numeracion
    {
        public SistemaBinario(string valor): base(valor)
        {
        }

        internal override double ValorNumerico
        {
            get
            {
                return (double)decimal.Parse(this.Valor); ;
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            SistemaDecimal numeracion;
            if (sistema == ESistema.Decimal)
            {
                numeracion = new SistemaDecimal(decimal.Parse(this.Valor).ToString());
                return numeracion;
            }
            else
            {
                return DecimalABinario();
            }
        }
        private SistemaBinario DecimalABinario()
        {
            string binario = "";
            if (int.TryParse(this.valor, out int numero))
            {
                while (numero > 0)
                {
                    int residuo = numero % 2;
                    binario += residuo;
                    numero /= 2;
                }
            }
            return new SistemaBinario(binario);
        }

        protected bool EsNumeracionValida(string valor) 
        {
            return base.EsNumeracionValida(valor);
        }
    }
}
