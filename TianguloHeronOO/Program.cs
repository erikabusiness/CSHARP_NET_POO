using System.Globalization;
using TrianguloHeronOO;
//using System.

namespace TianguloHeronOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double perimetroX = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(perimetroX * (perimetroX - x.A) * (perimetroX - x.B) * (perimetroX - x.C));

            double perimetroY = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(perimetroY * (perimetroY - y.A) * (perimetroY - y.B) * (perimetroX-y.C));


            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture)); //ToString("F4", CultureInfo.InvariantCulture) nesse caso
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture)); //converte para string e coloca apenas 4 casas decimais depois da vírgula

            String resultado = areaX > areaY ? ("A maior área é a " + areaX) : ("A maior área é a " + areaY);
            Console.WriteLine(resultado);
        }
    }
}
