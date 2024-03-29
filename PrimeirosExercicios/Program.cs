namespace PrimeirosExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa Maria, Joao;
            Maria = new Pessoa();
            Joao = new Pessoa();

            Funcionario funcionario1, funcionario2;
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Pessoa[] nomes = { Maria, Joao };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Insira o sobrenome de " + (i == 0 ? "Maria" : "João") + ":");
                nomes[i].Nome = Console.ReadLine();
                Console.WriteLine("Insira a idade de " + (i == 0 ? "Maria" : "João") + ":");
                nomes[i].Idade = int.Parse(Console.ReadLine());
            }

            String verificarMaisVelho = (nomes[0].Idade > nomes[1].Idade ? ("Maria é mais velha!") : ("João é mais velho!"));
            Console.WriteLine(verificarMaisVelho);

            }



        }


    }
}
