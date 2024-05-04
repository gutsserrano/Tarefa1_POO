namespace Ex1_Pilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha1 = new();
            Pilha pilha2 = new();
            Pilha pilha3 = new();
            int opcao;

            do
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        adicionarNumero(pilha1);
                        break;
                    case 2:
                        removerNumero(pilha1);
                        break;
                    case 3:
                        adicionarNumero(pilha2);
                        break;
                    case 4:
                        removerNumero(pilha2);
                        break;
                    case 5:
                        imprimirPilhas(pilha1, pilha2);
                        break;
                    case 6:
                        compararPilhas(pilha1, pilha2);
                        break;
                    case 7:
                        menuPilhas(pilha1 , pilha2, pilha3);
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("============Pilha 3===========");
                        pilha3.print();
                        Console.ReadKey();
                        break;
                    case 9:
                        paresImpares(pilha1, pilha2);
                        break;
                }
            } while (opcao != 0);
        }

        static int menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("Manipulando duas pilhas:");
                Console.WriteLine("1 - Adicionar Numeros na pilha 1");
                Console.WriteLine("2 - Remover Numeros da pilha 1");
                Console.WriteLine("3 - Adicionar Numeros na pilha 2");
                Console.WriteLine("4 - Remover Numeros da pilha 2");
                Console.WriteLine("5 - Imprimir elementos, menores, maiores e média das pilhas");
                Console.WriteLine("6 - Comparar tamanho das duas pilhas");
                Console.WriteLine("7 - Transferir elementos de uma pilha para uma terceira");
                Console.WriteLine("8 - Ver os elementos da terceira pilha");
                Console.WriteLine("9 - Ver os elementos pares ou ìmpares de uma pilha");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());
            } while (op < 0 || op > 9);

            return op;
        }

        static void adicionarNumero(Pilha p)
        {
            string? aux;
            int num;
            do
            {
                Console.Clear();
                Console.WriteLine("\nDigite um número, caso deseja parar, apenas pressione enter");
                aux = Console.ReadLine();

                if(aux != "")
                {
                    num = int.Parse(aux);
                    p.push(num);
                }
            } while (aux != "");

        }

        static void removerNumero(Pilha p)
        {
            Console.Clear();
            if (p.pop() != null)
            {
                Console.WriteLine("\n**Numero removido com sucesso!**");
            }
            else
            {
                Console.WriteLine("\n**Pilha Vazia!**");
            }
            Console.ReadKey();
        }

        static void imprimirPilhas(Pilha p1, Pilha p2)
        {
            Console.Clear();
            Console.WriteLine("\n============Pilha 1===========");
            p1.print();

            if (!p1.isEmpty())
            {

                Console.WriteLine($"Maior: {p1.getMaior().getValor()}");
                Console.WriteLine($"Menor: {p1.getMenor().getValor()}");
                Console.WriteLine($"Media: {p1.getMedia()}");
            }

            Console.WriteLine("\n============Pilha 2===========");
            p2.print();

            if (!p1.isEmpty())
            {

                Console.WriteLine($"Maior: {p2.getMaior().getValor()}");
                Console.WriteLine($"Menor: {p2.getMenor().getValor()}");
                Console.WriteLine($"Media: {p2.getMedia()}");
            }

            Console.ReadKey();
        }

        static void compararPilhas(Pilha p1, Pilha p2)
        {
            int tamanho1, tamanho2;
            tamanho1 = p1.getQtdNumeros();
            tamanho2 = p2.getQtdNumeros();

            Console.Clear();
            Console.WriteLine("Comparando pilhas");
            if(tamanho1 != tamanho2)
            {
                if(tamanho1 > tamanho2)
                {
                    Console.WriteLine($"\nPilha 1 (tamanho {tamanho1}) > Pilha 2 (tamanho {tamanho2})");
                }
                else
                {
                    Console.WriteLine($"\nPilha 2 (tamanho {tamanho2}) > Pilha 1 (tamanho {tamanho1})");
                }
            }
            else
            {
                Console.WriteLine("\n**Pilhas iguais!**");
            }

            Console.ReadKey();
        }

        static void menuPilhas(Pilha p1, Pilha p2, Pilha nova)
        {
            int op;

            Console.Clear();
            do
            {
                Console.WriteLine("Qual pilha deseja transferir para uma nova?");
                Console.WriteLine("1 - Pilha 1");
                Console.WriteLine("2 - Pilha 2");
                op = int.Parse(Console.ReadLine());
            } while(op < 1 || op > 2);

            switch (op)
            {
                case 1:
                    transferirElementos(p1, nova);
                    break;
                case 2:
                    transferirElementos(p2, nova);
                    break;
            }
        }

        static void transferirElementos(Pilha p, Pilha nova)
        {
            Numero aux;

            Console.Clear();
            if (p.getQtdNumeros() > 0)
            {
                if(nova.getQtdNumeros() > 0)
                {
                    while (nova.pop() != null);
                }

                do
                {
                    aux = p.pop();
                    if (aux != null)
                    {
                        nova.push(aux.getValor());
                    }
                } while (aux != null);

                Console.WriteLine("\n**Valores transferidos com sucesso!**");
            }
            else
            {
                Console.WriteLine("\n**Pilha Vazia!**");
            }

            Console.ReadKey();
        }

        static void paresImpares(Pilha p1, Pilha p2)
        {
            int op, op2;
            Pilha aux;

            Console.Clear();
            do
            {
                Console.WriteLine("Qual pilha deseja analisar?");
                Console.WriteLine("1 - Pilha 1");
                Console.WriteLine("2 - Pilha 2");
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 2);

            switch (op)
            {
                case 1:
                    aux = p1;
                    break;
                case 2:
                    aux = p2;
                    break;
                default:
                    aux = new();
                    break;
            }

            do
            {
                Console.WriteLine("\nVer pares ou impares:");
                Console.WriteLine("1 - Pares");
                Console.WriteLine("2 - Impares");
                op2 = int.Parse(Console.ReadLine());
            } while (op2 < 1 || op2 > 2);

            Console.Clear();
            switch (op2)
            {
                case 1:
                    Console.WriteLine("Valores pares:");
                    aux.printPares();
                    break;
                case 2:
                    Console.WriteLine("Valores impares");
                    aux.printImpares();
                    break;
            }

            Console.ReadKey();
        }
    }
}
