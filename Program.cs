using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeContole;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos ", FormatandoNumeros.Executar},
                {"Operadores Aritméticos - Fundamentos ",OperadoresAritmeticos.Executar},
                {"Exercícios Operadores - Fundamentos ",ExerciciosOperadores.Executar },
                {"Operadores Relacionais - Fundamentos ",OperadoresRelacionais.Executar },
                {"Operadores Atribuição - Fundamentos",OperadoresAtribuicao.Excutar },

                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle",Estruturaif.Executar },
                {"Exercicios2 - Estruturas de Controle",Exercicio2.Executar}

            });

            central.SelecionarEExecutar();
        }
    }
}