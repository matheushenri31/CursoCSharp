using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio3GetESet
    {

        public class Animal
        {
            private string nome;
            private string tipo;

            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public string Tipo
            {
                get { return tipo; }
                set
                {
                    if (value == "Cachorro" || value == "Gato" || value == "Ave")
                        tipo = value;
                    else
                        tipo = "Ave";
                }
            }

            public void MostrarDados()
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Tipo: {tipo}");
            }


        }
    
    public static void Executar()
    {

        Animal an1 = new Animal();

        Console.WriteLine($"Qual o nome? ");
         an1.Nome = Console.ReadLine();

         Console.WriteLine($"Tipo: ");
         an1.Tipo = Console.ReadLine();
         an1.MostrarDados();
    }
}
}

