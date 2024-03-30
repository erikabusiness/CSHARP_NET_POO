namespace Boletim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.nota1 = double.Parse(Console.ReadLine());
            aluno.nota2 = double.Parse(Console.ReadLine());
            aluno.nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota final:" + aluno.SomarNotas());
            Console.WriteLine(aluno.VerificarAprovacao()) ;



        }
    }
}
