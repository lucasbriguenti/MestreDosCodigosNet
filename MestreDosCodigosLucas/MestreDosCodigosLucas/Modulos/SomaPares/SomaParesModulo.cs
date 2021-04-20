using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MestreDosCodigosLucas.Modulos.SomaPares
{
    public class SomaParesModulo : Modulo
    {
        private List<int> parametros = new List<int>();
        public void Executar()
        {
            LerParametros();

            var somaParametrosPares = parametros.Where(x => x % 2 == 0).Sum(x => x);
            Console.WriteLine($"Soma dos parametros pares: {somaParametrosPares}");
            Console.ReadLine();
        }
        private void LerParametros()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{i + 1}° Parametro: ");
                int param = 0;
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out param))
                    {
                        Console.WriteLine("Número inválido. Digite novamente: ");
                        param = 0;
                    }
                } while (param == 0);
                parametros.Add(param);
            }
        }
    }
}
