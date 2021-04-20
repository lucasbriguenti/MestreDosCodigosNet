using MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo;
using MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo.Classes;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace TesteXUnit.Tests
{
    public class ModuloTelevisaoTests
    {
        private readonly TelevisaoModulo _modulo;
        private readonly Mock<ITestOutputHelper> testOutputHelper;
        public ModuloTelevisaoTests()
        {
            testOutputHelper = new Mock<ITestOutputHelper>();
            _modulo = new TelevisaoModulo(testOutputHelper.Object);
        }

        [Fact]
        public void DeveAdicionarNovaTelevisao()
        {
            var qtdeEsperada = _modulo.controleRemoto.QuantidadeTelevisoesSuportadas + 1;
            _modulo.AdicionarTelevisaoAoControle(new TelevisaoLG(true, 10, 10, 50));

            Assert.Equal(_modulo.controleRemoto.QuantidadeTelevisoesSuportadas, qtdeEsperada);
        }

        [Fact]
        public void DeveContarTresExibicoesAoExecutar()
        {
            var qtdeEsperada = 3;
            _modulo.Executar();

            Assert.Equal(_modulo.contadorDeExibicoes, qtdeEsperada);
        }
    }
}
