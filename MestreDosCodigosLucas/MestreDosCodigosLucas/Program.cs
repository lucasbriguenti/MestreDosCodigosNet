using MestreDosCodigosLucas.Modulos;
using MestreDosCodigosLucas.Modulos.Alunos;
using MestreDosCodigosLucas.Modulos.Bhaskara;
using MestreDosCodigosLucas.Modulos.Calculadora;
using MestreDosCodigosLucas.Modulos.Funcionarios;
using MestreDosCodigosLucas.Modulos.Linq;
using MestreDosCodigosLucas.Modulos.Multiplos;
using MestreDosCodigosLucas.Modulos.Ordenacao;
using MestreDosCodigosLucas.Modulos.RefOut;
using MestreDosCodigosLucas.Modulos.SomaPares;
using System;
using System.Collections.Generic;

namespace MestreDosCodigosLucas
{
    public class Program
    {
        private static Modulo _modulo = null;
        private static List<Tuple<int, string>> modulos = new List<Tuple<int, string>>();
        public static void Main(string[] args)
        {
            CarregarModulos();
            while(true)
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
            switch((ModulosEnum)moduloSelecionado)
            {
                case ModulosEnum.Calculadora:
                    {
                        _modulo = new CalculadoraModulo();
                        break;
                    }
                case ModulosEnum.Funcionarios:
                    {
                        _modulo = new FuncionariosModulo();
                        break;
                    }
                case ModulosEnum.Multiplos:
                    {
                        _modulo = new MultiplosModulo();
                        break;
                    }
                case ModulosEnum.Alunos:
                    {
                        _modulo = new AlunosModulo();
                        break;
                    }
                case ModulosEnum.RefOut:
                    {
                        _modulo = new RefOutModulo();
                        break;
                    }
                case ModulosEnum.Bhaskara:
                    {
                        _modulo = new BhaskaraModulo();
                        break;
                    }
                case ModulosEnum.SomaPares:
                    {
                        _modulo = new SomaParesModulo();
                        break;
                    }
                case ModulosEnum.Ordenacao:
                    {
                        _modulo = new OrdenacaoModulo();
                        break;
                    }
                case ModulosEnum.Linq:
                    {
                        _modulo = new LinqModulo();
                        break;
                    }
            }
        }
        private static void CarregarModulos()
        {
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.Calculadora));
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.Funcionarios));
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.Multiplos));
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.Alunos));
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.Bhaskara));
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.RefOut));
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.SomaPares));
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.Ordenacao));
            modulos.Add(ObterTuplaDoModulo(ModulosEnum.Linq));
        }
        private static Tuple<int, string> ObterTuplaDoModulo(ModulosEnum modeloEnum)
        {
            return Tuple.Create((int)modeloEnum, modeloEnum.ToString());
        }
    }
    public enum ModulosEnum
    {
        Calculadora = 1,
        Funcionarios = 2,
        Multiplos = 3,
        Alunos = 4,
        Bhaskara = 5,
        RefOut = 6,
        SomaPares = 7,
        Ordenacao = 8,
        Linq = 9
    }
}
