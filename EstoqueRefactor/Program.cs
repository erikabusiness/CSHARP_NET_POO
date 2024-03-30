namespace EstoqueRefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Insira os dados do produto: ");
            Console.Write("Nome: ");
            produto.nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade disponivel em estoque?");
            produto.qtdEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto:");
            Console.Write("\nNome: " + produto.nome + "\nPreço: " + produto.preco + " \nQuantidade disponivel em estoque? " + produto.qtdEstoque + "\nTotal:" + produto.ValorTotalEmEstoque());

            
            Console.WriteLine("\nDigite o número de produtos a serem adicionados: ");
            int qtdAdicionada = int.Parse(Console.ReadLine());
            produto.AddProdutos(qtdAdicionada);
            Console.WriteLine("Dados atualizados:");
            Console.Write("\nNome: " + produto.nome + "\nPreço: " + produto.preco + " \nQuantidade disponivel em estoque? " + produto.qtdEstoque + "\nTotal:" + produto.ValorTotalEmEstoque());

            Console.WriteLine("\nDigite o número de produtos a serem removidos: ");
            int qtdRemovida = int.Parse(Console.ReadLine());
            produto.removerProdutos(qtdRemovida);
            Console.WriteLine("Dados atualizados:");
            Console.Write("\nNome: " + produto.nome + "\nPreço: " + produto.preco + " \nQuantidade disponivel em estoque? " + produto.qtdEstoque + "\nTotal:" + produto.ValorTotalEmEstoque());
        }
    }
}
