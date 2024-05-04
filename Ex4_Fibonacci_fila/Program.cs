namespace Ex4_Fibonacci_fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaFibonacci fibonacci = new FilaFibonacci();
            int option;

            do
            {
                Console.Clear();
                option = menu();

                switch (option)
                {
                    case 1:
                        preencherFila(fibonacci);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("===========Fila de Fibonacci=============");
                        fibonacci.Print();
                        Console.ReadKey();
                        break;
                }
            } while (option != 0);


        }

        static int menu()
        {
            int op;
            do
            {
                Console.WriteLine("===========Fila de Fibonacci=============");
                Console.WriteLine("1 - Preencher fila");
                Console.WriteLine("2 - Imprimir fila");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());
            } while (op < 0 || op > 2);

            return op;
        }

        static void preencherFila(FilaFibonacci f)
        {
            int op;
            Console.Clear();
            do
            {
                Console.WriteLine("Digite quantos valores da sequencia de Fibonacci serão adicionados na fila");
                op = int.Parse(Console.ReadLine());

                if (op <= 0)
                {
                    Console.WriteLine("\nO numero deve ser maior que zero!");
                }
            } while (op <= 0);

            f.preencheFibonacci(op);

            Console.WriteLine("\n**Fila preenchida com sucesso!**");
            Console.ReadKey();
        }
    }
}
