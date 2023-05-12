using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeContole {
    class Estruturaif {

        public static void Executar() {

            Console.WriteLine("Nota 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 3: ");
            double n3 = double.Parse(Console.ReadLine());

            double media = n1 + n2 + n3 / 3;
            string resultado = "";

            if (media >= 7) {
                resultado = "Aprovado";
            } else {
                resultado = "Reprovado";
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
