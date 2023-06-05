using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            // Vamos enfileirar
            fila.Enqueue("Cleiton");
            fila.Enqueue("Carlos");
            fila.Enqueue("Rodrigo");
            fila.Enqueue("Josiscleuda");
            fila.Enqueue("Josivalda");

            // Pegando o primeiro elemento da fila
            Console.WriteLine(fila.Peek());

            // Contando a quantidade da fila
            Console.WriteLine(fila.Count);

            // Remove a primeira pessoa da fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            // Verificando quantas pessoas temos na fila
            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

        }


    }
}
