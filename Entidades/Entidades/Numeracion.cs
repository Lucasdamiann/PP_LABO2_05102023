using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class Numeracion
    {
        protected string msgError;
        protected string valor;

        private Numeracion()
        {
            this.msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            this.InicializaValor(valor);
        }

        public string Valor
        {
            get;
        }

        internal abstract double ValorNumerico 
        { 
            get;
        }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            if (valor !=  null ) 
            {
                foreach (char s in valor)
                {
                    if (s != ' ')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static explicit operator double (Numeracion numeracion)
        {
            return double.Parse(numeracion.Valor);
        }

        private void InicializaValor(string valor)
        {
            if (valor != null && double.TryParse(valor, out double numero) && numero > 0) 
            {
                this.valor = valor;
            }
            this.valor = this.msgError;
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        { 
            return !(n1 == n2);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return (n1 != null && n2 != null && n1.GetType() == n2.GetType());
        }
    }

    enum ESistema
    {
        Binario,
        Decimal
    }
}
