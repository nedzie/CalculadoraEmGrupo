﻿using System;

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

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: 3 = Multiplição ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                #endregion

                #region Realizar Calculo

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                string operacao = "";

                switch (opcao)
                {
                    case "3":
                        operacao += "Multiplição\n";
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
                    case "3":
                        resultado = primeiroNumero * segundoNumero;
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
