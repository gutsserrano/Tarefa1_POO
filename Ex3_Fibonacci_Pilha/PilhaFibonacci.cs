using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Fibonacci_Pilha
{
    internal class PilhaFibonacci
    {
        Numero? topo;
        int qtdNumeros;

        public PilhaFibonacci()
        {
            topo = null;
            qtdNumeros = 0;
        }

        public void push(int aux)
        {
            Numero numero = new(aux);
            if (isEmpty())
            {
                topo = numero;
            }
            else
            {
                numero.setAnterior(topo);
                topo = numero;
            }
            qtdNumeros++;
        }

        public Numero pop()
        {
            if (!isEmpty())
            {
                Numero aux = topo;
                topo = topo.getAnterior();
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
                    aux = aux.getAnterior();
                } while (aux != null);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n**Pilha Vazia!**\n");
            }
        }

        public void preencheFibonacci(int n)
        {
            int num;
            int fib;
            int ant = -1;
            int pos = 1;

            if (!isEmpty())
            {
                do
                {
                    topo = topo.getAnterior();
                } while(topo != null);
            }

            for (int i = 0; i < n; i++)
            {
                fib = ant + pos;
                push(fib);
                ant = pos;
                pos = fib;
            }

        }
    }
}
