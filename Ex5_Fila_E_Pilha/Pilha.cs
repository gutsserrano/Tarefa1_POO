using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Fila_E_Pilha
{
    internal class Pilha
    {
        Numero? topo;
        int qtdNumeros;
        int maxNumber;

        public Pilha(int maxNumber)
        {
            topo = null;
            qtdNumeros = 0;
            this.maxNumber = maxNumber;
        }

        public void push(int aux)
        {
            if (getQtdNumeros() <= 10)
            {
                Numero numero = new(aux);
                if (isEmpty())
                {
                    topo = numero;
                }
                else
                {
                    numero.setNext(topo);
                    topo = numero;
                }
                qtdNumeros++;
            }
            else
            {
                Console.WriteLine($"\n**Pilha cheia (tamanho {getQtdNumeros()})**");
            }
        }

        public Numero pop()
        {
            if (!isEmpty())
            {
                Numero aux = topo;
                topo = topo.getNext();
                qtdNumeros--;
                return aux;
            }
            else
            {
                return null;
            }
        }

        public bool isEmpty()
        {
            return topo == null;
        }

        public int getQtdNumeros()
        {
            return qtdNumeros;
        }

        public void print()
        {
            Numero aux = topo;
            if (!isEmpty())
            {
                do
                {
                    Console.WriteLine($">> {aux.getValor()}");
                    aux = aux.getNext();
                } while (aux != null);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n**Pilha Vazia!**\n");
            }
        }

        public void destruir()
        {
            topo = null;
        }

        public bool existeNaPilha(int num)
        {
            Numero aux = topo;

            if (!isEmpty())
            {
                do
                {
                    if (aux.getValor() == num)
                    {
                        return true;
                    }
                    aux = aux.getNext();
                } while(aux != null);
            }
            return false;
        }
    }
}
