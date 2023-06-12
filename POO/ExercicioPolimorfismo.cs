using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class ExercicioPolimorfismo
    {
        public class Cliente 
        {
            public string Nome;
            public string Tipo;
        }

        public class Juridico : Cliente
        {
            public string Cnpj;
        }

        public class Fisico : Cliente
        {
            public string Cpf;
        }


        public static void Executar()
        {
            Cliente pessoa = new Cliente();
            Juridico pessoaJuridica = new Juridico();
            Fisico pessoaFisica = new Fisico();


            Console.WriteLine("Seu nome? ");
           pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite [1] para Cliente Físico e [2] para Cliente Jurídico");
            int num = int.Parse(Console.ReadLine());

            if(num == 1)
            {
                Console.WriteLine($"nome: {pessoa.Nome} Tipo: Físico ");
            }

            if(num == 2)
            {
                Console.WriteLine($"nome: {pessoa.Nome} Tipo: Jurídico" );
            }


        }
    }
}
