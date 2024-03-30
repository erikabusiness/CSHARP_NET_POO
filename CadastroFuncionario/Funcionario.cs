using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario
{
    class Funcionario
    {
        public string nome;
        public double salario;
        public double imposto;

        public double SalarioLiquido()
        {
            return salario - (salario * (imposto / 100));
            
        }
        public double AumentarSalario(double porcentagem)
        {
            return salario += salario * (porcentagem / 100);
        }
    }
}
