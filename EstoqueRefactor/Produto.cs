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
        public string Nome;
        public int QtdEstoque;
        public double Preco;

        //MÉTODO CONSTRUTOR - TEM O MESMO NOME DA CLASSE - OBRIGA A COLOCAR OS DADOS AO INSTANCIAR A CLASSE
        public Produto(string nome, int qtdEstoque, double preco)
        {
            Nome = nome;
            Preco = preco;
            QtdEstoque = qtdEstoque;
        }

        public double ValorTotalEmEstoque()
        {
            return QtdEstoque * Preco;
        }
        public int AddProdutos(int quantidade)
        {
            return QtdEstoque += quantidade;
        }

        internal int removerProdutos(int qtdRemovida)
        {
           return QtdEstoque -= qtdRemovida;
        }

    }
}
