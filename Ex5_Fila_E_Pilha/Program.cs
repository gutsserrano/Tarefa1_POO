using System.Runtime.Intrinsics.X86;

namespace Ex5_Fila_E_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos valores irão caber na pilha e na fila?");
            int max = int.Parse(Console.ReadLine());

            Pilha pilha = new(max);
            Fila fila = new(max);
            Fila repetidos = new(max);

            Console.Clear();
            preencherPilha(pilha, max);
            Console.Clear();
            preencherFila(fila, max);
            Console.Clear();
            imprimirInterseccao(pilha, fila, max);
            Console.WriteLine();
            Console.WriteLine("=======Pilha========");
            pilha.print();
            Console.WriteLine("=======Fila=========");
            fila.Print();


        }

        static void preencherPilha(Pilha p, int max)
        {
            int aux;
            p.destruir();
            for(int i = 0; i < max; i++)
            {
                Console.WriteLine($"Digite o valor {i + 1} da pilha:");
                p.push(int.Parse(Console.ReadLine()));
            }
        }

        static void preencherFila(Fila f, int max)
        {
            int aux;
            f.destruir();
            for(int i = 0; i < max; i++)
            {
                Console.WriteLine($"Digite o valor {i + 1} da fila:");
                f.push(int.Parse(Console.ReadLine()));
            }
        }

        static void imprimirInterseccao(Pilha p, Fila f, int max)
        {
            int[] vetorAux = calcularInterseccao(p, f, max);

            Console.WriteLine("Valores existentes na Pilha e na Fila:\n");
            for (int i = 0; i < vetorAux.Length; i++)
            {
                Console.WriteLine($">> {vetorAux[i]}");
            }
            Console.WriteLine();
        }

        static int[] calcularInterseccao(Pilha p, Fila f, int max)
        {
            int[] vetor = new int[max];
            int[] vetorAux;
            Fila filaAux = new(max);
            int cont = 0;

            while (!f.IsEmpty())
            {
                int aux = f.Pop().getValor();
                filaAux.push(aux);

                if (p.existeNaPilha(aux))
                {
                    vetor[cont] = aux;
                    cont++;
                }
            }

            while (!filaAux.IsEmpty())
            {
                f.push(filaAux.Pop().getValor());
            }

            vetorAux = new int[cont];
            for(int i = 0; i < cont; i++)
            {
                vetorAux[i] = vetor[i];
            }

            return vetorAux;
        }
    }
}
