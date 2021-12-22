using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {


            int numFuncionario, numhoras;
            double valHora, valFinal;

            numFuncionario = int.Parse(Console.ReadLine());
            numhoras = int.Parse(Console.ReadLine());
            valHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(numFuncionario);
            valFinal = numhoras * valHora;
            Console.WriteLine(valFinal.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
