using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {

        public static void Executar() {
            int a = 72;
            int b = 4;
            int c = 16;
            int d = 20;

            // Verdadeiro
            Console.WriteLine(a >= d);
            Console.WriteLine(b != c);
            // Falso
            Console.WriteLine(d < c );
            //
            Console.WriteLine(a > b && d != c);
            Console.WriteLine(d == c || b <= a);
        }
    }
}
