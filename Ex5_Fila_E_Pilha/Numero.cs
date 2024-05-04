using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Fila_E_Pilha
{
    internal class Numero
    {
        int valor;
        Numero? proximo;

        public Numero(int valor)
        {
            this.valor = valor;
            proximo = null;
        }

        public int getValor()
        {
            return valor;
        }

        public void setNext(Numero p)
        {
            proximo = p;
        }

        public Numero? getNext()
        {
            return proximo;
        }
    }
}
