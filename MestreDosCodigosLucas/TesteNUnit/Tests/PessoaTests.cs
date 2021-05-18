using MestreDosCodigosPOOLucas.Modulos.PessoaModulo;
using NUnit.Framework;
using System;

namespace TesteNUnit.Tests
{
    [TestFixture]
    public class PessoaTests
    {
        private Pessoa _pessoa;

        [Test]
        public void DeveCalcularIdadeCorretamente()
        {
            var anoNascimento = 40;
            var dataDeNascimento = DateTime.Now.AddYears(-anoNascimento);
            var idadeEsperada = DateTime.Now.DayOfYear < dataDeNascimento.DayOfYear ? anoNascimento - 1 : anoNascimento;
            _pessoa = new Pessoa(null, dataDeNascimento, 1.7);

            Assert.AreEqual(idadeEsperada, _pessoa.Idade);
        }
    }
}
