namespace MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo.Classes
{
    public interface IComandosTelevisao
    {
        string Nome { get; }
        bool EstaLigada { get; }
        void LigarDesligar();
        void AumentarVolume();
        void DiminuirVolume();
        void TrocarCanal(int canalIndicado);
        void AumentarCanal();
        void DiminuirCanal();
        (int, int) ConsultarVolumeECanalSelecionado();
    }

}
