namespace CadastroFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            funcionario.salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + funcionario.nome + "Salario líquido: R$" + funcionario.SalarioLiquido());
            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            double aumento = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(aumento);

            Console.WriteLine("Dados atualizados: ");
            Console.Write("\nFuncionario: " + funcionario.nome + "\nSalario líquido: R$" + funcionario.AumentarSalario(aumento));

            //funcionario.Console.ReadLine();


            

            
        }
    }
}
