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
        public new void Sacar(double valor)
        {
            if(valor <= Saldo)
                base.Sacar(valor);
            else
            {
                var valorComLimite = valor - Limite;
                if (valorComLimite <= Saldo && Math.Abs(Saldo - valor) <= Limite)
                    Saldo -= valor;
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Conta Especial\nNúmero da conta: {NumeroDaConta}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Limite: {Limite}\n");
        }

    }
}
