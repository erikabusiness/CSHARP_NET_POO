using System.Globalization;

namespace TrianguloHeron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] trianguloX = new double[3];
            double[] trianguloY = new double[3];

            for (int cont = 0; cont <3; cont++)
            {
                Console.WriteLine("Entre com as medidas do triangulo X:");
                trianguloX[cont] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //InvariantCulture serve para que o programa interprete corretamente as casas decimais em qualquer lugar do mundo

            for (int cont = 0; cont < 3; cont++)
            {
                Console.WriteLine("Entre com as medidas do triangulo y:");
                trianguloY[cont] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //calculando a área do triangulo x
            double perimetroX = (trianguloX[0] + trianguloX[1] + trianguloX[2]) / 2.0;
            double areaX = Math.Sqrt(perimetroX * (perimetroX - trianguloX[0]) * (perimetroX - trianguloX[1]) * (perimetroX - trianguloX[2])); 
            //math.sqrt calcula a raíz quadrada dentro dos parenteses

            //calculando a área do triangulo y
            double perimetroY = (trianguloY[0] + trianguloY[1] + trianguloY[2]) / 2.0;
            double areaY = Math.Sqrt(perimetroY * (perimetroY - trianguloY[0]) * (perimetroY - trianguloY[1]) * (perimetroY - trianguloY[2]));

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture)); //ToString("F4", CultureInfo.InvariantCulture) nesse caso
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture)); //converte para string e coloca apenas 4 casas decimais depois da vírgula

            String resultado = areaX > areaY ? ("A maior área é a " + areaX) : ("A maior área é a " + areaY);
            Console.WriteLine(resultado);


        }
    }
}
