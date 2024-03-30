using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int qtdEstoque;

        public double ValorTotalEmEstoque()
        {
            return Preco * qtdEstoque;
        }

        public void AdicionarProdutos(int quantidade)
        {
            qtdEstoque += quantidade;

        }

        public void RemoverProdutos(int quantidade)
        {
            qtdEstoque -= quantidade;

        }

        public override string ToString()
        {
            return "Nome: " + Nome + 
                ", Valor: $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + 
                ", Quantidade: " + qtdEstoque + " unidades, Total: $" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) ;
        }


        

    }

    
}
