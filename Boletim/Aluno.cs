using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;


        public double SomarNotas()
        {
            return nota1 + nota2 + nota3;
        }

        public string VerificarAprovacao()
        {
            string aprovacao = (SomarNotas() / 3) >= 7 ? ("Aprovado!") : ("Reprovado");
            return aprovacao;
        }
    }
}
