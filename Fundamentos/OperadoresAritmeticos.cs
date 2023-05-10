using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {


        public static void Executar() {

            /*Console.WriteLine("Número 1:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Número 2:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma entre {numero1} e {numero2} é igual a {numero1 + numero2}");*/

            Console.WriteLine("Base do triângulo: ");
            double base_triangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura do triângulo: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"A área desse triângulo é de {(base_triangulo * altura) / 2}m2");



        }
    }
}
