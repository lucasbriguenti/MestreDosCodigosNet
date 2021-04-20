using System;

namespace MestreDosCodigosLucas.Modulos.Multiplos
{
    public class MultiplosModulo : Modulo
    {
        public void Executar()
        {
            var count = 1;
            while (count <= 100)
            {
                if (count % 3 == 0)
                    Console.WriteLine($"O número {count} é multiplo de 3");
                count++;
            }
            Console.ReadLine();
        }
    }
}
