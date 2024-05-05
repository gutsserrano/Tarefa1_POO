namespace Ex6_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaAluno pilhaAluno = new PilhaAluno();
            FilaNotas filaNotas = new FilaNotas();
            int option;
            do
            {
                Console.Clear();
                option = menu();
                switch (option)
                {
                    case 1:
                        CadastrarAluno(pilhaAluno); 
                        break;
                    case 2:
                        ImprimirAlunos(pilhaAluno);
                        break;
                    case 3:
                        CadastrarNota(pilhaAluno, filaNotas);
                        break;
                    case 4:
                        ImprimirNotas(filaNotas);
                        break;
                }
            } while (option != 0);

            Console.WriteLine("Pilha aluno");
            pilhaAluno.Print();

            Console.WriteLine("\nFila Notas");
            filaNotas.Print();
        }

        static void CadastrarAluno(PilhaAluno pilha)
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do aluno a ser cadastrado:");
            pilha.Push(Console.ReadLine());
            Console.WriteLine("\n**Aluno cadastrado com sucesso!**");
            Console.ReadKey();
        }

        static void CadastrarNota(PilhaAluno pilha, FilaNotas fila)
        {
            Console.Clear();
            Console.WriteLine("Digite o numero do Aluno que vai receber a nota:");
            int numeroAluno = int.Parse(Console.ReadLine());
            if (pilha.AlunoExiste(numeroAluno))
            {
                Console.WriteLine("Digite a nota do aluno:");
                if(fila.Push(numeroAluno, float.Parse(Console.ReadLine())))
                {
                    Console.WriteLine("\n**Nota adicionada com sucesso!**");
                }
                else
                {
                    Console.WriteLine($"Aluno {numeroAluno} ja possui 2 notas cadastradas");
                }
            }
            else
            {
                Console.WriteLine("\n**Aluno inexistente**");
            }
            Console.ReadKey();
        }

        static void ImprimirAlunos(PilhaAluno pilha)
        {
            Console.Clear();
            Console.WriteLine("========Pilha Alunos========");
            Console.WriteLine("  Nome    |    Numero");
            pilha.Print();
            Console.ReadKey();
        }

        static void ImprimirNotas(FilaNotas fila)
        {
            Console.Clear();
            Console.WriteLine("========Fila Notas========");
            Console.WriteLine("  Numero    |    Nota");
            fila.Print();
            Console.ReadKey();
        }

        static int menu()
        {
            int op;
            do
            {
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Ver Alunos cadastrados");
                Console.WriteLine("3 - Cadastrar nota");
                Console.WriteLine("4 - Ver todas as notas");
                Console.WriteLine("5 - Calcular média do aluno");
                Console.WriteLine("6 - Listar nome dos alunos sem nota");
                Console.WriteLine("7 - Excluir aluno");
                Console.WriteLine("8 - Excluir nota");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());
            } while (op < 0 || op > 8);

            return op;
        }
    }
}
