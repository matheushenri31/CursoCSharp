using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetESetSegundoExemplo
    {
        public class CarroOpcional
        {
            double desconto = 0.1;
            private string nome;

            public string Nome
            {
                get
                {
                    return "Opcional" + nome;
                }

                set
                {
                    nome = value;
                }
            }
            //propriedade autoimplementada
            public double Desconto { get; set; }

            public double Preco { get; set; }

            public double PrecoComDescoto
            {
                get
                {
                    return Preco - (desconto * Preco);
                }
            }
            
            // Criando o construtor personalizado
            public CarroOpcional(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }


        public static void Executar()
        {
            var op = new CarroOpcional("Aerofólio", 1.500);
            var op2 = new CarroOpcional("Ar Condicionado", 3.200);

            Console.WriteLine(op.PrecoComDescoto);
            Console.WriteLine(op2.PrecoComDescoto);
        }
    }
}
