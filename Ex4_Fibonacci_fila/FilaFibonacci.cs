using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Fibonacci_fila
{
    internal class FilaFibonacci
    {
        Numero? head;
        Numero? tail;
        int qtdNumeros;

        public FilaFibonacci()
        {
            head = null;
            tail = null;
            qtdNumeros = 0;
        }

        public void push(int n)
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

        public void preencheFibonacci(int n)
        {
            int fib;
            int ant = -1;
            int pos = 1;

            if (!IsEmpty())
            {
                do
                {
                    head = head.getNext();
                } while (head != null);

                if (head == null)
                {
                    tail = null;
                }
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
