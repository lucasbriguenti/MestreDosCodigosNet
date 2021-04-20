using MestreDosCodigosPOOLucas.Modulos;
using MestreDosCodigosPOOLucas.Modulos.PessoaModulo;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace TesteXUnit.Tests
{
    public class ModuloPessoaTests
    {
        private readonly Modulo _modulo;
        private readonly Mock<ITestOutputHelper> testOutputHelper;
        public ModuloPessoaTests()
        {
            testOutputHelper = new Mock<ITestOutputHelper>();
            _modulo = new PessoaModulo(testOutputHelper.Object);
        }
        [Fact]
        public void DeveGerarNoOutoutMensagemCorreta()
        {
            var msgEsperada = "Passou pelo output";

            _modulo.Executar();

            testOutputHelper.Verify(r => r.WriteLine(It.Is<string>(a => a == msgEsperada)));
        }
        [Fact]
        public void DeveTerExibirQuePassouNoOutput()
        {
            _modulo.Executar();

            testOutputHelper.Verify(r => r.WriteLine(It.IsAny<string>()), Times.Once);
        }
    }
}
