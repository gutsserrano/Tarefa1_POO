using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Pilhas
{
    internal class Pilha
    {
        Numero? topo;
        int qtdNumeros;

        public Pilha()
        {
            topo = null;
            qtdNumeros = 0;
        }

        public void push(int aux)
        {
            Numero numero = new(aux);
            if(isEmpty())
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
            if(!isEmpty())
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
            if(!isEmpty() )
            {
                do
                {
                    Console.WriteLine($">> {aux.getValor()}");
                    aux = aux.getAnterior();
                } while( aux != null );
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n**Pilha Vazia!**\n");
            }
        }

        public void printPares()
        {
            Numero aux = topo;
            bool existe = false;
            if (!isEmpty())
            {
                do
                {
                    if (aux.getValor() % 2 == 0)
                    {
                        Console.WriteLine($">> {aux.getValor()}");
                        existe = true;
                    }
                    aux = aux.getAnterior();
                } while (aux != null);

                if (!existe)
                {
                    Console.WriteLine("\n**Pilha sem valores pares**");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n**Pilha Vazia!**\n");
            }
        }

        public void printImpares()
        {
            Numero aux = topo;
            bool existe = false;
            if (!isEmpty())
            {
                do
                {
                    if (aux.getValor() % 2 != 0)
                    {
                        Console.WriteLine($">> {aux.getValor()}");
                        existe = true;
                    }
                    aux = aux.getAnterior();
                } while (aux != null);

                if (!existe)
                {
                    Console.WriteLine("\n**Pilha sem valores Ímpares**");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n**Pilha Vazia!**\n");
            }
        }

        public Numero getMaior()
        {
            Numero maior, anterior;
            if (!isEmpty())
            {
                maior = topo;
                anterior = topo.getAnterior();
                do
                {
                    if (anterior != null)
                    {
                        if (maior.getValor() < anterior.getValor())
                        {
                            maior = anterior;
                        }
                        else
                        {
                            anterior = anterior.getAnterior();
                        }
                    }
                } while (anterior != null);
                return maior;
            }

            return null;
        }

        public Numero getMenor()
        {
            Numero menor, anterior;
            if (!isEmpty())
            {
                menor = topo;
                anterior = topo.getAnterior();
                do
                {
                    if (anterior != null)
                    {
                        if (menor.getValor() > anterior.getValor())
                        {
                            menor = anterior;
                        }
                        else
                        {
                            anterior = anterior.getAnterior();
                        }
                    }
                } while (anterior != null);
                return menor;
            }

            return null;
        }

        public float getMedia()
        {
            float sum = 0;
            Numero aux = topo;

            if (!isEmpty())
            {
                do
                {
                    sum += aux.getValor();
                    aux = aux.getAnterior();
                } while (aux != null);

                return sum / getQtdNumeros();
            }

            return 0;
        }

    }
}
