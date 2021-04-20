namespace MestreDosCodigosPOOLucas.Modulos.BancoModulo.Classes
{
    public abstract class ContaBancaria
    {
        protected ContaBancaria(string numeroDaConta, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        public string NumeroDaConta { get; protected set; }
        public double Saldo { get; protected set; }

        protected void Sacar(double valor)
        {
            if(valor < Saldo)
               Saldo -= valor;
        }
        public void Depositar(double valor)
        {
            if(valor > 0)
                Saldo += valor;
        }

    }
}
