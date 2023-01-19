using System;
using System.Globalization;

namespace SalarioFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TOTAL;
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalDinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TOTAL = (totalDinheiro * 15 / 100) + salario;
           

            Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2",CultureInfo.InvariantCulture));
           
        }
    }
}