using MestreDosCodigosPOOLucas.Modulos;
using MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo;
using MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo.Classes;
using Moq;
using NUnit.Framework;
using Xunit.Abstractions;

namespace TesteNUnit.Tests
{
    [TestFixture]
    public class ModuloTelevisaoTests
    {
        private TelevisaoModulo _modulo;
        private Mock<ITestOutputHelper> testOutputHelper;
        [SetUp]
        public void SetUp()
        {
            testOutputHelper = new Mock<ITestOutputHelper>();
            _modulo = new TelevisaoModulo(testOutputHelper.Object);
        }

        [Test]
        public void DeveAdicionarNovaTelevisao()
        {
            var qtdeEsperada = _modulo.controleRemoto.QuantidadeTelevisoesSuportadas + 1;
            _modulo.AdicionarTelevisaoAoControle(new TelevisaoLG(true, 10, 10, 50));

            Assert.AreEqual(_modulo.controleRemoto.QuantidadeTelevisoesSuportadas, qtdeEsperada);
        }

        [Test]
        public void DeveContarTresExibicoesAoExecutar()
        {
            var qtdeEsperada = 3;
            _modulo.Executar();

            Assert.AreEqual(_modulo.contadorDeExibicoes, qtdeEsperada);
        }
    }
}
