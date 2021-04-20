using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MestreDosCodigosLucas.Modulos.Ordenacao
{
    public class OrdenacaoModulo : Modulo
    {
        private List<decimal> decimais = new List<decimal>();
        public void Executar()
        {
            LerParametros();
            Console.Clear();
            Console.WriteLine("Números ordenados crescente: ");
            decimais.OrderBy(x => x).ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine("Números ordenados decrescente: ");
            decimais.OrderByDescending(x => x).ToList().ForEach(n => Console.WriteLine(n));
        }

        private void LerParametros()
        {
            Console.WriteLine("Para parar de adicionar, aperte 0\nDigite os decimais: ");
            while(true)
            {
                Console.Write("Digite o número: ");
                decimal numero = -1;
                do
                {
                    if (!decimal.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.Write("Número inválido. Digite novamente: ");
                        numero = -1;
                    }
                } while (numero == -1);

                if (numero > 0)
                    decimais.Add(numero);
                else
                    break;
            }
        }
    }
}
