using MestreDosCodigosLucas.Modulos.Calculadora;
using Xunit;

namespace TesteXUnit.Tests
{
    public class CalculadorTests
    {
        private readonly Calculador _calculador;
        private readonly double valor1, valor2;

        public CalculadorTests()
        {
            _calculador = new Calculador();
            valor1 = 10;
            valor2 = 15;
        }

        [Fact]
        public void DeveRetornarZeroSeForParOuImpar()
        {
            var respostaEsperada = 0d;

            var retorno = _calculador.Calcular(10, 10, FuncaoCalculadora.ParOuImpar);

            Assert.Equal(retorno, respostaEsperada);
        }

        [Theory]
        [InlineData(FuncaoCalculadora.Soma)]
        [InlineData(FuncaoCalculadora.Subtracao)]
        [InlineData(FuncaoCalculadora.Divisao)]
        [InlineData(FuncaoCalculadora.Multiplicacao)]
        public void DeveCalcularDeAcordoComAFuncaoSelecionada(FuncaoCalculadora funcao)
        {
            var valorEsperado = ObterValorEsperado(funcao);

            var retorno = _calculador.Calcular(valor1, valor2, funcao);

            Assert.Equal(valorEsperado, retorno);
        }

        public double ObterValorEsperado(FuncaoCalculadora funcao)
        {
            return funcao switch
            {
                FuncaoCalculadora.Soma => valor1 + valor2,
                FuncaoCalculadora.Subtracao => valor1 - valor2,
                FuncaoCalculadora.Multiplicacao => valor1 / valor2,
                FuncaoCalculadora.Divisao => valor1 * valor2,
                _ => 0,
            };
        }
    }
}
