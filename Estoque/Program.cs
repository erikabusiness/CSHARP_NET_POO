using System.Globalization;

namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Produto produto = new Produto();

            Console.WriteLine("Preencha os dados do produto:");
            Console.WriteLine("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            produto.qtdEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: " + produto);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtdAdicionada = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtdAdicionada);
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qtdAdicionada = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtdAdicionada);
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}
