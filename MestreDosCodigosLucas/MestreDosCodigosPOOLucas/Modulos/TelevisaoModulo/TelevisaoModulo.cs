using MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo.Classes;
using System;
using System.Collections.Generic;

namespace MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo
{
    public class TelevisaoModulo : Modulo
    {
        private readonly ControleRemotoUniversal controleRemoto = new ControleRemotoUniversal();
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
                controleRemoto.AdicionarTelevisaoSuportada(tv);
            ExecutarComandos();
            Console.ReadLine();
            Console.Clear();
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
            acaoComParametro?.Invoke(LerParametroTrocaCanal());
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
    }
}
