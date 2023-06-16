using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar },
                {"Exercícios Operadores ",ExerciciosOperadores.Executar},
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},

                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle",EstruturaIf.Executar},
                {"Estrutura Switch - Estruturas de Controle",EstruturaSwitch.Executar},
                {"Estrutura While e For - Estruturas de Controle",EstruturaWhileEFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle",EstuturaForEach.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar },
                {"Exercícios Métodos Com Retorno - Classes e Métodos",ExerciciosMetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Métodos",MetodosEstaticos.Executar },
                {"Params - Classes e Métodos",Params.Executar },
                {"Get e Set - Classes e Métodos",GetSet.Executar },
                {"Get e Set Segundo Exemplo - Classese Métodos",GetESetSegundoExemplo.Executar },
                {"Exercício 1 Get e Set - Classes e Métodos",Exercicio1GetESet.Executar },
                {"Exercício 2 Get e Set - Classes e Métodos",Exercicio2GetESet.Executar },
                {"Exercício 3 Get e Set - Classes e Métodos",Exercicio3GetESet.Executar },

                //Coleções
                {"Arrays - Coleções",Arrays.Executar },
                {"Coleções Queue - Coleções",ColecoesQueue.Executar },
                {"Coleções Stack - Coleções",ColecoesStack.Executar },

                //POO - Programação Orientada a Objetos
                {"Herança - POO",Heranca.Executar },
                {"Construtor This - POO",ConstrutorThis.Executar },
                {"Encapsulamento - POO",POO.Encapsulamento.Executar },
                {"Polimorfismo - POO",Polimorfismo.Executar },
                {"Execício Polimorfismo - POO",ExercicioPolimorfismo.Executar },
                {"Abstrato - POO",Abstract.Executar},
                {"Sealed - POO",Sealed.Executar },

                //Métodos e Funções
                {"Exemplo Lambda - Métodos e Funções",ExemploLambda.Executar },

                //Exceções
                {"Primeira Exceção",PrimeiraExcecao.Executar }

      
               
            }); ;
            
            central.SelecionarEExecutar();
        }
    }
}