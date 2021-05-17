namespace MestreDosCodigosPOOLucas.Modulos.BancoModulo.Classes
{
    public abstract class ContaBancaria
    {
        public ContaBancaria(string numeroDaConta, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        public string NumeroDaConta { get; protected set; }
        public double Saldo { get; protected set; }

        public abstract void Sacar(double valor);

        public abstract void Depositar(double valor);

    }
}
