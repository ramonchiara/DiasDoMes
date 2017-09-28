using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiasDoMes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] diasDoMes = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // ENTRADA
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());

            // PROCESSAMENTO
            int dias = diasDoMes[mes - 1];

            // SAÍDA
            Console.WriteLine("Esse mês tem {0} dias", dias);
        }
    }
}
