using System;

namespace MestreDosCodigosPOOLucas.Modulos.BancoModulo.Classes
{
    public class ContaCorrente : ContaBancaria, Imprimivel
    {
        public ContaCorrente(string numeroDaConta, double saldo, double taxaDeOperacao) : base(numeroDaConta, saldo)
        {
            TaxaDeOperacao = taxaDeOperacao;
        }
        public double TaxaDeOperacao { get; set; }

        public override void Depositar(double valor)
        {
            var valorCalculado = valor - TaxaDeOperacao;
            if (valorCalculado < Saldo)
                Saldo += valorCalculado;
        }
        public override void Sacar(double valor)
        {
            var valorCalculado = valor + TaxaDeOperacao;
            if (valorCalculado < Saldo)
                Saldo -= valorCalculado;
        }
        public void MostrarDados()
        {
            Console.WriteLine($"Conta Corrente\nNúmero da conta: {NumeroDaConta}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Taxa de Operação: {TaxaDeOperacao}\n");
        }


    }
}
