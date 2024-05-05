using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Aluno
{
    internal class PilhaAluno
    {
        Aluno? topo;
        int qtdAlunos;

        public PilhaAluno()
        {
            topo = null;
            qtdAlunos = 0;
        }

        public void Push(string nomeAluno)
        {
            Aluno aluno = new(nomeAluno, qtdAlunos + 1);
            if (IsEmpty())
            {
                topo = aluno;
            }
            else
            {
                aluno.setAnterior(topo);
                topo = aluno;
            }
            qtdAlunos++;
        }

        public bool Pop()
        {
            if(!IsEmpty())
            {
                Aluno aux = topo;
                topo = topo.getAnterior();
                qtdAlunos--;
                return true;
            }

            return false;
        }

        public bool IsEmpty()
        {
            return topo == null;
        }

        public int GetQtdAlunos()
        {
            return qtdAlunos;
        }

        public void Print()
        {
            Aluno aux = topo;
            if (!IsEmpty())
            {
                Console.WriteLine();
                do
                {
                    Console.WriteLine($"{aux.getnome()} -> {aux.getnumero()}");
                    aux = aux.getAnterior();
                } while (aux != null);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n**Pilha Vazia!**");
            }
        }

        public bool AlunoExiste(int numero)
        {
            Aluno aux = topo;
            if (!IsEmpty())
            {
                do
                {
                    if(numero == aux.getnumero())
                    {
                        return true;
                    }
                    aux = aux.getAnterior();
                } while(aux != null);
            }
            return false;
        }
    }
}
