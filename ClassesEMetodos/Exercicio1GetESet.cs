using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio1GetESet
    {
        public class Pessoa
        {
            private string nome;
            private int anoQueNasceu;
            private double altura;

            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public int AnoQueNasceu
            {
                get { return anoQueNasceu; }
                set { anoQueNasceu = value; }
            }

            public double Altura
            {
                get { return altura; }
                set { altura = value; }
            }

            public void ImprimirDados()
            {
                Console.WriteLine($"Seu nome: {nome}");
                Console.WriteLine($"Ano que nasceu: {anoQueNasceu}");
                Console.WriteLine($"Altura: {altura}cm");
             
            }

            public int CalcularIdade()
            {
                return 2023 - AnoQueNasceu;
            }
        }



        public static void Executar()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Matias";
            p1.Altura = 1.80;
            p1.AnoQueNasceu = 2006;

            p1.ImprimirDados();

            int idade = p1.CalcularIdade();

            Console.WriteLine(idade);



        }
    }
}
