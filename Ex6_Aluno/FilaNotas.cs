using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Aluno
{
    internal class FilaNotas
    {
        Nota? head;
        Nota? tail;

        public FilaNotas()
        {
            head = null;
            tail = null;
        }

        public bool Push(int numero, float nota)
        {
            Nota aux = new(numero, nota);
            if (BuscarQtdNotasAluno(numero) < 2)
            {
                if (IsEmpty())
                {
                    head = tail = aux;
                }
                else
                {
                    tail.setNext(aux);
                    tail = aux;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Pop()
        {
            if(!IsEmpty())
            {
                //Nota aux = head;
                if(head == tail)
                {
                    head = tail = null;
                }
                else
                {
                    head = head.getNext();
                }
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return head == null && tail == null;
        }

        public void Print()
        {
            Nota aux = head;
            if (!IsEmpty())
            {
                Console.WriteLine();
                do
                {
                    Console.WriteLine($"Aluno: {aux.getNumeroAluno()} Nota: {aux.getNota()}");
                    aux = aux.getNext();
                } while (aux != null);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n**Fila Vazia**");
            }
        }

        public int BuscarQtdNotasAluno(int numero)
        {
            Nota aux = head;
            int counter = 0;
            if (!IsEmpty())
            {
                do
                {
                    if (aux.getNumeroAluno() == numero)
                    {
                        counter++;
                    }
                    aux = aux.getNext();
                } while (aux != null);
            }

            return counter;
        }

        public float CalcularMedia(int numero)
        {
            if(BuscarQtdNotasAluno(numero) == 2)
            {
                Nota aux = head;
                float media = 0;
                do
                {
                    if(aux.getNumeroAluno() == numero)
                    {
                        media += aux.getNota();
                    }
                    aux = aux.getNext();
                } while(aux != null);

                return media / 2;
            }
            else
            {
                return float.NaN;
            }
        }
    }
}
