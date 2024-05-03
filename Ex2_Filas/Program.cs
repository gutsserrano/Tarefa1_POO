namespace Ex2_Filas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila fila1 = new Fila();
            Fila fila2 = new Fila();
            Fila fila3 = new Fila();
            int opcao;

            do
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        adicionarNumero(fila1);
                        break;
                    case 2:
                        removerNumero(fila1);
                        break;
                    case 3:
                        adicionarNumero(fila2);
                        break;
                    case 4:
                        removerNumero(fila2);
                        break;
                    case 5:
                        imprimirPilhas(fila1, fila2);
                        break;
                    case 6:
                        compararPilhas(fila1, fila2);
                        break;
                    case 7:
                        menuFilas(fila1, fila2, fila3);
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("============Fila 3===========");
                        fila3.Print();
                        Console.ReadKey();
                        break;
                    case 9:
                        paresImpares(fila1, fila2);
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
                Console.WriteLine("Manipulando duas filas:");
                Console.WriteLine("1 - Adicionar Numeros na fila 1");
                Console.WriteLine("2 - Remover Numeros da fila 1");
                Console.WriteLine("3 - Adicionar Numeros na fila 2");
                Console.WriteLine("4 - Remover Numeros da fila 2");
                Console.WriteLine("5 - Imprimir elementos das filas");
                Console.WriteLine("6 - Comparar tamanho das duas filas");
                Console.WriteLine("7 - Transferir elementos de uma fila para uma terceira");
                Console.WriteLine("8 - Ver os elementos da terceira fila");
                Console.WriteLine("9 - Ver os elementos pares ou ìmpares de uma fila");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());
            } while (op < 0 || op > 9);

            return op;
        }

        static void adicionarNumero(Fila f)
        {
            string? aux;
            int num;
            do
            {
                Console.Clear();
                Console.WriteLine("\nDigite um número, caso deseja parar, apenas pressione enter");
                aux = Console.ReadLine();

                if (aux != "")
                {
                    num = int.Parse(aux);
                    f.push(num);
                }
            } while (aux != "");

        }

        static void removerNumero(Fila f)
        {
            Console.Clear();
            if (f.Pop() != null)
            {
                Console.WriteLine("\n**Numero removido com sucesso!**");
            }
            else
            {
                Console.WriteLine("\n**Fila Vazia!**");
            }
            Console.ReadKey();
        }

        static void imprimirPilhas(Fila f1, Fila f2)
        {
            Console.Clear();
            Console.WriteLine("============Fila 1===========");
            f1.Print();
            Console.WriteLine("============Fila 2===========");
            f2.Print();

            Console.ReadKey();
        }

        static void compararPilhas(Fila f1, Fila f2)
        {
            int tamanho1, tamanho2;
            tamanho1 = f1.getQtdNumeros();
            tamanho2 = f2.getQtdNumeros();

            Console.Clear();
            Console.WriteLine("Comparando filas");
            if (tamanho1 != tamanho2)
            {
                if (tamanho1 > tamanho2)
                {
                    Console.WriteLine($"\nFila 1 (tamanho {tamanho1}) > Fila 2 (tamanho {tamanho2})");
                }
                else
                {
                    Console.WriteLine($"\nFila 2 (tamanho {tamanho2}) > Fila 1 (tamanho {tamanho1})");
                }
            }
            else
            {
                Console.WriteLine("\n**Filas iguais!**");
            }

            Console.ReadKey();
        }

        static void menuFilas(Fila f1, Fila f2, Fila nova)
        {
            int op;

            Console.Clear();
            do
            {
                Console.WriteLine("Qual Fila deseja transferir para uma nova?");
                Console.WriteLine("1 - Fila 1");
                Console.WriteLine("2 - Fila 2");
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 2);

            switch (op)
            {
                case 1:
                    transferirElementos(f1, nova);
                    break;
                case 2:
                    transferirElementos(f2, nova);
                    break;
            }
        }

        static void transferirElementos(Fila f, Fila nova)
        {
            Numero aux;

            Console.Clear();
            if (f.getQtdNumeros() > 0)
            {
                if (nova.getQtdNumeros() > 0)
                {
                    while (nova.Pop() != null) ;
                }

                do
                {
                    aux = f.Pop();
                    if (aux != null)
                    {
                        nova.push(aux.getValor());
                    }
                } while (aux != null);

                Console.WriteLine("\n**Valores transferidos com sucesso!**");
            }
            else
            {
                Console.WriteLine("\n**Fila Vazia!**");
            }

            Console.ReadKey();
        }

        static void paresImpares(Fila f1, Fila f2)
        {
            int op, op2;
            Fila aux;

            Console.Clear();
            do
            {
                Console.WriteLine("Qual fila deseja analisar?");
                Console.WriteLine("1 - Fila 1");
                Console.WriteLine("2 - Fila 2");
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 2);

            switch (op)
            {
                case 1:
                    aux = f1;
                    break;
                case 2:
                    aux = f2;
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
