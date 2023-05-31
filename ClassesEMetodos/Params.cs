﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        // Usando a palavra params conseguimos criar vários tipos
        // de parametros
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine($"Olá {pessoa}");
            }
        }

        public static void Executar()
        {
            Recepcionar("Mario", "Cleiton", "Josefa","Julia");
        }
    }
}
