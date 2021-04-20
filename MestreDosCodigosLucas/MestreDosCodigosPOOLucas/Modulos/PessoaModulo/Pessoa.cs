using System;

namespace MestreDosCodigosPOOLucas.Modulos.PessoaModulo
{
    public class Pessoa
    {
        private string _nome;
        private DateTime _dataNascimento;
        private double _altura;
        public Pessoa()
        {

        }
        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            _nome = nome;
            _dataNascimento = dataNascimento;
            _altura = altura;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }      
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }     
        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
        public int Idade => CalcularIdade();

        private int CalcularIdade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;
            return DateTime.Now.DayOfYear < DataNascimento.DayOfYear ? idade - 1 : idade;
        }
        public void ImprimirPessoa()
        {
            Console.WriteLine($"Pessoa: {Nome}");
            Console.WriteLine($"Data de nascimento: {DataNascimento.ToShortDateString()}");
            Console.WriteLine($"Idade: {Idade} anos");
            Console.WriteLine($"Altura: {Altura}m");
        }
    }
}
