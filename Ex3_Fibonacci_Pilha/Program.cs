namespace Ex3_Fibonacci_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaFibonacci fibonacci = new();
            int option;

            do
            {
                Console.Clear();
                option = menu(fibonacci);

                switch(option)
                {
                    case 1:
                        preencherPilha(fibonacci);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("===========Pilha de Fibonacci=============");
                        fibonacci.print();
                        Console.ReadKey();
                        break;
                }
            } while (option != 0);


        }

        static int menu(PilhaFibonacci p)
        {
            int op;
            do
            {
                Console.WriteLine("===========Pilha de Fibonacci=============");
                Console.WriteLine("1 - Preencher pilha");
                Console.WriteLine("2 - Imprimir pilha");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());
            } while (op < 0 || op > 2);

            return op;
        }

        static void preencherPilha(PilhaFibonacci p)
        {
            int op;
            Console.Clear();
            do
            {
                Console.WriteLine("Digite quantos valores da sequencia de Fibonacci serão adicionados na pilha");
                op = int.Parse(Console.ReadLine());

                if(op <= 0)
                {
                    Console.WriteLine("\nO numero deve ser maior que zero!");
                }
            } while (op <= 0);

            p.preencheFibonacci(op);

            Console.WriteLine("\n**Pilha preenchida com sucesso!**");
            Console.ReadKey();
        }
    }
}
