using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radianes_grados
{
    class Program
    {
        static void Main(string[] args)
        {

            double radianes, pi, resultado;

            pi = 3.14159;

            Console.Title = " Conversion de Radianes a Grados";
            Console.WriteLine(" radianes");
            radianes = double.Parse(Console.ReadLine());

            resultado = (radianes * 180 / pi);

            Console.WriteLine(" La respuesta es : {0} grados", resultado);

            Console.ReadKey();
        }
    }
}
