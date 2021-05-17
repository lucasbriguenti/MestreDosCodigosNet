using System;

namespace MestreDosCodigosPOOLucas.Modulos.BancoModulo.Classes
{
    public class ContaEspecial : ContaBancaria, Imprimivel
    {
        public double Limite { get; set; }

        public ContaEspecial(string numeroDaConta, double saldo, double limite) : base(numeroDaConta, saldo)
        {
            Limite = limite;
        }
        public void MostrarDados()
        {
            Console.WriteLine($"Conta Especial\nNúmero da conta: {NumeroDaConta}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Limite: {Limite}\n");
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                if (valor < Saldo)
                    Saldo -= valor;
            }
            else
            {
                var valorComLimite = valor - Limite;
                if (valorComLimite <= Saldo && Math.Abs(Saldo - valor) <= Limite)
                    Saldo -= valor;
            }
        }

        public override void Depositar(double valor)
        {
            if (valor > 0)
                Saldo += valor;
        }
    }
}
