using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExerciciosMetodosComRetorno
    {
       /* class Conversao
        {
            public double real_dolar(double r)
            {
                return r * 4.95;
            }
        }*/

        class Graus
        {
            public double celcius_to_fah(double cel)
            {
                return cel * 1.8 + 32;
            }
        }

        public static void Executar()
        {

            /* Console.WriteLine("Conversão R$ to $: ");
             double resposta_conversao = double.Parse(Console.ReadLine());

             var obj1 = new Conversao();
             var resposta = obj1.real_dolar(resposta_conversao);

             Console.WriteLine($"{resposta}");*/

            Console.WriteLine("Graus Celsis: ");
            double resposta_conversao = double.Parse(Console.ReadLine());

            var obj1 = new Graus();
            var resposta = obj1.celcius_to_fah(resposta_conversao);

            Console.WriteLine($"Fahrenheit: {resposta}");

            
        }
    }
}
