namespace EstoqueRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto produto = new Produto("TV", 500, 10); - torna-se obrigatorio informar aqui

            //Console.WriteLine(produto);

            
            Console.WriteLine("Insira os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade disponivel em estoque?");
            int qtdEstoque = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, qtdEstoque, preco);

            Console.WriteLine("Dados do produto:");
            Console.Write("\nNome: " + produto.Nome + "\nPreço: " + produto.Preco + " \nQuantidade disponivel em estoque? " + produto.QtdEstoque + "\nTotal:" + produto.ValorTotalEmEstoque());

            
            Console.WriteLine("\nDigite o número de produtos a serem adicionados: ");
            int qtdAdicionada = int.Parse(Console.ReadLine());
            produto.AddProdutos(qtdAdicionada);
            Console.WriteLine("Dados atualizados:");
            Console.Write("\nNome: " + produto.Nome + "\nPreço: " + produto.Preco + " \nQuantidade disponivel em estoque? " + produto.QtdEstoque + "\nTotal:" + produto.ValorTotalEmEstoque());

            Console.WriteLine("\nDigite o número de produtos a serem removidos: ");
            int qtdRemovida = int.Parse(Console.ReadLine());
            produto.removerProdutos(qtdRemovida);
            Console.WriteLine("Dados atualizados:");
            Console.Write("\nNome: " + produto.Nome + "\nPreço: " + produto.Preco + " \nQuantidade disponivel em estoque? " + produto.QtdEstoque + "\nTotal:" + produto.ValorTotalEmEstoque());
            
        }

    }
}
