using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EstoqueRefactor
{
    class Produto
    {
        public string nome;
        public int qtdEstoque;
        public double preco;

        public double ValorTotalEmEstoque()
        {
            return qtdEstoque * preco;
        }
        public int AddProdutos(int quantidade)
        {
            return qtdEstoque += quantidade;
        }

        internal int removerProdutos(int qtdRemovida)
        {
           return qtdEstoque -= qtdRemovida;
        }


        /*public int ValorTotalEmEstoque(int qtdAddEstoque)
        {
            return
        }*/
    }
}
