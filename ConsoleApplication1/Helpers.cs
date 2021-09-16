using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public static class Helpers
    {

        public static List<int> pares(this List<int> Entrada)
        {


            return Entrada.FindAll(x =>(x % 2)==0);
        }

       

    }
}
