using System;
using System.Collections.Generic;

namespace MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo.Classes
{
    public class ControleRemotoUniversal
    {
        private readonly List<IComandosTelevisao> _televisoesSuportadas = new List<IComandosTelevisao>();

        public void AdicionarTelevisaoSuportada(IComandosTelevisao novaTelevisao)
        {
            _televisoesSuportadas.Add(novaTelevisao);
        }
        public void LimparTelevisoesSuportadas()
        {
            _televisoesSuportadas.RemoveAll(x => true);
        }
        public void RemoverTelevisaoSuportada(IComandosTelevisao televisao)
        {
            _televisoesSuportadas.Remove(televisao);
        }
        public void AumentarVolume()
        {
            ExecutarFuncao(x => x.AumentarVolume());
        }

        public void DiminuirVolume()
        {
            ExecutarFuncao(x => x.DiminuirVolume());
        }
        public void DiminuirCanal()
        {
            ExecutarFuncao(x => x.DiminuirCanal());
        }
        public void AumentarCanal()
        {
            ExecutarFuncao(x => x.AumentarCanal());
        }
        public void TrocarCanal(int canalSelecionado)
        {
            ExecutarFuncao(x => x.TrocarCanal(canalSelecionado));
        }
        public void LigarDesligar()
        {
            ExecutarFuncao(x => x.LigarDesligar());
        }
        public void ImprimirCanalVolume()
        {
            ExecutarFuncao(x => 
            {
                (int volume, int canal) = x.ConsultarVolumeECanalSelecionado();
                Console.WriteLine(x.Nome);
                Console.WriteLine($"Ligada: {x.EstaLigada}\nCanal: {canal}\nVolume: {volume}\n");
            });
        }
        private void ExecutarFuncao(Action<IComandosTelevisao> comando)
        {
            _televisoesSuportadas.ForEach(comando);
        }
        public int QuantidadeTelevisoesSuportadas => _televisoesSuportadas.Count;
    }
}
