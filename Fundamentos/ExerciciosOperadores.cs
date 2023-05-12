using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class ExerciciosOperadores {

        public static void Executar() {

            /* Console.WriteLine("N1: ");
             double n1 = double.Parse(Console.ReadLine());

             Console.WriteLine("N2: ");
             double n2 = double.Parse(Console.ReadLine());

             Console.WriteLine("N3: ");
             double n3 = double.Parse(Console.ReadLine());

             double media = (n1 + n2 + n3) / 3;


             Console.WriteLine($"A média do aluno é: {media}.toString("F")");

             Console.WriteLine("N1: ");
             double n1 = double.Parse(Console.ReadLine());

             Console.WriteLine("N2: ");
             double n2 = double.Parse(Console.ReadLine());

             double somas = ((((n1 * 3.5) + n2 * 7.5) / 11) / 10);

             Console.WriteLine($"Resultado: {somas.ToString("F")}");
 */

            Console.WriteLine("Seu número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor_por_Hora: ");
            double valor_por_hora = double.Parse(Console.ReadLine());

            double salario = horas * valor_por_hora;

            Console.WriteLine($"Número de funcionário: {numero} \r\nSalário: {salario.ToString("C")}");
        }
    }
}
