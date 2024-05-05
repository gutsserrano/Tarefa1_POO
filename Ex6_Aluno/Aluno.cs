using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Aluno
{
    internal class Aluno
    {
        string nome;
        int numero;
        Aluno? anterior;

        public Aluno(string nome, int numero)
        {
            this.nome = nome;
            this.numero = numero;
            anterior = null;
        }

        public string getnome()
        {
            return nome;
        }

        public int getnumero()
        {
            return numero;
        }

        public void setNumero(int n)
        {
            numero = n;
        }

        public Aluno getAnterior()
        {
            return anterior;
        }

        public void setAnterior(Aluno anterior)
        {
            this.anterior = anterior;
        }
    }
}
