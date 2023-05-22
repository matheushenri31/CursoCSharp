using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeContole
{
    class Exercicio3
    {
        public static void Executar()
        {
            // Exercício 1
            /*int soma = 0;
            for(int contador = 1; contador < 11; contador++)
            {
                Console.WriteLine("Digite um número");
                int.TryParse(Console.ReadLine(), out int numeros);
                soma += numeros;

            }
            Console.WriteLine($"Soma: {soma}");*/

            // Exercício 2
            /*Console.WriteLine("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int numero);

            for (int contador = 1; contador <= numero; contador++)
            {
                Console.WriteLine(contador);
            }*/

            // Exercicio3
            Console.WriteLine("Informe um número para ver sua tabuada");
            int.TryParse(Console.ReadLine(), out int numero);

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} X {contador} = {numero * contador}");
            }
                
        }
    }
}
