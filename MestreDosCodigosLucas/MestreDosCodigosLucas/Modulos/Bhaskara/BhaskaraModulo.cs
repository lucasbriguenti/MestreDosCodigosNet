using System;

namespace MestreDosCodigosLucas.Modulos.Bhaskara
{
    public class BhaskaraModulo : Modulo
    {
        private int a, b, c;
        public void Executar()
        {
            LerParametros();
            double delta = (b * b) * (-4) * a * c;

            double x1 = ((-b) + Math.Sqrt(delta)) / 2 * a;
            double x2 = ((-b) - Math.Sqrt(delta)) / 2 * a;

            if(!double.IsNaN(x1) && !double.IsNaN(x2))
            {
                Console.WriteLine("O resultado do x linha é :" + Math.Round(x1));
                Console.WriteLine("Já o resultado de x duas linha é:" + Math.Round(x2));
            } 
            else
            {
                Console.WriteLine("Números inválidos");
            }
            Console.ReadLine();            
        
        }
        private void LerParametros()
        {
            Console.WriteLine("Digite os parametros: ");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
        }
    }
}
