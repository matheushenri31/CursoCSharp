using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeContole
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Banana";
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            // Percorrendo um array
            var alunos = new String[ ] { "José", "Cleiton", "Maria", "Josenildo" };
            foreach (var nomes in alunos)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}
