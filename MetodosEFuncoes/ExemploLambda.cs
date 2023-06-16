using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            // Criando a função
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Palmeiras tem mundial");
            };

            // Chamando a função
            // algoNoConsole();

            // Criando a função com retorno
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 6);
            };

            Console.WriteLine(jogarDado());

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
             {
                 return string.Format("{0:D2} / {1:D2} / {2:D2}", dia, mes, ano);
             };

            Console.WriteLine(formatarData(16, 06, 2023));

            Func<int, bool> imparOuPar = (numero) =>
            {
                if (numero % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            Console.WriteLine(imparOuPar(4));
                  
            
        }
    }
}
