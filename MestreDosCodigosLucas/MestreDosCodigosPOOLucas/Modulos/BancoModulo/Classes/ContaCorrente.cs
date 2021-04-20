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

        public new void Sacar(double valor)
        {
            base.Sacar(valor + TaxaDeOperacao);
        }
        public new void Depositar(double valor)
        {
            base.Depositar(valor - TaxaDeOperacao);
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Conta Corrente\nNúmero da conta: {NumeroDaConta}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Taxa de Operação: {TaxaDeOperacao}\n");
        }
    }
}
