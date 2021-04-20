namespace MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo.Classes
{
    public class TelevisaoLG : IComandosTelevisao
    {
        private bool Ligada;
        private int Canal;
        private int Volume;
        private readonly int VolumeMaximo;

        public string Nome => "TV da LG";

        public bool EstaLigada => Ligada;

        public TelevisaoLG(bool ligada, int canal, int volume, int volumeMaximo)
        {
            Ligada = ligada;
            Canal = canal;
            Volume = volume;
            VolumeMaximo = volumeMaximo;
        }

        public void AumentarCanal()
        {
            if (Canal < 100 && Ligada)
                Canal++;
        }

        public void AumentarVolume()
        {
            if (Volume < VolumeMaximo && Ligada)
                Volume++;
        }

        public (int, int) ConsultarVolumeECanalSelecionado()
        {
            return (Volume, Canal);
        }

        public void DiminuirCanal()
        {
            if (Canal > 1 && Ligada)
                Canal--;
        }

        public void DiminuirVolume()
        {
            if (Volume > 1 && Ligada)
                Volume--;
        }

        public void LigarDesligar()
        {
            Ligada = !Ligada;
        }

        public void TrocarCanal(int canalIndicado)
        {
            if (canalIndicado > 1 && canalIndicado < 100 && Ligada)
                Canal = canalIndicado;
        }
    }
}
