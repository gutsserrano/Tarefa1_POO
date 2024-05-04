using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Fila_E_Pilha
{
    internal class Fila
    {
        Numero? head;
        Numero? tail;
        int qtdNumeros;
        int maxNumber;

        public Fila(int maxNumber)
        {
            head = null;
            tail = null;
            qtdNumeros = 0;
            this.maxNumber = maxNumber;
        }

        public void push(int n)
        {
            if (getQtdNumeros() <= 10)
            {
                Numero aux = new(n);
                if (IsEmpty())
                {
                    head = tail = aux;
                }
                else
                {
                    tail.setNext(aux);
                    tail = aux;
                }
                qtdNumeros++;
            }
            else
            {
                Console.WriteLine($"\n**Fila cheia (tamanho {getQtdNumeros()})**");
            }
        }

        public Numero Pop()
        {
            if (!IsEmpty())
            {
                Numero aux = head;
                if (head == tail)
                {
                    head = tail = null;
                }
                else
                {
                    head = head.getNext();
                }
                qtdNumeros--;
                return aux;
            }
            return null;
        }

        public bool IsEmpty()
        {
            return head == null && tail == null;
        }

        public void Print()
        {
            Numero aux = head;
            if (!IsEmpty())
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
                Console.WriteLine("\n**Fila Vazia**");
            }
        }

        public int getQtdNumeros()
        {
            return qtdNumeros;
        }

        public void destruir()
        {
            head = tail = null;
        }
    }
}
