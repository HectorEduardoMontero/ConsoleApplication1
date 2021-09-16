using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{



    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> ListaNumero = new List<int>();

            ListaNumero = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };


            var lista = ListaNumero.pares();

            lista.ForEach(e => Console.Write(", {0}", e));
            Console.WriteLine();
            Console.WriteLine(" Valor es Impar {0}", EsImpar(25));
            Console.WriteLine(" Mi Itebis {0}", CalcularITBIS(52500));
            Console.WriteLine(" La fecha de hoy es {0}", GetDate());


            Console.ReadKey();



        }

        public static bool EsImpar(int x) { return (x % 2 != 0); }

        public static double CalcularITBIS(double precio) { return (precio * 0.18); }


        public static DateTime GetDate() { return (DateTime.Now); }


    }
}
