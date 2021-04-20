using System;
using System.Collections.Generic;
using System.Text;

namespace MestreDosCodigosPOOLucas.Modulos.PessoaModulo
{
    public class PessoaModulo : Modulo
    {
        public void Executar()
        {
            var pessoa = new Pessoa("Lucas Briguenti", new DateTime(1996,03,02), 1.70);
            pessoa.ImprimirPessoa();
        }
    }
}
