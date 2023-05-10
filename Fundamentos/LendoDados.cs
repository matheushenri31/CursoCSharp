using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class LendoDados {

        public static void Executar(){

            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            // Fazendo a conversão para inteiro
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura?");
            // Fazendo converão para float
            double altura = double.Parse(Console.ReadLine());

            // Tentar exibir as variaveis em uma mensagem

            Console.WriteLine($"Olá, {nome}, você tem {idade} anos, e {altura} metros de altura");



        }

    }
}
