using MestreDosCodigosPOOLucas.Modulos;
using MestreDosCodigosPOOLucas.Modulos.PessoaModulo;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace TesteNUnit.Tests
{
    [TestFixture]
    public class ModuloPessoaTests
    {
        private Modulo _modulo;
        private Mock<ITestOutputHelper> testOutputHelper;

        [SetUp]
        public void Setup()
        {
            testOutputHelper = new Mock<ITestOutputHelper>();
            _modulo = new PessoaModulo(testOutputHelper.Object);
        }
        [Test]
        public void DeveGerarNoOutoutMensagemCorreta()
        {
            var msgEsperada = "Passou pelo output";

            _modulo.Executar();

            testOutputHelper.Verify(r => r.WriteLine(It.Is<string>(a => a == msgEsperada)));
        }
        [Test]
        public void DeveTerExibirQuePassouNoOutput()
        {
            _modulo.Executar();

            testOutputHelper.Verify(r => r.WriteLine(It.IsAny<string>()), Times.Once);
        }
    }
}
