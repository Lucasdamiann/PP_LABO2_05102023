using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class SistemaDecimal : Numeracion
    {
        internal SistemaDecimal(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico
        {
            get
            {
                return (double)decimal.Parse(this.Valor);
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

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor);
        }

        private bool EsSistemaDecimalValido(string valor) 
        {
            if (double.TryParse(valor, out double numero))
            { 
            return true; 
            }
            return false;
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }
        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }

    }
}
