using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Heranca
    {

        // Criar classe CARRO
        
        public class Carro
        {
            protected readonly int VelocidadeMaxima;
            // A variável velocidadeMaxima será transmitida por herança
            // Por isso que estamos usando o protected
            int VelocidadeAtual;

            // Criando o construtor de carro

            public Carro(int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }

            // Criando método para acelerar o carro

            protected int AlterarVelocidade(int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;
                if(novaVelocidade <0)
                {
                    VelocidadeAtual = 0;
                }
                else if (novaVelocidade > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    VelocidadeAtual = novaVelocidade;
                }

                return VelocidadeAtual;
            }

            public int Acelerar()
            {
                return AlterarVelocidade(5);
            }

            public int Frear()
            {
                return AlterarVelocidade(-5);
            }

        }

        // Herança de Carro
        /* Ao colocar : estamos fazendo a herança */
        public class Uno : Carro
        {
            /* O número 200 que está entre base ()
             * significa a velocidadeMaxima que foi herdado de carro
             usamos base para não precisar fazer o contrutor novamente */
            public Uno() : base(200)
            {

            }
        }

        public class Ferrari : Carro
        {
            public Ferrari() : base(340)
            {

            }
        }
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            // Instanciar carro1 em Uno
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
        }


    }
}
