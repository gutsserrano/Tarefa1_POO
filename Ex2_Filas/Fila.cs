using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Filas
{
    internal class Fila
    {
        Numero? head;
        Numero? tail;
        int qtdNumeros;

        public Fila()
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

        public void printPares()
        {
            Numero aux = head;

            int count = 0;
            if (!IsEmpty())
            {
                do
                {
                    if (aux.getValor() % 2 == 0)
                    {
                        Console.WriteLine($">> {aux.getValor()}");
                        count++;
                    }
                    aux = aux.getNext();
                } while (aux != null);

                if (count == 0)
                {
                    Console.WriteLine("\n**Fila sem número pares!**");
                }
            }
            else
            {
                Console.WriteLine("\n**Fila Vazia**");
            }
        }

        public void printImpares()
        {
            Numero aux = head;

            int count = 0;
            if (!IsEmpty())
            {
                do
                {
                    if (aux.getValor() % 2 != 0)
                    {
                        Console.WriteLine($">> {aux.getValor()}");
                        count++;
                    }
                    aux = aux.getNext();
                } while (aux != null);

                if (count == 0)
                {
                    Console.WriteLine("\n**Fila sem número impares!**");
                }
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
    }
}
