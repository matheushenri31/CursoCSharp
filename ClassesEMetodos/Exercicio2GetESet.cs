using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio2GetESet
    {

        public class Aluno
        {
            private double n1;
            private double n2;
            private double n3;

            public double Media
            {
                get { return (n1 + n2 + n3) / 3; }
                set { n1 = value; n2 = value; n3 = value; }
            }


            public Aluno(double n1, double n2, double n3)
            {

               this.n1 = n1;
               this.n2 = n2;
               this.n3 = n3;


            }

        }


        public static void Executar()
        {
            var aluno1 = new Aluno(2.1, 8.5, 6.7);
            Console.WriteLine(aluno1.Media);



        }
    }
}


