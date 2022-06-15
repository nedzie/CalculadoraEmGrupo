using System;

namespace Calculadora.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                #region Menu Principal

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("Digite 1 para adição\n");

                Console.WriteLine("Digite 2 para subtração\n");

                Console.WriteLine("Digite 3 para multiplição\n");

                Console.WriteLine("Digite 4 para divisão\n");

                Console.WriteLine("Digite S para sair\n");

                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if(opcao != "1" || opcao != "2" || opcao != "3" || opcao != "4")
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
                        break;
                    
                    case "3":
                        operacao += "Multiplição\n";
                        break;

                    case "4":
                        operacao = "divisão";
                        break;
                    
                }

                string subtitulo = $"Novo calculo de {operacao}";

                Console.WriteLine(subtitulo + "\n");

                Console.Write($"Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

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

                #region Mostrar Resultado
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela de Resultados\n");

                Console.Write($"O resultado da operação de {operacao} é: {resultado}");

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();
                #endregion

            }
        }
    }
}
