using MestreDosCodigosPOOLucas.Modulos;
using MestreDosCodigosPOOLucas.Modulos.BancoModulo;
using MestreDosCodigosPOOLucas.Modulos.PessoaModulo;
using MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo;
using System;
using System.Collections.Generic;

namespace MestreDosCodigosPOOLucas
{
    public class Program
    {
        private static Modulo _modulo = null;
        private static List<Tuple<int, string>> modulos = new List<Tuple<int, string>>();
        public static void Main(string[] args)
        {
            CarregarModulos();
            while (true)
            {
                DefinirModulo();

                if (_modulo == null)
                    break;

                Console.Clear();
                _modulo.Executar();
            }
        }
        private static void DefinirModulo()
        {
            Console.Clear();
            Console.WriteLine("Digite 0 para Sair.");
            modulos.ForEach(x => Console.WriteLine($"{x.Item1} - {x.Item2}"));
            int moduloSelecionado = int.MinValue;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out moduloSelecionado) || moduloSelecionado > 9 || moduloSelecionado < 0)
                {
                    Console.Write("Opção inválida. Digite novamente: ");
                    moduloSelecionado = int.MinValue;
                }
            } while (moduloSelecionado == int.MinValue);

            if (moduloSelecionado == 0)
            {
                _modulo = null;
                return;
            }
            switch ((ModulosEnum)moduloSelecionado)
            {
                case ModulosEnum.Banco:
                    {
                        _modulo = new BancoModulo();
                        break;
                    }
                case ModulosEnum.Pessoa:
                    {
                        _modulo = new PessoaModulo();
                        break;
                    }
                case ModulosEnum.Televisao:
                    {
                        _modulo = new TelevisaoModulo();
                        break;
                    }
            }
        }
        private static void CarregarModulos()
        {
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.Banco));
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.Pessoa));
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.Televisao));
        }
        private static Tuple<int, string> ObterTuplaDoModulo(ModulosEnum modeloEnum)
        {
            return Tuple.Create((int)modeloEnum, modeloEnum.ToString());
        }
    }

    public enum ModulosEnum
    {
        Banco = 1,
        Pessoa = 2,
        Televisao = 3
    }
}
