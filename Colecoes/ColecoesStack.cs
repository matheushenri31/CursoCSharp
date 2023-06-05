using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            // Adicionando elementos na pilha
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            // Exibindo elementos da pilha
            foreach(var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            // Removendo um elemento da pilha
            Console.WriteLine($"Pop: {pilha.Pop()}");

            // Percorrendo novamente para verificar se o elemento foi removido
            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            // Usando peek
            Console.WriteLine($"Peek: {pilha.Peek()}");
            // Contando os elementos
            Console.WriteLine(pilha.Count);
        }
    }
}
