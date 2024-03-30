namespace CalculoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Digite a altura do retângulo:");
            retangulo.altura = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura do retangulo:");
            retangulo.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA =" + retangulo.Area());
            Console.WriteLine("PERIMETRO= " + retangulo.Perimetro());
            Console.WriteLine("Diagonal= " + retangulo.Diagonal());
            
            
        }
    }
}
