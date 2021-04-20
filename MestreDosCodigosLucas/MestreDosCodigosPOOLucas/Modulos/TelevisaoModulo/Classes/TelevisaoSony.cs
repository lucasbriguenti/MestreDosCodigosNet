namespace MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo.Classes
{
    public class TelevisaoSony : IComandosTelevisao
    {
        private Status StatusLigada;
        private int Canal;
        private int Volume;

        public TelevisaoSony(Status statusLigada, int canal, int volume)
        {
            StatusLigada = statusLigada;
            Canal = canal;
            Volume = volume;
        }

        public string Nome => "TV da Sony";

        private bool Ligada => StatusLigada == Status.Ligada;

        public bool EstaLigada => Ligada;

        public void AumentarCanal()
        {
            if (Ligada && Canal < 100)
                Canal++;
        }

        public void AumentarVolume()
        {
            if (Ligada && Volume < 100)
                Volume++;
        }

        public (int, int) ConsultarVolumeECanalSelecionado()
        {
            return (Volume, Canal);
        }

        public void DiminuirCanal()
        {
            if (Ligada && Canal > 1)
                Canal--;
        }

        public void DiminuirVolume()
        {
            if (Ligada && Volume > 1)
                Volume--;
        }

        public void LigarDesligar()
        {
            StatusLigada = Ligada ? Status.Desligada : Status.Ligada;
        }

        public void TrocarCanal(int canalIndicado)
        {
            if (Ligada && canalIndicado > 0 && canalIndicado <= 100)
                Canal = canalIndicado;
        }
    }
    public enum Status
    {
        Ligada,
        Desligada
    }
}
