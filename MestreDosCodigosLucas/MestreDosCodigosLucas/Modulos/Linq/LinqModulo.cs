using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigosLucas.Modulos.Linq
{
    public class LinqModulo : Modulo
    {
        //Crie uma lista que receba inteiros.
        private readonly List<int> listaDeInteiros = new List<int>();
        public void Executar()
        {
            LerParametros();
            ExibirTodos();
            ExibirOrdenado(Ordem.Asc);
            ExibirOrdenado(Ordem.Desc);
            ExibirPrimeiroItemDaLista();
            ExibirUltimoItemDaLista();
            InserirNaLista(0, 10);
            InserirNaLista(listaDeInteiros.Count, 15);
            RemoverDaListaPrimeiraPosicao();
            RemoverDaListaUltimaPosicao();
            ImprimirApenasPares();
            ImprimirNumeroBuscado();
            TransformarEmArray();
        }
        private void TransformarEmArray()
        {
            Console.WriteLine("Transforme todos os números da lista em um Array.");
            var arrayDeInteiros = listaDeInteiros.ToArray();
            for (int i = 0; i < arrayDeInteiros.Length; i++)
                Console.WriteLine($"Número {arrayDeInteiros[i]} na posição {i} do Array.");
            Console.ReadLine();
        }
        private void ImprimirNumeroBuscado()
        {
            var numeroASerBuscado = 4;
            var numeroBuscado = BuscarNumero(numeroASerBuscado);
            Console.WriteLine("Retorne apenas o número informado.");
            if (numeroBuscado.HasValue)
                Console.WriteLine($"Número retornado: {numeroBuscado.Value}");
            else
                Console.WriteLine($"Não foi possível localizar o número {numeroASerBuscado} na lista");
            Console.ReadLine();
        }
        private int? BuscarNumero(int numeroASerBuscado)
        {
            if (!listaDeInteiros.Contains(numeroASerBuscado))
                return null;
            return listaDeInteiros.FirstOrDefault(x => x == numeroASerBuscado);
        }

        private void ImprimirApenasPares()
        {
            Console.WriteLine("Retorne apenas os números pares.");
            listaDeInteiros.Where(x => x % 2 == 0).ToList().ForEach(n => Console.WriteLine(n));
            Console.ReadLine();
        }
        private void RemoverDaListaUltimaPosicao()
        {
            Console.WriteLine($"Remova o último número.");
            var numeroASerRemovido = listaDeInteiros.LastOrDefault();
            listaDeInteiros.Remove(numeroASerRemovido);
            Console.WriteLine($"Número {numeroASerRemovido} da última posição.");
            ExibirLista();
            Console.ReadLine();
        }
        private void RemoverDaListaPrimeiraPosicao()
        {
            Console.WriteLine($"Remova o primeiro número.");
            var numeroASerRemovido = listaDeInteiros.FirstOrDefault();
            listaDeInteiros.Remove(numeroASerRemovido);
            Console.WriteLine($"Número {numeroASerRemovido} da primeira posição.");
            ExibirLista();
            Console.ReadLine();
        }
        private void InserirNaLista(int posicao, int valor)
        {
            var posicaoDescricao = posicao == 0 ? "início" : "final";
            Console.WriteLine($"Insira um número no {posicaoDescricao} da lista.");
            listaDeInteiros.Insert(posicao, valor);
            Console.WriteLine($"Inserido no {posicaoDescricao} o numero {valor}");
            ExibirLista();
            Console.ReadLine();
        }

        private void ExibirPrimeiroItemDaLista()
        {
            Console.WriteLine("Imprima apenas o primeiro número da lista.");
            Console.WriteLine(listaDeInteiros.FirstOrDefault());
            Console.ReadLine();
        }
        private void ExibirUltimoItemDaLista()
        {
            Console.WriteLine("Imprima apenas o ultimo número da lista.");
            Console.WriteLine(listaDeInteiros.LastOrDefault());
            Console.ReadLine();
        }
        private void ExibirOrdenado(Ordem ordem)
        {
            var ordemDescricao = ordem == Ordem.Asc ? "crescente" : "descendente";
            Console.WriteLine($"Imprimir todos os números da lista na ordem {ordemDescricao}.");

            if(ordem == Ordem.Asc)  listaDeInteiros.OrderBy(x => x).ToList().ForEach(n => Console.WriteLine(n));
            else listaDeInteiros.OrderByDescending(x => x).ToList().ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
        private void ExibirTodos()
        {
            Console.WriteLine("Imprimir todos os números da lista.");
            ExibirLista();
            Console.ReadLine();
        }
        private void ExibirLista()
        {
            listaDeInteiros.ForEach(n => Console.WriteLine(n));
        }
        private void LerParametros()
        {
            Console.WriteLine("Digite 0 para para a inserção.");
            while(true)
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.MinValue;
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
                    {
                        Console.WriteLine("Número inválido. Digite novamente: ");
                        numero = int.MinValue;
                    }
                } while (numero == int.MinValue);
                if (numero == 0)
                    break;
                else
                    listaDeInteiros.Add(numero);
            }
        }
    }

    public enum Ordem
    {
        Asc,
        Desc
    }
}
