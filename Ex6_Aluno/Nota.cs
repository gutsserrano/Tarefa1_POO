using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Aluno
{
    internal class Nota
    {
        int numeroAluno;
        float nota;
        Nota proximo;

        public Nota(int numero, float nota)
        {
            numeroAluno = numero;
            this.nota = nota;
            proximo = null;
        }

        public int getNumeroAluno() 
        {
            return numeroAluno;
        }

        public float getNota()
        {
            return nota;
        }

        public Nota getNext()
        {
            return proximo;
        }

        public void setNext(Nota proximo)
        {
            this.proximo = proximo;
        }

    }
}
