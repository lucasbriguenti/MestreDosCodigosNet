using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace MestreDosCodigosPOOLucas.Modulos.PessoaModulo
{
    public class PessoaModulo : Modulo
    {
        private readonly ITestOutputHelper _output;
        public PessoaModulo()
        {

        }

        public PessoaModulo(ITestOutputHelper output)
        {
            _output = output;
        }

        public void Executar()
        {
            var pessoa = new Pessoa("Lucas Briguenti", new DateTime(1996,03,02), 1.70);
            pessoa.ImprimirPessoa();
            if(_output != null)
            {
                _output.WriteLine("Passou pelo output");
            }
        }
    }
}
