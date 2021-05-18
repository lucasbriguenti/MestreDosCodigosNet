using System;

namespace MestreDosCodigosLucas.Modulos.Calculadora
{
    public class CalculadoraModulo : Modulo
    {
        private double primeiroValor = 0, segundoValor = 0;
        private readonly Calculador calculador = new Calculador();

        public void Executar()
        {
            while (true)
            {
                var funcaoSelecionada = (FuncaoCalculadora)ObterSelecaoDeFuncao();

                if (funcaoSelecionada == 0)
                    break;
                else
                    Console.Clear();

                LerParametros();
                ImprimirResultado(funcaoSelecionada);
            }
        }

        private void LerParametros()
        {
            Console.Write("Digite o primeiro valor: ");
            do
            {
                if (!double.TryParse(Console.ReadLine(), out primeiroValor))
                {
                    Console.Write("\nNúmero Inválido, digite novamente: ");
                    primeiroValor = 0;
                }
            } while (primeiroValor == 0);
            Console.Write("Digite o segundo valor: ");
            do
            {
                if (!double.TryParse(Console.ReadLine(), out segundoValor))
                {
                    Console.WriteLine("\nNúmero Inválido, digite novamente: ");
                    segundoValor = 0;
                }
            } while (segundoValor == 0);
        }

        private void ImprimirResultado(FuncaoCalculadora funcao)
        {
            var resultado = calculador.Calcular(primeiroValor, segundoValor, funcao);
            switch (funcao)
            {
                case FuncaoCalculadora.Soma:
                    {
                        Console.WriteLine($"Soma: {resultado}");
                        break;
                    }
                case FuncaoCalculadora.Subtracao:
                    {
                        Console.WriteLine($"Subtração: {resultado}");
                        break;
                    }
                case FuncaoCalculadora.Multiplicacao:
                    {
                        Console.WriteLine($"Multiplicação: {resultado}");
                        break;
                    }
                case FuncaoCalculadora.Divisao:
                    {
                        Console.WriteLine($"Divisão: {resultado}");
                        break;
                    }
                case FuncaoCalculadora.ParOuImpar:
                    {
                        var parOuImparPrimeiraEntrada = primeiroValor % 2 == 0 ? "Par" : "Impar";
                        var parOuImparSegundaEntrada = segundoValor % 2 == 0 ? "Par" : "Impar";
                        Console.WriteLine($"Entradas: \n{primeiroValor} é {parOuImparPrimeiraEntrada}");
                        Console.WriteLine($"{segundoValor} é {parOuImparSegundaEntrada}");
                        break;
                    }
            }
            Console.ReadLine();
        }

        private int ObterSelecaoDeFuncao()
        {
            Console.Clear();
            Console.WriteLine("Digite 0 para Sair.");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Par ou Impar");
            var funcaoSelecionada = int.MinValue;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out funcaoSelecionada) || funcaoSelecionada > 5 || funcaoSelecionada < 0)
                {
                    Console.WriteLine("\nNúmero Inválido, digite novamente\n");
                    funcaoSelecionada = int.MinValue;
                }
            } while (funcaoSelecionada == int.MinValue);
            Console.Clear();
            return funcaoSelecionada;
        }
    }
}