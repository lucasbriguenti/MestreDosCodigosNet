using MestreDosCodigosPOOLucas.Modulos.BancoModulo.Classes;
using System;

namespace MestreDosCodigosPOOLucas.Modulos.BancoModulo
{
    public class BancoModulo : Modulo
    {
        public void Executar()
        {
            ExecutarContaCorrente();
            Console.ReadLine();
            Console.Clear();
            ExecutarContaEspecial();
            Console.ReadLine();
        }

        public void ExecutarContaEspecial()
        {
            var contaEspecial = new ContaEspecial("3214-01", 20, 5);
            Imprimir(contaEspecial);
            Console.WriteLine("Sacando 25");
            contaEspecial.Sacar(25);
            Imprimir(contaEspecial);
            Console.WriteLine($"Depositando 50");
            contaEspecial.Depositar(50);
            Imprimir(contaEspecial);
        }
        private void ExecutarContaCorrente()
        {
            var contaCorrente = new ContaCorrente("1234-01", 20, 2);
            Imprimir(contaCorrente);
            Console.WriteLine($"Sacando 10");
            contaCorrente.Sacar(10);
            Imprimir(contaCorrente);
            Console.WriteLine($"Depositando 50");
            contaCorrente.Depositar(50);
            Imprimir(contaCorrente);
        }
        public void Imprimir(Imprimivel conta)
        {
            conta.MostrarDados();
        }
    }
}
