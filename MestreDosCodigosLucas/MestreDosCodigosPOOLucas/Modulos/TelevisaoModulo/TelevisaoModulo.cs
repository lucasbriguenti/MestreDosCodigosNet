using MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo.Classes;
using System;
using Xunit.Abstractions;

namespace MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo
{
    public class TelevisaoModulo : Modulo
    {
        private bool IsTest => testOutputHelper != null;
        private readonly ITestOutputHelper testOutputHelper;
        public readonly ControleRemotoUniversal controleRemoto = new ControleRemotoUniversal();
        public int contadorDeExibicoes = 0;
        public TelevisaoModulo()
        {

        }
        public TelevisaoModulo(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }
        public void Executar()
        {
            var tvLG = new TelevisaoLG(true, 10, 15, 80);
            var tvSony = new TelevisaoSony(Status.Ligada, 25, 30);
            Executar(tvLG);
            Executar(tvSony);
            Executar(tvLG, tvSony);
        }
        private void Executar(params IComandosTelevisao[] televisoes)
        {
            controleRemoto.LimparTelevisoesSuportadas();
            foreach (var tv in televisoes)
                AdicionarTelevisaoAoControle(tv);
            ExecutarComandos();
            if(!IsTest)
            {
                Console.Clear();
                Console.ReadLine();
            }
            contadorDeExibicoes++;
        }
        private void ExecutarComandos()
        {
            ExecutaFuncaoEExibe(controleRemoto.AumentarVolume);
            ExecutaFuncaoEExibe(controleRemoto.DiminuirVolume);
            ExecutaFuncaoEExibe(controleRemoto.AumentarCanal);
            ExecutaFuncaoEExibe(controleRemoto.DiminuirCanal);
            ExecutaFuncaoEExibe(acaoComParametro: controleRemoto.TrocarCanal);
            ExecutaFuncaoEExibe(controleRemoto.LigarDesligar);
        }

        private void ExecutaFuncaoEExibe(Action acao = null, Action<int> acaoComParametro = null)
        {
            Console.WriteLine(acao?.Method.Name ?? acaoComParametro?.Method.Name);
            acao?.Invoke();
            acaoComParametro?.Invoke(IsTest ? 10 : LerParametroTrocaCanal());
            controleRemoto.ImprimirCanalVolume();
        }

        private int LerParametroTrocaCanal()
        {
            var canalASerTrocado = int.MinValue;
            Console.Write("Digite o valor do canal: ");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out canalASerTrocado) || canalASerTrocado > 100 || canalASerTrocado < 1)
                {
                    Console.Write("Número inválido. Digite novamente: ");
                    canalASerTrocado = int.MinValue;
                }
            } while (canalASerTrocado == int.MinValue);
            return canalASerTrocado;
        }

        public void AdicionarTelevisaoAoControle(IComandosTelevisao televisao)
        {
            controleRemoto.AdicionarTelevisaoSuportada(televisao);
        }
    }
}
