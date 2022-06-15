using System;
using System.Collections.Generic;

namespace Calculadora.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            List<string> histroico = new List<string>();

            while (true)
            {
               
                string operacaoAtual = "";
                string operacaoSinal = "";


                #region Menu Principal

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("Digite 1 para adição\n");

                Console.WriteLine("Digite 2 para subtração\n");

                Console.WriteLine("Digite 3 para multiplição\n");

                Console.WriteLine("Digite 4 para divisão\n");

                Console.WriteLine("Digite 5 para historico\n");

                Console.WriteLine("Digite S para sair\n");

                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if(opcao != "1" || opcao != "2" || opcao != "3" || opcao != "4" || opcao != "5")
                {
                    Console.WriteLine("Opção inválida, tente novamente!");
                    Console.ReadKey();
                    continue;
                }

                #endregion

                #region Realizar Calculo

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                string operacao = "";

                switch (opcao)
                {
                    case "1":
                        operacao = "adição";
                        break;

                    case "2":
                        operacao = "subtração de dois números";
                        operacaoSinal = "-";
                        break;
                    case "3":
                        operacao += "Multiplição\n";
                        operacaoSinal = "*";
                        break;

                    case "4":
                        operacao = "divisão";
                        break;
                    

                    case "5":
                        operacao += "Historico\n";
                        break;

                }

                string subtitulo = $"Novo calculo de {operacao}";

                Console.WriteLine(subtitulo + "\n");

                double primeiroNumero = 0;
                double segundoNumero = 0;
                if (opcao != "5")
                {
                    Console.Write($"Digite o primeiro número: ");
                     primeiroNumero = Convert.ToDouble(Console.ReadLine());

                    Console.Write($"Digite o segundo número: ");
                     segundoNumero = Convert.ToDouble(Console.ReadLine());
                }
                double resultado = 0;

                switch (opcao)
                {
                    case "1":
                        resultado = primeiroNumero + segundoNumero;
                        break;

                    case "2":
                        resultado = primeiroNumero - segundoNumero;
                        break;
                       
                    case "3":
                        resultado = primeiroNumero * segundoNumero;
                        break;
                    case "4":
                        resultado = primeiroNumero / segundoNumero;
                        break;
                }
                #endregion

                operacaoAtual += $"{primeiroNumero} {operacaoSinal} {segundoNumero} = {resultado}";

               

                #region Mostrar Resultado
                Console.Clear();

            

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela de Resultados\n");

                if (opcao == "5")
                    VisualizarHistorico(histroico);
                else
                {
                    Console.Write($"O resultado da operação de {operacao} é: {resultado}");
                    histroico.Add(operacaoAtual);
                }
                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();
                #endregion

            }
        }

        private static void VisualizarHistorico(List<string> histroico)
        {
            foreach (var item in histroico)
            {
                Console.WriteLine(item);
            }
        }
    }
}
