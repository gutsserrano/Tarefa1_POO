using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Pilhas
{
    internal class Numero
    {
        int valor;
        Numero? anterior;

        public Numero(int valor)
        {
            this.valor = valor;
            anterior = null;
        }

        public int getValor() 
        { 
            return valor; 
        }

        public void setAnterior(Numero p)
        {
            anterior = p;
        }

        public Numero? getAnterior()
        {
            return anterior;
        }
    }
}
